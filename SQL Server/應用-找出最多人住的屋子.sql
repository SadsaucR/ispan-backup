--�D�ج�:��X�̦h�H���Фl �]���̫�ؼ�����address
--���z�n�B�J�A�U��
--1.����ؼЪ���join�_��
--2.��ؼиs�հ_��
--3.��X���ݭ�(Max)
--4.�N���ݭ�return��house.address
--�����D����B�J�A�~���D�q��U��

--1.���B�Ψ�house,live��ƪ�A�]�����N�L��join�_��
--2.���house.address�Alive.hid���C�ɫΤl���H�ơAcount��ƶǦ^��Ƽ�(int)�A����~�i�H���Ӱ�����C

select house.address ,count(live.hid) as n
	from house left join live
	on house.hid=live.hid
	group by address , live.hid
--�W�q�{���C�X�a�}�H�ΨC�ɩФl���H�ơC
--3.��X���ݭȡA�ϥ�max()���
select*
from(
select house.address ,count(live.hid) as n
	from house left join live
	on house.hid=live.hid
	group by address , live.hid
	) as x
where n=(
	select max(n)
	from(
	select house.address ,count(live.hid) as n
	from house left join live
	on house.hid=live.hid
	group by address , live.hid
	)as y
	)
--4.�N�̤j�ȸ�ƥuselect address������
select address
from(
select house.address,count(live.hid) as n
from house left join live
on house.hid = live.hid
group by house.address ,live.hid
) as x	
where n=(
	select max(n)
	from(
	select house.address ,count(live.hid) as n
	from house left join live
	on house.hid = live.hid
	group by house.address ,live.hid
	) as x
	)
	




	