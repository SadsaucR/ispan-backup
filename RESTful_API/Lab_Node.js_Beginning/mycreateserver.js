console.log("啟動server...");
var fs = require("fs"); // 引入檔案系統模組 FileSystem
var host = "10.0.101.79"; // 本機
var port = 80; // port
var express =require("express"); // 引入Express模組

var app = express(); // 建立Express物件

app.get("/", function (request, response) {
	response.redirect("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
});



app.use( express.static( "public" ) );

app.listen(port, host);