// 以 Express 建立 Web 伺服器
var express = require("express");
var app = express();

// 以 body-parser 模組協助 Express 解析表單與JSON資料
var bodyParser = require('body-parser');
app.use( express.json() );
app.use( express.urlencoded({extended: false}) );

// Web 伺服器的靜態檔案置於 public 資料夾
app.use( express.static( "public" ) );

// 以 express-session 管理狀態資訊
var session = require('express-session');
app.use(session({
    secret: 'secretKey',
    resave: false,
    saveUninitialized: true
}));

// 指定 esj 為 Express 的畫面處理引擎
app.set('view engine', 'ejs');
app.engine('html', require('ejs').renderFile);
app.set('views', __dirname + '/view');

// 一切就緒，開始接受用戶端連線
app.listen(80);
console.log("Web伺服器就緒，開始接受用戶端連線.");
console.log("「Ctrl + C」可結束伺服器程式.");
//連線參數設定
var sql = require('mssql');
var config = {
    user:'sa',
    password:'1234',
    server:'127.0.0.1\\SQLEXPRESS',
    port:1433,
    database:'newsDb',
    options: {
        encrypt: false,
        trustServerCertificate: true
    }
};
//使用 mssql 的 connect 方法嘗試與資料庫建立連接
sql.connect(config, 
    function (err) {
        console.log(err); // 如果連接失敗，err 會是錯誤訊息
    }
)
// 項目查詢功能
app.get("/home/news", async function (request, response) {
	var x = await sql.connect(config);                       // 連線資料庫
	const result = await sql.query("select * from news");    // SQL-code(查詢資料)
	response.send(JSON.stringify(result.recordset));         // 送出資料
})

// 項目新增功能
app.post("/home/news", async function (request, response) { 
	var x = await sql.connect(config);                       // 連線資料庫
    var title = request.body.title || "default";                           // 取得輸入資料，預設為default
    var ymd = request.body.ymd || new Date().toISOString().split('T')[0]; // 如果沒有輸入 ymd，則使用當前日期
    var code = `insert into news (title, ymd) values ( 
        '${title}', 
        '${ymd}'
        )`;                                                                            
	const result = await sql.query(code);             // SQL-code(新增資料)   
    response.send("資料新增!!");                 // 回傳訊息
})

// 項目修改功能
app.put("/home/news", async function (request,response) {
    var x = await sql.connect(config);                       // 連線資料庫

    var code = `update news set 
        title = '${request.body.title}', 
        ymd = '${request.body.ymd}' 
        where newsId = ${request.body.newsId}`; 
    const result = await sql.query(code); 
    response.send("資料已修改");               // SQL-code(修改資料)
})

// 項目刪除功能

app.delete("/home/news", async function(request,response){
    var x = await sql.connect(config);
    var code = `delete from news                            
        where newsId = ${request.body.newsId}`;
    const result =await sql.query(code);         // SQL-code(刪除資料)  
    response.send("資料已刪除");                  // 回傳訊息                
})





