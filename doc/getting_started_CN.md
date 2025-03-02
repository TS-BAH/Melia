# 入门指南  
=============================================================================  

## 设置（Windows）  

### 环境要求  

* **MySQL兼容的数据库服务器**  
  例如：[MySQL Server Community Edition](http://dev.mysql.com/downloads/mysql/) 或 [MariaDB](http://mariadb.org/)  
* **MySQL管理工具**  
  例如：[HeidiSQL](http://www.heidisql.com/)  
* [Git](http://git-scm.com/downloads)（可选）  
* [Microsoft Visual Studio 2019+](https://visualstudio.microsoft.com/vs/community/)  

### 获取源代码  

最简单的方式是访问 [GitHub](https://github.com/aura-project/melia)，点击仓库页面的 **“Download ZIP”** 按钮下载源代码。  

若想使用 Git（命令行工具管理仓库），更新会更方便，无需重复下载 ZIP 文件或手动合并新旧文件。  
安装 Git 后，打开命令提示符（按 `Win + R`，输入 `cmd` 并回车），通过 `cd` 命令切换到目标目录，输入以下命令：  
```  
git clone https://github.com/NoCode-NoLife/melia.git  
```  
此命令会将仓库克隆到当前目录下的 `melia` 子文件夹中。  

若需更新代码，进入 `melia` 文件夹后执行：  
```  
git pull  
```  
此命令会从线上仓库拉取最新更改。  

### 配置数据库  

下载并安装 MySQL 或 MariaDB。完成后，使用查询工具（如 HeidiSQL）打开 `<melia目录>/sql/main.sql` **并执行该脚本**，以创建 Melia 所需的基础数据库结构。  

接着，进入 `user/conf/` 目录，创建 `database.conf` 文件，填写以下内容（替换为你的用户名和密码）：  
```  
user : <MySQL用户名>  
pass : <MySQL密码>  
```  
保存并关闭文件。  

### 编译项目  

在 Visual Studio 中打开 `Melia.sln`。从 **“生成”** 菜单中选择 **“生成解决方案”** 或按 `F6` 键，Melia 将自动完成编译。  

编译完成后，运行 `start-all.bat` 即可启动服务器。  

## 连接到 Melia 服务器  

若要连接非官方服务器，需修改客户端的 `client.xml` 文件中的 `ServerListURL` 和 `StaticConfigURL` 值。建议先备份原文件以便恢复。  

将 `ServerListURL` 指向服务器列表的 XML 地址，`StaticConfigURL` 指向包含 `static_Config.txt` 的目录。例如，若 Melia 的 Web 服务器运行在 8080 端口，配置示例如下：  
```xml  
<GameOption ServerListURL="http://127.0.0.1:8080/toslive/patch/serverlist.xml" StaticConfigURL="http://127.0.0.1:8080/toslive/patch/"  
```  

修改完成后，启动客户端即可。  

> **注意**：若需直接从 `TOS` 目录启动客户端，需添加启动参数 `-SERVICE`。  

## 创建账户  

在登录窗口输入 `new//账户名称`（将“账户名称”替换为你的账户名），服务器会以当前输入的密码创建账户。首次登录后，无需再添加 `new//` 前缀。  

## 成为 GM  

通过 [[GM 命令]] 可使用管理员功能。账户需满足最低权限等级。修改权限的方式有两种：  
1. 直接在数据库中调整账户的 `authority` 字段。  
2. 在登录服务器的控制台窗口输入命令 `auth` 修改。