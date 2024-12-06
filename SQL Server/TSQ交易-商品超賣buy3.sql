drop procedure if exists buy3
go
create procedure buy3
as
begin
	declare @q int
	begin tran
		select @q = quantity from product with(xlock) where pid = 1
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
	
	commit
end