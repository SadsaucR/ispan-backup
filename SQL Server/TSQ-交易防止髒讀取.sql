--repeatable read�@�H�Ĥ@��Ū�����Ȭ��D�A����żŪ���C
--�t�~�٦��@�ءASERIALIZABLE�A����Ū�g�A���Y�檺������šA���O�ʯ���t�C
set transaction isolation level repeatable read
begin transaction
    select 'r1', * from product where pid = 1
    waitfor delay '0:0:10'
	select 'r2', * from product where pid = 1
	commit

