--like '��%' �ҽk�j�M�t'��'�r��
--select cname from UserInfo with(index(0)) where cname like '%��%'
--�\��@�˪��{���X�A�į�t�F�W�L100���C
--�ΤF���ޡA�N���d���]�A�|�W�}�C

--select cname from UserInfo where cname like '��%'

--select cname from UserInfo where left(cname,1) ='��'

select cname from UserInfo where cname = '���j��' or cname ='���j��'
select cname from UserInfo where cname in ('���j��','���j��')