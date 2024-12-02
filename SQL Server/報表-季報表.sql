--季報表做成
select quar,sum(sum_fee) as sum_fee 
from(
select datepart(Quarter,dd)as quar , sum(fee) as sum_fee
from bill
where (datepart(year,dd)=2019)
group by datepart(quarter,dd)
--缺項補零，很重要'使用union all'
--原理:將多個查詢的結果合併，且保留所有結果。
union all
select 1,0
union all
select 2,0
union all
select 3,0
union all
select 4,0
)as tmp
group by quar




