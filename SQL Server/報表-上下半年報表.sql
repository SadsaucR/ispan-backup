--上半年及下半年的金額總和
/*
select sum(fee) as '上半年'
from Bill
where datepart(month,dd)<6
	and datepart(year,dd)=2019
	
select sum(fee) as '下半年'
from Bill
where datepart(month,dd)>=6
	and datepart(year,dd)=2019
	*/
select hy ,sum(sf) as 總和
	from(
		select sum(fee) as sf ,floor(datepart(month,dd)/7.0) as hy
		from bill
		group by datepart(month,dd) , fee
	)as x
	group by hy