--�ؤ@��procedure�A�\�ରregister�A���]�t�b�� �K�X �a�}�A�a�}�ѱb������
--���N������θ��A�S���N�s�W�θ��A�s����userinfo
drop procedure if exists register
go
create procedure register
	-------�ŧi
	@cname nvarchar(50),
	@uid nvarchar(50),
	@pwd nvarchar(50),
	@addr nvarchar(200)
as begin
	-------�ʧ@
	declare @error int =0
	select @error=count(*) from UserInfo where uid=@uid
	--����(error=1)--
	if @error=1
	begin
		select concat(@uid,'�L�k���U:�b���w�s�b') as status
		select @cname as '�W�r',@uid as '�b��',@pwd as '�K�X',@addr as '�a�}'	
		return
	end
	--����--
	declare @maxhid int 
	set @maxhid = (
	select max(hid) as n from house
	)+1
	if @pwd is not null
	begin
		insert into UserInfo(uid,cname,password) values (@uid,@cname,@pwd)
		insert into House(address,hid) values (@addr,@maxhid)
		insert into Live(hid,uid) values (@maxhid,@uid)
		select concat(@cname,'����Ƥw��s') as status
		select @cname as '�W�r',@uid as '�b��',@pwd as '�K�X',@addr as '�a�}'	
	end
	else
	begin
		insert into UserInfo(uid,cname,password) values (@uid,@cname,@uid)
		insert into House(address,hid) values (@addr,@maxhid)
		insert into Live(hid,uid) values (@maxhid,@uid)
		select concat(@cname,'����Ƥw��s') as status
		select @cname as '�W�r',@uid as '�b��',@pwd as '�K�X',@addr as '�a�}'
	end
end