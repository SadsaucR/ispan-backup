drop trigger if exists userinfo_delete_instead
go
--instead of delete 偵測刪除行為，且不執行刪除動作。
create trigger userinfo_delete_instead on userinfo instead of delete
as 
begin
	declare @uid nvarchar(50)
	select @uid=uid from deleted
	update UserInfo set isdeleted = 1,[modify time]=getdate() where uid =@uid

end