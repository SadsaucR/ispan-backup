--userinfo �L�X��  �ư��S���m�W��
--substring()�Ω�q�r�Ŧꤤ�����l�r�Ŧ�
select distinct substring(cname,2,1) -- cname�q��2�r��1�r
from userinfo
where cname is not null and cname <> ''
--trim()�N�r���Y���h�ť�
--concat�N�h�Ӧr��šA�s���_�ӡA�L��Null��
select concat('[',trim('abc'),']')