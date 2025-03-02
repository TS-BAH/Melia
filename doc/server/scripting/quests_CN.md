# 任务脚本
=============================================================================

任务通常通过继承专用类型 `QuestScript` 的脚本类进行定义，该类提供方法用于设置任务的目标、奖励等内容。

## 示例脚本
-----------------------------------------------------------------------------

```cs
public class KillOnions1TestQuestScript : QuestScript
{
	protected override void Load()
	{
		SetId("Melia.Test", 1);
		SetName("洋葱必须死");
		SetDescription("切开、剁碎，让这些洋葱形状的混蛋也尝尝哭的滋味！");

		AddObjective("kill", "击杀5个凯帕斯", new KillObjective(5, MonsterId.Onion));

		SetReceive(QuestReceiveType.Auto);
		AddPrerequisite(new LevelPrerequisite(2));

		AddReward(new ItemReward(ItemId.Card_Onion_The_Great));
		AddReward(new ItemReward(ItemId.OnionPiece_Red, 20));
		AddReward(new SilverReward(1000));
		AddReward(new ExpReward(1000, 500));
	}
}
```

## 基础信息
-----------------------------------------------------------------------------

### 任务ID

服务器通过 **任务ID**（questid）唯一标识任务。任务ID由命名空间和数值ID组成：命名空间用于区分任务组，数值ID需在1到65,535之间唯一。编写新任务时，请确保命名空间唯一（例如使用项目名称或任务类别），并递增数值ID。

```cs
SetId("Melia.Test", 1); // 内部存储为64位整数（48位命名空间 + 16位ID）
```

### 名称与描述

- `SetName`：任务名称，显示在客户端界面。
- `SetDescription`：任务描述，概述任务背景或目的。

## 任务目标
-----------------------------------------------------------------------------

目标定义了玩家完成任务所需执行的具体操作，例如击杀怪物、收集物品或与NPC对话。系统已提供常见目标类型，也可自定义。

### 内置目标类型
- `CollectItemObjective`：收集指定数量的物品。
- `KillObjective`：击杀指定数量的怪物。
- `SkillLevelObjective`：将技能提升至指定等级。
- `ManualObjective`：手动触发的目标（常用于NPC对话）。

```cs
// 示例：先击杀5个凯帕斯，再与NPC对话完成任务
AddObjective("kill", "击杀5个凯帕斯", new KillObjective(5, MonsterId.Onion));
AddObjective("talk", "与罗内萨对话", new ManualObjective());
```

**自定义目标**：继承 `QuestObjective` 类并实现逻辑。

## 前提条件
-----------------------------------------------------------------------------

任务可通过 `SetReceive` 设置发放方式：
- `QuestReceiveType.Auto`：自动发放（满足条件后自动接取）。
- `QuestReceiveType.Manual`：手动接取（默认，需通过NPC等方式触发）。

### 内置条件类型
- `CompletedPrerequisite`：需先完成指定任务。
- `LevelPrerequisite`：需达到指定等级。
- `SkillPrerequisite`：需将技能提升至指定等级。
- `OrPrerequisite`：满足任意一个子条件即可。

```cs
// 自动接取条件：完成 Melia.Test 任务1 且等级≥3
SetReceive(QuestReceiveType.Auto);
AddPrerequisite(new LevelPrerequisite(3));
AddPrerequisite(new CompletedPrerequisite("Melia.Test", 1));
```

**自定义条件**：继承 `QuestPrerequisite` 类并实现逻辑。

## 任务奖励
-----------------------------------------------------------------------------

任务完成时，玩家将获得预设的奖励。系统支持以下默认类型：
- `ExpReward`：基础经验与职业经验。
- `ItemReward`：物品（可指定数量）。
- `SilverReward`：银币。

```cs
AddReward(new ItemReward(ItemId.Card_Onion_The_Great)); // 奖励物品
AddReward(new SilverReward(1000)); // 奖励1000银币
```

**自定义奖励**：继承 `QuestReward` 类并实现逻辑。

## 钩子（Hooks）
-----------------------------------------------------------------------------

通过钩子机制，任务脚本可以拦截NPC对话并实现定制逻辑（例如推进任务进度）。

### 示例：任务对话拦截
```cs
protected override void Load()
{
	// ...其他配置
	AddDialogHook("Ronesa", "BeforeDialog", RonesaDialog); // 绑定NPC罗内萨的对话前钩子
}

private async Task<HookResult> RonesaDialog(Dialog dialog)
{
	var character = dialog.Player;

	// 检查玩家是否处于"talk"目标阶段
	if (!character.Quests.IsActive(this.QuestId, "talk"))
		return HookResult.Skip; // 跳过钩子逻辑

	// 执行任务对话
	await dialog.Msg("欢迎，今天需要什么帮助？");
	await dialog.Msg("哦，你接了我的任务？非常感谢你帮忙处理这些害虫。{nl}是时候有人来解决了。这是你的奖励。");

	character.Quests.Complete(this.QuestId); // 直接完成任务
	return HookResult.Break; // 终止后续对话
}
```

### NPC配置要求
NPC需显式启用钩子执行逻辑：
```cs
AddNpc(20104, "[饰品商人] 罗内萨", "Ronesa", "c_Klaipe", 269, -611, 90.0, async dialog =>
{
	dialog.SetTitle("罗内萨");
	dialog.SetPortrait("Dlg_port_KLAPEDA_ACCESSORY");

	// 尝试执行钩子
	if (await dialog.Hooks("BeforeDialog"))
		await dialog.Msg("既然来了，需要什么吗？{nl}我这里有些稀有商品。");
	else
		await dialog.Msg("欢迎。{nl}这里只卖稀有商品。");
});
```

---
**扩展建议**：更多示例可参考 Melia 的 `system/scripts/zone/core/` 目录下的脚本文件。