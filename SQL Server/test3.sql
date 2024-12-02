--找出每棟房子的電話費總和 列出住址 電話 人數 

select *
from(
select address as '地址',bill.tel as '電話',sum(fee) as '總和',live.uid
from bill,phone,house,live
where phone.tel = bill.tel
and bill.hid = house.hid
and live.hid=house.hid
group by address ,bill.tel,live.uid
) as x 
/*
select *
from(
select address as '地址',bill.tel as '電話',sum(fee) as n,live.hid as '人數'
from v
where phone.tel = bill.tel
and bill.hid = house.hid
and phone.hid=house.hid
and live.hid=house.hid
group by address,bill.tel,live.hid
)as x
*/


