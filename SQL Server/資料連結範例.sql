select*
from(
select a.tel as '�q��', sum(fee) as '�`�M', address as '��}'--���wsum�@�ӥN��
from bill as a, phone as b,house as c
where a.tel=b.tel 
and b.hid=c.hid 
group by a.tel , address --�[�`�B���A�s�զ����]�n�t�i�h       
)as X
where �`�M>1000