--triggerĲ�o����(�p�Gtrigger�s�b)
drop trigger if exists userinfo_update_constrain
go
create trigger userinfo_update_constrain on userinfo for update
as 
--trigger�ʧ@
--declare �Ψӫŧi�ܼ�
begin
	--declare @body nvarchar(50)
	--declare @n int
	--select @n = count(*)from deleted

	--@@rowcount ���B�Ψӭp��R������ƦC�ơAupdate(password)�����L���A
	--rollback �M�P�ާ@
	print @@rowcount
	if @@ROWCOUNT >1 and update(password)
	begin
		print'���i�ק�@���ⵧ�H�W���'
		rollback
	end

--	select @body = concat(
--		'�bUserinfo��ƪ����J',@uid,',',@cname,'�����'
--	)
	--insert into log (body) values (@body)
end