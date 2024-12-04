drop procedure if exists initpassword
go 
create procedure initpassword as
begin
	declare c cursor for select uid,birthday from userinfo where isdeleted is null and password is null
	declare @uid nvarchar(50)
	declare @birthday datetime2
	declare @pwd nvarchar(50)
	
	open c
	fetch c into @uid,@birthday
	while(@@fetch_status=0) 
	begin
		set @pwd=concat(right(@uid,2),format(@birthday,'dd'))
		update userinfo set password = @pwd where uid = @uid
		fetch c into @uid,@birthday
	end
	close c 
end