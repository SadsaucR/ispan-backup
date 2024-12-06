--repeatable read　以第一次讀取的值為主，防止髒讀取。
--另外還有一種，SERIALIZABLE，限制讀寫，更嚴格的交易等級，但是性能較差。
set transaction isolation level repeatable read
begin transaction
    select 'r1', * from product where pid = 1
    waitfor delay '0:0:10'
	select 'r2', * from product where pid = 1
	commit

