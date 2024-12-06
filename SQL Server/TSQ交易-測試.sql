set tran isolation level snapshot
begin tran
update product set quantity =40 where pid =1
--waitfor delay '0:0:10'
--rollback
commit