--��X�C�ɩФl���q�ܶO�`�M �C�X��} �q�� �H�� 

select *
from(
select address as '�a�}',bill.tel as '�q��',sum(fee) as '�`�M',live.uid
from bill,phone,house,live
where phone.tel = bill.tel
and bill.hid = house.hid
and live.hid=house.hid
group by address ,bill.tel,live.uid
) as x 
/*
select *
from(
select address as '�a�}',bill.tel as '�q��',sum(fee) as n,live.hid as '�H��'
from v
where phone.tel = bill.tel
and bill.hid = house.hid
and phone.hid=house.hid
and live.hid=house.hid
group by address,bill.tel,live.hid
)as x
*/


