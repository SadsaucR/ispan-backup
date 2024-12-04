delete from UserInfo where uid = 'A07'
delete from house where hid=5
select userinfo.uid,cname,address from UserInfo 
left join live
on userinfo.uid=live.uid
left join house
on live.hid=house.hid
select * from log