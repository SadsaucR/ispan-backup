--�W�b�~�ΤU�b�~�����B�`�M
/*
select sum(fee) as '�W�b�~'
from Bill
where datepart(month,dd)<6
	and datepart(year,dd)=2019
	
select sum(fee) as '�U�b�~'
from Bill
where datepart(month,dd)>=6
	and datepart(year,dd)=2019
	*/
select hy ,sum(sf) as �`�M
	from(
		select sum(fee) as sf ,floor(datepart(month,dd)/7.0) as hy
		from bill
		group by datepart(month,dd) , fee
	)as x
	group by hy