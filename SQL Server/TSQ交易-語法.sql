--transaction 交易
--必須要有commit，否則會卡死。
--交易途中，此資料會被上鎖，因而讀不到資料。
begin transaction
update userinfo set password ='null' 
--commit

select * from lockInfo
