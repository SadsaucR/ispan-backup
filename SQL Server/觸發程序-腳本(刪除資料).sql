--trigger觸發條件(如果trigger存在)
drop trigger if exists userinfo_delete
go
create trigger userinfo_delete on userinfo for delete
as 
--trigger動作 delete
--declare 用來宣告變數
begin
	declare @uid nvarchar(50)
	declare @cname nvarchar(50)
	declare @body nvarchar(200)


	select @uid=uid,@cname=cname from deleted
	select @body = concat(
		'在Userinfo資料表中刪除',@uid,',',@cname,'的資料'
		)
	insert into log (body) values (@body)
end