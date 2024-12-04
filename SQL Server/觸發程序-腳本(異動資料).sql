--trigger觸發條件(如果trigger存在)
drop trigger if exists userinfo_update
go
create trigger userinfo_update on userinfo for update
as 
--trigger動作
--declare 用來宣告變數
begin
	declare @uid1 nvarchar(50)
	declare @cname1 nvarchar(50)
	declare @body nvarchar(200)
	declare @uid2 nvarchar(50)
	declare @cname2 nvarchar(50)


	select @uid2=uid,@cname2=cname from inserted
	select @uid1=uid,@cname1=cname from deleted

	select @body = concat(
		'在Userinfo資料表中將',@uid1,',',@cname1,'修改為',@uid2,',',@cname2
		)
	insert into log (body) values (@body)
end