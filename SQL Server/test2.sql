--Test �C�X�C�ɩФl���q�� �� �~��H�� �ñN�H�ƥѤj��p�ƦC �S��H���Τl�����
select address as '��}',tel as '�q��',count(live.hid) as '�H��' 
from 
(
house left join phone
on house.hid=phone.hid
left join live
on house.hid=live.hid
) 
group by address ,tel,live.hid
