select*
from(
select a.tel as '電話', sum(fee) as '總和', address as '住址'
from bill as a, phone as b,house as c --給定每個表一個代號，方便呼叫
where a.tel=b.tel 
and b.hid=c.hid 
group by a.tel , address --加總運算後，群組成員也要含進去       
)as X
where 總和>1000