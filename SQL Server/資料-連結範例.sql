select*
from(
select a.tel as '�q��', sum(fee) as '�`�M', address as '��}'
from bill as a, phone as b,house as c --���w�C�Ӫ�@�ӥN���A��K�I�s
where a.tel=b.tel 
and b.hid=c.hid 
group by a.tel , address --�[�`�B���A�s�զ����]�n�t�i�h       
)as X
where �`�M>1000