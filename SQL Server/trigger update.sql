--triggerĲ�o����(�p�Gtrigger�s�b)
drop trigger if exists userinfo_update
go
create trigger userinfo_update on userinfo for update
as 
--trigger�ʧ@
--declare �Ψӫŧi�ܼ�
begin
	declare @body nvarchar(200)
	declare @uid_old nvarchar(50)
	declare @cname_old nvarchar(50)
	declare @uid_new nvarchar(50)
	declare @cname_new nvarchar(50)


	select @uid_new=uid,@cname_new=cname from inserted
	select @uid_old=uid,@cname_old=cname from deleted

	select @body = concat(
		'�bUserinfo��ƪ��N',@uid_old,',',@cname_old,'�קאּ',@uid_new,',',@cname_new
		)
	insert into log (body) values (@body)
end