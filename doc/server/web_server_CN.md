# Web 服务器
=============================================================================

由于连接非官方服务器需要 Web 服务器支持，Melia 内置了一个简易的 Web 服务器。

## 基础配置
- Web 服务器随其他服务一同启动，**默认端口为 80**。  
  本地运行时可通过 `http://127.0.0.1` 访问。
- **端口冲突处理**：若 80 端口被占用（如被其他程序使用），需执行以下操作之一：  
  1. 关闭占用端口的程序；  
  2. 修改 Melia 的 Web 服务器端口。

## 修改端口
1. 编辑配置文件 `system/conf/web.conf`；  
2. 调整端口参数（例如改为 8080）；  
3. 访问时需附加端口号：`http://127.0.0.1:8080`。

---
**注意事项**：  
- 修改配置后需重启服务生效。  
- 确保防火墙或安全组放行新端口的外部访问。