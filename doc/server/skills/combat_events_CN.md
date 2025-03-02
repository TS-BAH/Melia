# 战斗事件系统
=============================================================================

## 简介
Melia 的核心战斗计算由一系列[可脚本化函数](../scripting/scriptable_functions.md)驱动。部分技能和增益效果需要动态调整计算过程，为此我们提供了**事件处理接口**机制。

### 传统方式的局限性
直接在核心脚本中硬编码修改逻辑会导致代码臃肿，例如：
```cs
[ScriptableFunction]
public float SCR_CalculateDamage(...)
{
    // 硬编码判断增益效果
    if (attacker.IsBuffActive(BuffId.BossDamageBuff) && target.Rank == MonsterRank.Boss)
        modifier.DamageMultiplier += 1; // 对Boss伤害+100%
}
```
随着技能和增益数量增加，此方式难以维护。

---

## 事件处理接口
### 接口分类
通过实现以下接口，可将逻辑封装到独立的技能/增益处理器中：

#### 增益（Buff）接口
```cs
IBuffCombatAttackBeforeCalcHandler    // 攻击计算前
IBuffCombatAttackAfterCalcHandler     // 攻击计算后
IBuffCombatDefenseBeforeCalcHandler   // 防御计算前
IBuffCombatDefenseAfterCalcHandler    // 防御计算后
// 其他类似接口...
```

#### 技能（Skill）接口
```cs
ISkillCombatAttackBeforeCalcHandler   // 攻击计算前
ISkillCombatAttackAfterCalcHandler    // 攻击计算后
ISkillCombatDefenseBeforeCalcHandler  // 防御计算前
// 其他类似接口...
```

### 接口方法参数
所有接口方法均包含以下参数：
- `attacker/target`：攻击方/受击方实体
- `skill`：当前生效技能
- `modifier`：伤害修正器（可调整倍率/暴击等）
- `skillHitResult`：命中结果（可修改最终伤害）

---

## 事件类型与应用场景
### 攻击与防御事件
| 事件类型   | 作用对象       | 典型应用场景                          |
|------------|----------------|---------------------------------------|
| `Attack`   | **攻击方**增益 | 增强攻击力/暴击率/附加元素伤害        |
| `Defense`  | **受击方**增益 | 减伤/反弹伤害/触发护盾                |

### 计算阶段
| 阶段            | 修改建议                      |
|-----------------|-------------------------------|
| `BeforeCalc`    | 调整基础属性（推荐）          |
| `AfterCalc`     | 修改最终结果（如伤害分流）    |
| `BeforeBonuses` | 影响加成系数（如暴击倍率）    |
| `AfterBonuses`  | 处理最终伤害（罕见使用）      |

---

## 实现示例
### 攻击增益：对Boss增伤
```cs
[BuffHandler(BuffId.BossDamageBuff)]
public class BossDamageBuff : BuffHandler, IBuffCombatAttackBeforeCalcHandler
{
    public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
    {
        // 当攻击者携带此Buff且目标为Boss时，伤害倍率+100%
        if (target.Rank == MonsterRank.Boss)
            modifier.DamageMultiplier += 1; 
    }
}
```

### 防御增益：Boss减伤
```cs
[BuffHandler(BuffId.BossDefenseBuff)]
public class BossDefenseBuff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
{
    public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
    {
        // 当受击者携带此Buff且攻击者为Boss时，伤害倍率-50%
        if (attacker.Rank == MonsterRank.Boss)
            modifier.DamageMultiplier -= 0.5f; 
    }
}
```

---

## 最佳实践
1. **明确作用对象**  
   - 攻击方逻辑使用 `Attack` 事件  
   - 受击方逻辑使用 `Defense` 事件

2. **优先使用早期阶段**  
   在 `BeforeCalc` 阶段修改属性，避免后期计算覆盖

3. **参考核心脚本**  
   学习 `system/scripts/zone/core/combat` 中的实现，例如：  
   - **伤害链接**：使用 `AfterCalc` 实现伤害分摊  
   - **暴击修正**：在 `BeforeBonuses` 调整暴击率

4. **避免循环触发**  
   在事件处理中谨慎调用可能引发新战斗事件的操作