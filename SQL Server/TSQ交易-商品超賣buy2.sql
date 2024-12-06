drop procedure if exists buy2
go
create procedure buy2
as
begin
	declare @q int
	begin transaction
	update product set quantity =quantity -1 where pid =1
	select @q = quantity from product where pid = 1
	waitfor delay '00:00:10'
	if @q>=0
	begin
		commit
		select 'success' as status
	end
	else
	begin
		rollback
		select 'sold out' as status
	end
end