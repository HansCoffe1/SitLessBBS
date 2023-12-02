# BBS
《坐不住》健康社区论坛系统
### 配置
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "MySQL": "server=localhost;user id=root;password=123456; database=bbsdb; charset=utf8"
  },
  "Sites": {
    "Title": "《坐不住》健康论坛",
    "From": 2023
  }
}
```
### 数据库MySql执行文件(bbsdb.sql)
### 演示
[前台](http://47.120.12.92:81/)
[后台](http://47.120.12.92:81/admin)
