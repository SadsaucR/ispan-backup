--�Nbill�����ƪ��ȦC�X��
select tel,count(*)
from bill 
group by tel
having count(*)>1