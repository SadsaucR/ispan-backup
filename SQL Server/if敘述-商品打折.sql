--�W�L1000�������楴9��
--case �p�P switch case�y�k:case when ����1 then �ʧ@1 �_�h1 end as �W��
--�]��if�ԭz�A���LSSMS�M��:iif(����1,�ʧ@1,�_�h1) end as �W��
select tel,sum(fee) as price
from bill
group by tel
------------------------
select tel,price,
iif(price>1500,price*0.9,price) as discount,
case
		when price>1000 then price*0.9
		else price
	end as discount
from(
	select tel,sum(fee) as price
	from bill
	group by tel
	)as x