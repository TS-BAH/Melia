# 用户文件夹
=============================================================================

服务器通过 `system` 和 `user` 两个文件夹管理数据。项目开发者主要维护 `system` 文件夹，而用户可通过 `user` 文件夹扩展或覆盖服务器数据，无需担心更新导致修改丢失或冲突。

`user` 文件夹中的数据库、配置文件和脚本具有更高优先级。虽然可直接修改 `system` 文件夹，但强烈建议仅使用 `user` 文件夹，这不仅能安全应对更新，还便于备份和管理。

---

## 目录
- [Configuration](#配置文件)
- [Databases](#数据库)
- [Scripts](#脚本)

## 配置文件
配置文件优先从 `system` 加载，但每个文件末尾包含类似以下语句：
```text
include "/user/conf/world.conf"
```
这表示服务器在加载完 `system` 配置后，会继续加载 `user` 的同名文件，并覆盖已有配置值。

**示例**：修改数据库密码  
1. 创建 `user/conf/database.conf`；  
2. 复制 `system/conf/database.conf` 中的 `pass: ` 字段并修改值：  
```text
pass : yourpassword
```

---

## 数据库
`user/db` 中的文本数据库文件可覆盖或扩展 `system/db` 的数据。大部分场景（如修改物品、怪物属性）操作直观。

**示例**：修改物品重量  
1. 创建 `user/db/items.txt`；  
2. 定义相同 `itemId` 的条目并覆盖字段：  
```json
[
{ itemId: 101101, className: "SWD01_101", name: "旧短剑", type: "Equip", group: "武器", weight: 20 /* 覆盖原值90 */ }
]
```

---

## 脚本
### 脚本列表
脚本加载列表（如 `system/scripts/zone/scripts_custom.txt`）通过 `include` 语句包含用户脚本：
```text
include "/user/scripts/zone/scripts_custom.txt"
```
用户脚本会追加到加载列表中，不会覆盖系统脚本。

### 重定向机制
使用 `divert` 语句可完全覆盖系统脚本列表：
```text
divert "/user/scripts/zone/scripts.txt"
```
例如，创建空文件 `user/scripts/zone/scripts.txt` 可阻止加载所有系统脚本。

### 文件覆盖
若用户文件夹存在同名脚本文件（如 `user/scripts/zone/custom/test.cs`），将完全覆盖 `system` 中的对应文件。

---
**提示**：  
- 修改后需重启服务器使配置生效。  
- 优先通过 `user` 文件夹操作，确保更新兼容性。