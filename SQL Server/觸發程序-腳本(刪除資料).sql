--triggerĲ�o����(�p�Gtrigger�s�b)
drop trigger if exists userinfo_delete
go
create trigger userinfo_delete on userinfo for delete
as 
--trigger�ʧ@ delete
--declare �Ψӫŧi�ܼ�
begin
	declare @uid nvarchar(50)
	declare @cname nvarchar(50)
	declare @body nvarchar(200)


	select @uid=uid,@cname=cname from deleted
	select @body = concat(
		'�bUserinfo��ƪ��R��',@uid,',',@cname,'�����'
		)
	insert into log (body) values (@body)
end