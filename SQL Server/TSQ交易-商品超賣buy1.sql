drop procedure if exists buy1
go
create procedure buy1
as
begin
	declare @q int
	select @q = quantity from product where pid = 1
	waitfor delay '00:00:10'
	if @q>0
	begin
		update product set quantity = quantity -1 where pid =1
		select 'success' as status
	end
	else
	begin
		select 'sold out' as status
	end
end