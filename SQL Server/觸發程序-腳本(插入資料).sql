--trigger觸發條件(如果trigger存在)
drop trigger if exists userinfo_insert
go
create trigger userinfo_insert on userinfo for insert
as 
--trigger動作
--print 印出
--declare 用來宣告變數
--begin end 如同大括號
--Goto 跟C語言goto一樣
begin
	declare @uid nvarchar(50)
	declare @cname nvarchar(50)
	declare @body nvarchar(200)


	select @uid=uid,@cname=cname from inserted
	select @body = concat(
		'在Userinfo資料表中插入',@uid,',',@cname,'的資料'
		)
	insert into log (body) values (@body)
end