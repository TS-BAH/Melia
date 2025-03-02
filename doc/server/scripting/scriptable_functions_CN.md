# 可脚本化函数
=============================================================================

## 简介

本质上，可脚本化函数与普通 C# 方法无异，但服务器会收集并保存它们的引用，以便后续在任何地方调用。这使得通过名称全局快速调用方法变得容易，尤其适用于通过脚本覆盖方法或按名称引用方法（例如物品使用脚本）。

## 示例

以下示例展示了一个可脚本化函数，该函数通过名称 `SCR_USE_ITEM_EXPCARD` 在物品数据中被引用。当使用该物品时，系统会按名称获取函数并调用，参数由物品数据定义。
```cs
[ScriptableFunction]
public ItemUseResult SCR_USE_ITEM_EXPCARD(Character character, Item item, string strArg, float numArg1, float numArg2)
{
	var baseExp = (long)numArg1;
	var jobExp = (long)(baseExp * 0.77f);

	character.GiveExp(baseExp, jobExp, null);
	character.PlayEffect("F_sys_expcard_normal");

	return ItemUseResult.Okay;
}
```

## 属性

实现这一功能的关键是 `ScriptableFunction` 特性。所有属于 `GeneralScript` 类且标记了此特性的函数将被视为可脚本化函数，注册时默认使用函数名或特性中定义的字符串。例如，以下函数也会被注册为 `SCR_USE_ITEM_EXPCARD`：

```cs
[ScriptableFunction("SCR_USE_ITEM_EXPCARD")]
public ItemUseResult UseExpCard(Character character, Item item, string strArg, float numArg1, float numArg2)
```

## 类型

由于 C# 静态类型的限制，仅支持预定义的委托类型作为可脚本化函数。已定义的委托类型如下：

```cs
float Character(Character character);
float Monster(Mob monster);
float Skill(Skill skill);
float Combat(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);
SkillHitResult SkillHit(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier);
ItemUseResult ItemScriptFunc(Character character, Item item, string strArg, float numArg1, float numArg2);
NormalTxResult NormalTx(Character character, string strArg);
NormalTxResult NormalTxNum(Character character, int[] numArgs);
DialogTxResult DialogTx(Character character, DialogTxArgs args);
CustomCommandResult CustomCommand(Character character, int numArg1, int numArg2, int numArg3);
bool AbilityUnlock(Character character, string argStr, int argInt, AbilityData data);
void AbilityPrice(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time);
```

在 `GeneralScript` 中，任何匹配上述签名的函数若标记了 `ScriptableFunction` 特性，将被自动注册并支持全局调用。

## 调用方式

调用可脚本化函数时，只需获取其引用并像普通委托一样执行：

```cs
var func = ScriptableFunctions.Character.Get("SCR_Get_Character_MAXPATK");
var maxPatk = func(character);

// ...
```

## 应用场景

内部主要将可脚本化函数用于物品交互和战斗计算。例如，大多数战斗技能通过 `SCR_SkillHit` 计算伤害并判定命中结果（如暴击或闪避）。由于这些函数可脚本化，用户可通过自定义脚本轻松覆盖其行为。例如，以下代码将暴击率强制设为 50%：

```cs
[ScriptableFunction]
public float SCR_GetCritChance(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
{
	return 50;
}
```

## 扩展阅读

如需更多示例或了解可覆盖的函数，建议参考 Melia 中的脚本文件，尤其是 `system/scripts/zone/core/` 目录下的内容。