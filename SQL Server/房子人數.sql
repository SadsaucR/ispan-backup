select count(*) as n  --���B���~�h�A�Nhid[1],hid[3]�ର�����
from( 
--------------���϶������h�d�ߡA�B�J�p�U�A
select count(hid) as n --�^��live��ƪ��U��hid () 
from live     --�qlive.hid�ѷӡA��4�����>>hid[1,1,1,3]
group by hid�@--�N��ƫ�hid���ա@group�ᵲ�G����ո�ơAhid[1],hid[3]����H
---------------
)as x
-------------------------------
select count(*)-        --�p��S��H���Фl
(select count(*) as n    --��z:count(*) from House �Фl�`�� >>4
from(						--�����H���Τl>>2
select count(hid) as n			-- 4-2=2 �Y�ūμ�
from live
group by hid
)as x
)
from House      
------------------------------
select count(*) as '�ū�' --�q�~���s���d�ߨS����H���Фl
from house left join live  --live�~���s�Jhouse
	on house.hid = live.hid 
where uid is null�@--�ѷӥXhid[2],hid[4]�Luid���
