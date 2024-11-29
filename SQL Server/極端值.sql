select tel, sum(fee) as n from bill
group by tel              
--上面這段程式列出了所有bill.tel列表，並用n表示fee加總--
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