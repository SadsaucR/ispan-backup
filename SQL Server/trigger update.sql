--trigger觸發條件(如果trigger存在)
drop trigger if exists userinfo_update
go
create trigger userinfo_update on userinfo for update
as 
--trigger動作
--declare 用來宣告變數
begin
	declare @body nvarchar(200)
	declare @uid_old nvarchar(50)
	declare @cname_old nvarchar(50)
	declare @uid_new nvarchar(50)
	declare @cname_new nvarchar(50)


	select @uid_new=uid,@cname_new=cname from inserted
	select @uid_old=uid,@cname_old=cname from deleted

	select @body = concat(
		'在Userinfo資料表中將',@uid_old,',',@cname_old,'修改為',@uid_new,',',@cname_new
		)
	insert into log (body) values (@body)
end