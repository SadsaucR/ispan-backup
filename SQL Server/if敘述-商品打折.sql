--超過1000元的價格打9折
--case 如同 switch case語法:case when 條件1 then 動作1 否則1 end as 名稱
--也有if敘述，不過SSMS專用:iif(條件1,動作1,否則1) end as 名稱
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