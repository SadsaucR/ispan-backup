--like '王%' 模糊搜尋含'王'字串
--select cname from UserInfo with(index(0)) where cname like '%王%'
--功能一樣的程式碼，效能差了超過100倍。
--用了索引，就像卡洛因，會上癮。

--select cname from UserInfo where cname like '王%'

--select cname from UserInfo where left(cname,1) ='王'

select cname from UserInfo where cname = '王大明' or cname ='李大媽'
select cname from UserInfo where cname in ('王大明','李大媽')