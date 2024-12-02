--hashbytes 將此密碼'1234'進行加密轉碼
select*
from userinfo
select convert(varchar(200),hashbytes('sha2_512','1234'),2)