select*
from bill
where dd between '2019/1/1' and '2019/3/31 23:59:59.999'

select getdate()+(3/24.0)

select*
from bill
--where datediff(day,dd,getdate()) <=5
where dd between getdate() -5 and getdate()