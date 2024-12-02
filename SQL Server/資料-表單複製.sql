--表單複製
--新表單不存在時
--select * into new_table from UserInfo
--新表單存在時
select * into new_table from UserInfo
	insert into new_table(uid,cname)
		select uid,cname from UserInfo
