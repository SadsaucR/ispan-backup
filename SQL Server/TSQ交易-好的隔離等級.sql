--read uncommitted »P with nolock ¦P®Ä
set transaction isolation level READ COMMITTED
begin transaction
    select 'r1', * from product with(nolock) where pid = 1
    waitfor delay '0:0:10'
	select 'r2', * from product with(nolock) where pid = 1
    waitfor delay '0:0:10'
	select 'r3', * from product with(nolock) where pid = 1
	commit

