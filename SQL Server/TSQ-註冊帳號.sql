--建一個procedure，功能為register，須包含帳號 密碼 地址，地址由帳號對應
--有就直接抓屋號，沒有就新增屋號，連結到userinfo
drop procedure if exists register
go
create procedure register
	-------宣告
	@cname nvarchar(50),
	@uid nvarchar(50),
	@pwd nvarchar(50),
	@addr nvarchar(200)
as begin
	-------動作
	declare @error int =0
	select @error=count(*) from UserInfo where uid=@uid
	--報錯(error=1)--
	if @error=1
	begin
		select concat(@uid,'無法註冊:帳號已存在') as status
		select @cname as '名字',@uid as '帳號',@pwd as '密碼',@addr as '地址'	
		return
	end
	--執行--
	declare @maxhid int 
	set @maxhid = (
	select max(hid) as n from house
	)+1
	if @pwd is not null
	begin
		insert into UserInfo(uid,cname,password) values (@uid,@cname,@pwd)
		insert into House(address,hid) values (@addr,@maxhid)
		insert into Live(hid,uid) values (@maxhid,@uid)
		select concat(@cname,'的資料已更新') as status
		select @cname as '名字',@uid as '帳號',@pwd as '密碼',@addr as '地址'	
	end
	else
	begin
		insert into UserInfo(uid,cname,password) values (@uid,@cname,@uid)
		insert into House(address,hid) values (@addr,@maxhid)
		insert into Live(hid,uid) values (@maxhid,@uid)
		select concat(@cname,'的資料已更新') as status
		select @cname as '名字',@uid as '帳號',@pwd as '密碼',@addr as '地址'
	end
end