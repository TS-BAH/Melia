﻿using System;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;
using System.Threading.Tasks;

namespace Melia.Zone.Buffs.Handlers.Archer.Wugushi
{
	/// <summary>
	/// Handle for the Virus Debuff, which ticks damage while active.
	/// </summary>
	[BuffHandler(BuffId.Virus_Debuff)]
	public class Virus_Debuff : BuffHandler
	{
		public override async void WhileActive(Buff buff)
		{
			var target = buff.Target;

			if (target.Hp > 0)
			{
				if (buff.Caster.TryGetSkill((SkillId)buff.NumArg2, out var skill))
				{
					var damageMultiplier = 1f;

					if (buff.Caster.TryGetBuff(BuffId.Zhendu_Buff, out var ZhenduBuff))
						damageMultiplier = ZhenduBuff.NumArg1;

					var skillHitResult = SCR_SkillHit(buff.Caster, target, skill);
					skillHitResult.Damage *= damageMultiplier;

					// The damage amount is unknow, for now we are dealing
					// the same amount as the original skill does
					target.TakeDamage(skillHitResult.Damage, buff.Caster);

					var hit = new HitInfo(buff.Caster, target, SkillId.Wugushi_WugongGu, skillHitResult.Damage, HitResultType.Buff26);

					Send.ZC_HIT_INFO(buff.Caster, target, hit);
				}

				var damageThickDelay = 1000f;
				var skillLevel = (int)buff.NumArg1;

				Crescendo_Bane_Buff.TryApply(buff.Caster, ref damageThickDelay);

				await Task.Delay(TimeSpan.FromMilliseconds(damageThickDelay));
			} else
			{
				var maxSpreadAmount = 5;

				// Spreads to nearby targets
				foreach (var spreadTarget in target.Map.GetAttackableEntitiesInRange(buff.Caster, target.Position, 25).LimitRandom(maxSpreadAmount))
				{
					spreadTarget.StartBuff(BuffId.Virus_Debuff, buff.NumArg1, buff.NumArg2, TimeSpan.FromSeconds(10), buff.Caster);
				}
			}
		}
	}
}
