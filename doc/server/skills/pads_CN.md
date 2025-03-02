# 区域触发器（Pads）
=============================================================================

## 简介
区域触发器（Pads）是游戏中用于管理范围效果（AoE）触发和效果目标的机制。在 Melia 中，Pads 被定义为地图上的特定区域，可监测角色或怪物进入/离开事件，并提供以下生命周期事件：
- **创建/销毁事件**：触发器生成或消失时触发
- **周期更新事件**：定时触发（默认间隔 1 秒）
- **进入/离开事件**：实体跨越区域边界时触发

Pads 同时作为客户端特效接收器，通过 `pad_skill_list.xml` 配置文件定义视觉效果（如技能特效），实现客户端与服务端的同步表现。

---

## 基础应用
### 技能场景示例
以下代码演示如何在技能处理器中创建圆形区域触发器：
```cs
// 创建半径为40的圆形区域触发器
var pad = new Pad(PadName.Foobar, caster, skill, new Circle(caster.Position, 40));

// 订阅进入事件和周期更新事件
pad.Trigger.Subscribe(TriggerType.Enter, OnPadEnter);
pad.Trigger.Subscribe(TriggerType.Update, OnPadUpdate);

// 将触发器添加到当前地图
caster.Map.AddPad(pad);

// 进入事件处理
void OnPadEnter(object sender, PadTriggerActorArgs args)
{
    var entity = args.Entity; // 获取触发实体
    // 示例：对进入的敌人施加灼烧效果
    if (entity is Mob mob)
        mob.AddBuff(BuffId.Burn, 10);
}

// 更新事件处理（每秒执行）
void OnPadUpdate(object sender, PadTriggerArgs args)
{
    var pad = args.Pad; // 获取触发器实例
    // 示例：持续造成范围伤害
    foreach (var entity in pad.GetEntities())
    {
        if (entity is Character character)
            character.TakeDamage(100, DamageType.Fire);
    }
}
```

---

## 事件类型与处理
### 事件分类
| 事件类型       | 参数类型                | 触发时机                   | 典型应用场景               |
|----------------|-------------------------|----------------------------|----------------------------|
| **Create**     | `PadTriggerArgs`        | 触发器创建时               | 初始化区域特效             |
| **Destroy**    | `PadTriggerArgs`        | 触发器销毁时               | 清理残留状态               |
| **Update**     | `PadTriggerArgs`        | 周期性触发（默认1秒/次）   | 持续伤害/治疗              |
| **Enter**      | `PadTriggerActorArgs`   | 实体进入区域时             | 施加减益/触发机关          |
| **Leave**      | `PadTriggerActorArgs`   | 实体离开区域时             | 移除状态/触发追击          |

### 自动事件绑定
通过 `[PadHandler]` 特性实现解耦处理，适合可复用触发器逻辑：
```cs
[PadHandler("FireZone")] // 绑定名为 FireZone 的触发器
public class FireZoneHandler : 
    ICreatePadHandler,    // 创建事件
    IUpdatePadHandler     // 更新事件
{
    public void Created(object sender, PadTriggerArgs args)
    {
        // 创建时播放火焰特效
        args.Pad.PlayEffect("F_fire_zone");
    }

    public void Updated(object sender, PadTriggerArgs args)
    {
        // 每秒对区域内敌人造成伤害
        foreach (var entity in args.Pad.GetEntities())
        {
            if (entity is Mob mob)
                mob.TakeDamage(200, DamageType.Fire);
        }
    }
}
```

---

## 高级技巧
1. **形状多样性**  
   除圆形 (`Circle`) 外，支持矩形 (`Rectangle`)、多边形 (`Polygon`) 等形状：
   ```cs
   var rectPad = new Pad(..., new Rectangle(startPos, endPos));
   var polyPad = new Pad(..., new Polygon(vertices)); // 顶点坐标数组
   ```

2. **动态调整区域**  
   可通过代码实时修改触发器范围和位置：
   ```cs
   pad.Shape = new Circle(newPos, 50); // 移动并扩大区域
   ```

3. **客户端特效同步**  
   在 `pad_skill_list.xml` 中配置特效映射，实现视觉同步：
   ```xml
   <PadSkill>
     <Name>FireZone</Name>
     <Effect>F_fire_zone</Effect>
   </PadSkill>
   ```

---
**最佳实践**：  
- 参考 `system/scripts/zone/skills` 中的 `Firewall.cs` 或 `Meteor.cs` 获取完整实现案例。  
- 复杂触发器建议使用 Handler 模式分离逻辑，提升代码可维护性。