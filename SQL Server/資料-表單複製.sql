--���ƻs
--�s��椣�s�b��
--select * into new_table from UserInfo
--�s���s�b��
select * into new_table from UserInfo
	insert into new_table(uid,cname)
		select uid,cname from UserInfo
