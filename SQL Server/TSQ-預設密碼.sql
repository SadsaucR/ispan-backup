--cursor �f�t while ����----
drop procedure if exists initpassword
go 
create procedure initpassword as 
--�{��
begin
--�ŧi cursor ����userinfo�����Q�R���B�S���K�X���Τ�
	declare d_pwd cursor for select uid,birthday from userinfo 
	where isdeleted is null and password is null
	declare @uid nvarchar(50)
	declare @pwd nvarchar(50)
	declare @bd datetime2
--�ʧ@
	--�Ncursor��������ưe�i�w�ŧi���ܼ�
	open d_pwd
	fetch d_pwd into @uid,@bd
	/*
	while �j�� (@@fetch_status : cursor����fetch�Ұh�^���� 0:���\ -1:���� -2:����)

	�ʧ@:
	1.�]�w@pwd �� @uid����X+@bd����day
	2.�N@pwd�e�J��ƪ��������Τ�(�Huid�P�w)
	3.���B��fetch�Ψӧ�U�@������ơA�õ����j��C
	�N�䬰:��cursor���\������ƮɡA�N��������ƥΨӳ]�w@pwd�A�ñN�Ȱe�J��A��U�@��...LOOP�C
	*/
	while @@FETCH_STATUS=0
	begin
		set @pwd=concat(right(@uid,2),format(@bd,'dd'))	
		update UserInfo set password = @pwd where uid=@uid
		fetch d_pwd into @uid,@bd
	end
	close d_pwd
end
