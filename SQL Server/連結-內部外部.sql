select * --�s����ƨæC�X join�������s���P�~���s��
from UserInfo left join live --'join'�����s�� 'left/right outter(�i�ٲ�) join'�~���s��
		on Userinfo.uid=live.uid
	left join house
		on live.hid=house.hid
	left join phone
		on house.hid=phone.hid



/*from userinfo,live,house,phone --�q�|�Ӹ�ƪ��^��
where userinfo.uid=live.uid --��ƪ�ѷӱquserinfo�}�l 
	and live.hid =house.hid --��House���� live�@��������
	and house.hid=phone.hid
	and userinfo.uid ='A01' */