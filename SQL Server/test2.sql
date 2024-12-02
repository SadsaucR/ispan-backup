--Test 列出每棟房子的電話 及 居住人數 並將人數由大到小排列 沒住人的屋子不顯示
select address as '住址',tel as '電話',count(live.hid) as '人數' 
from 
(
house left join phone
on house.hid=phone.hid
left join live
on house.hid=live.hid
) 
group by address ,tel,live.hid
