--triggerĲ�o����(�p�Gtrigger�s�b)
drop trigger if exists userinfo_update
go
create trigger userinfo_update on userinfo for update
as 
--trigger�ʧ@
--declare �Ψӫŧi�ܼ�
begin
	declare @uid1 nvarchar(50)
	declare @cname1 nvarchar(50)
	declare @body nvarchar(200)
	declare @uid2 nvarchar(50)
	declare @cname2 nvarchar(50)


	select @uid2=uid,@cname2=cname from inserted
	select @uid1=uid,@cname1=cname from deleted

	select @body = concat(
		'�bUserinfo��ƪ��N',@uid1,',',@cname1,'�קאּ',@uid2,',',@cname2
		)
	insert into log (body) values (@body)
end