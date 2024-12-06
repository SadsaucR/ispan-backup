drop procedure if exists login
go
create procedure login
	@uid nvarchar(50),
	@pwd nvarchar(50)

as begin
	declare @isok tinyint=0
	select @isok = count(*) from userinfo where uid = @uid and password =@pwd
	select @isok as 'status' 

end