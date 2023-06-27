﻿//--- Melia Script ----------------------------------------------------------
// Combat Calculation Script
//--- Description -----------------------------------------------------------
// Functions that calculate combat-related values, such as damage.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Handlers;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Extensions;
using Yggdrasil.Logging;
using Yggdrasil.Util;

public class CombatCalculationsScript : GeneralScript
{
	/// <summary>
	/// Returns a random attack value between the min and max values
	/// for the type that matches the given skill (PATK or MATK).
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_GetRandomAtk")]
	public float SCR_GetRandomAtk(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		var rnd = RandomProvider.Get();

		float min, max;

		if (skill.Data.ClassType <= SkillClassType.Missile)
		{
			min = attacker.Properties.GetFloat(PropertyName.MINPATK);
			max = attacker.Properties.GetFloat(PropertyName.MAXPATK);
		}
		else
		{
			min = attacker.Properties.GetFloat(PropertyName.MINMATK);
			max = attacker.Properties.GetFloat(PropertyName.MAXMATK);
		}

		return rnd.Between(min, max);
	}

	/// <summary>
	/// Calculates the damage for the given skill if used by the attacker
	/// on the target, factoring in attack and defense properties.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction("SCR_CalculateDamage")]
	public float SCR_CalculateDamage(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		var SCR_GetRandomAtk = ScriptableFunctions.Combat.Get("SCR_GetRandomAtk");
		var SCR_GetDodgeChance = ScriptableFunctions.Combat.Get("SCR_GetDodgeChance");

		var rnd = RandomProvider.Get();

		var dodgeChance = SCR_GetDodgeChance(attacker, target, skill, skillHitResult);
		if (rnd.Next(100) < dodgeChance)
		{
			skillHitResult.Result = HitResultType.Dodge;
			return 0;
		}

		var damage = SCR_GetRandomAtk(attacker, target, skill, skillHitResult);

		var skillFactor = skill.Properties.GetFloat(PropertyName.SkillFactor);
		var skillAtkAdd = skill.Properties.GetFloat(PropertyName.SkillAtkAdd);
		damage *= skillFactor / 100f;
		damage += skillAtkAdd;

		var crtHr = attacker.Properties.GetFloat(PropertyName.CRTHR);
		if (rnd.Next(1000) < crtHr)
		{
			var crtAtk = attacker.Properties.GetFloat(PropertyName.CRTATK);
			damage += crtAtk;

			skillHitResult.Result = HitResultType.Crit;
		}

		var defPropertyName = skill.Data.ClassType != SkillClassType.Magic ? PropertyName.DEF : PropertyName.MDEF;
		var def = target.Properties.GetFloat(defPropertyName);
		damage = Math.Max(1, damage - def);

		// Check damage (de)buffs
		// I'm not aware of a general purpose buff or debuff property for
		// modifying damage that we could utilize to handle buffs like
		// ReflectShield_Buff, so we'll have to check for it explicitly.
		// Though this is neither elegant nor efficient, and we won't be
		// able to easily customize it either. It should probably be a
		// scriptable function in itself... TODO.
		if (target.Components.Get<BuffComponent>().TryGet(BuffId.ReflectShield_Buff, out var buff))
		{
			var skillLevel = buff.NumArg1;
			var byBuffRate = (skillLevel * 3 / 100f);

			damage = Math.Max(1, damage - damage * byBuffRate);

			var maxSp = target.Properties.GetFloat(PropertyName.MSP);
			var spRate = 0.7f / 100f;
			target.TrySpendSp(maxSp * spRate);
		}

		if ((skill.Id == SkillId.Common_DaggerAries || skill.Id == SkillId.Pistol_Attack) && attacker.Components.Get<BuffComponent>().Has(BuffId.DoubleAttack_Buff))
		{
			var rate = 40;

			if (rnd.Next(100) < rate)
			{
				damage *= 2;
				skillHitResult.HitCount = 2;
			}
		}
		else if (skill.Id == SkillId.Wizard_EarthQuake && target.Components.Get<BuffComponent>().Has(BuffId.Lethargy_Debuff))
		{
			damage *= 2;
			skillHitResult.HitCount = 2;
		}
		else if (skill.Id == SkillId.Wizard_EnergyBolt)
		{
			damage *= 2;
			skillHitResult.HitCount = 2;
		}

		return (int)damage;
	}

	/// <summary>
	/// Determines the result of the skill being used on the target,
	/// returning the damage that should be dealt and information
	/// about the hit, such as whether it was a crit.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public SkillHitResult SCR_SkillHit(ICombatEntity attacker, ICombatEntity target, Skill skill)
	{
		var SCR_CalculateDamage = ScriptableFunctions.Combat.Get("SCR_CalculateDamage");

		var result = new SkillHitResult();
		result.Damage = SCR_CalculateDamage(attacker, target, skill, result);

		return result;
	}

	/// <summary>
	/// Returns the chance for the target to dodge a hit from the attacker.
	/// </summary>
	/// <param name="attacker"></param>
	/// <param name="target"></param>
	/// <param name="skill"></param>
	/// <param name="skillHitResult"></param>
	/// <returns></returns>
	[ScriptableFunction]
	public float SCR_GetDodgeChance(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillHitResult skillHitResult)
	{
		var dr = target.Properties.GetFloat(PropertyName.DR);
		var hr = attacker.Properties.GetFloat(PropertyName.HR);

		// Preliminary formula based on simple player tests, such as
		// https://forum.treeofsavior.com/t/evasion-chance-in-tos/404534/11.
		// With this, the DR needs to be about twice the HR to reach a
		// chance of 50%+, and 90%, the presumed max, is reached at a
		// little under thrice the HR.

		var dodgeChance = Math2.Clamp(0, 90, (Math.Pow(dr / hr, 0.65f) - 1) * 100);

		return (float)dodgeChance;
	}
}
