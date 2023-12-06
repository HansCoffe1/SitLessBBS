# BBS
基于asp.net core mvc 3.1/net core3.1 EfCore3编写的轻量级社区论坛系统
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
    "Title": "XXX论坛",
    "From": 2019
  }
}
```
### 数据库MySql执行文件(bbsdb.sql)
### 演示
[前台](http://101.132.140.8:3610)

[后台](http://101.132.140.8:3610/admin)
账号：admin
密码：123456
### 截图
 ![截图](data:image/png;base64,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GBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFgHYyIAAABDGBMlhYffmFiW119/PV155ZXNOJg7ceLE5JbVjIkAAAAMYUyUFB5+Y2JZbr311nT+/Pnmn9th8ezZs82vVzEmAgAAMIQxUVJ4+I2JZbv55pvXujrRmAgAAMAQ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])
