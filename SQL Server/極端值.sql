select tel, sum(fee) as n from bill
group by tel              
--�W���o�q�{���C�X�F�Ҧ�bill.tel�C��A�å�n���fee�[�`--
select*
from (
	select tel, sum(fee) as n from bill
	group by tel 
)as x
where n=(
	select top 1 n
	from(
		select tel, sum(fee) as n from bill
		group by tel
	)as x
	order by n
	)