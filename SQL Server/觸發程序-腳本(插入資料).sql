--triggerĲ�o����(�p�Gtrigger�s�b)
drop trigger if exists userinfo_insert
go
create trigger userinfo_insert on userinfo for insert
as 
--trigger�ʧ@
--print �L�X
--declare �Ψӫŧi�ܼ�
--begin end �p�P�j�A��
--Goto ��C�y��goto�@��
begin
	declare @uid nvarchar(50)
	declare @cname nvarchar(50)
	declare @body nvarchar(200)


	select @uid=uid,@cname=cname from inserted
	select @body = concat(
		'�bUserinfo��ƪ����J',@uid,',',@cname,'�����'
		)
	insert into log (body) values (@body)
end