select uid, cname --SQL�y�k�����j�p�g�Aselect�Ψ���ܥؼ����
from UserInfo --�qUserInfo table���^�����
--where cname='���j��' or cname='���j��' --*SQL��'��޸�'��ܦr��!!!!
--where cname is NULL -- �d��NULL�����
--where cname not in('���j��','���j��') or cname is null
--where cname<> '' and cname is not null
where isnull(cname,' ')<>'' --��줤���Ʈį�ܮt�A���n�o�ˤU���O
order by cname --��r�ƧǡA�̷ӵ����ƱƧ�
-----------------------------------------                 
select * --�ڬO������
from Bill /*�ڬO�h�����*/
--where fee>=400 and fee<=700  --where �j������<<<�Ω�d��ؼЩҦb��� <>��'������'
--where fee not between 400 and 700 --between ���w�d�� not��'�D'
order by fee desc ,tel --����fee���䦸�̷�tel '����'�Ƨ�