set transaction isolation level read committed
--�]�w�������:uncommitted����Ƥ]�iŪ��
--set transaction isolation level repeatable read
begin tran
	select 'r1',* from UserInfo where uid ='A06'
	waitfor delay '00:00:10'                                       
	select 'r2',* from UserInfo where uid ='A06'
	commit
	