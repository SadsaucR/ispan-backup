--將bill表內重複的值列出來
select tel,count(*)
from bill 
group by tel
having count(*)>1