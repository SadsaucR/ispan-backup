var express = require('express'); // 引入express模块
var webserver = express(); // 创建一个web服务器
webserver.use (express.static("./public")); // 设置静态文件目录
webserver.listen(3000); // 设置监听端口