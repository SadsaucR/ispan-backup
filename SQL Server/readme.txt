-----------------------------術語-----------------------------
schema 資料庫結構
SMSS 資料庫管理系統
entity 實體 -> table 資料表
attribute 屬性 -> field 欄位
relationship 關連性
正規化:將Table拆分成多份，防止資料重複，並且可以省下更多空間。
-------------------------SQL建置環境--------------------------
資料庫連接 SQL Server Express 環境
伺服器名稱:localhost\SQLEXPRESS
**首次執行，未建立安全性驗證，需勾選信任伺服器憑證，往後建議使用安全性加密。
---------------------------資料類別---------------------------
資料類別: EX---> binary(50) **bineary表示為二進制資料，(50)表示為資料給定長度**
資料類型/單位:
binary 二進制
bit 位元組
char 字元/字元數
*nchar 字元/字元數 限定語系 EN and 系統語言 only 較省空間
date 日期
float 浮點
geography 地理空間型別
image 影像
int 整數
variable 變數 
text 字串
varchar/*字元數 字元變數，依照給定資料量控制長度。**須注意varchar占用一字元格的跳脫序列\0。