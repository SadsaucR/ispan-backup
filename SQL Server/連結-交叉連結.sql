select* --��e�s�� �e���X�� ���s�u�n�ݲM��
from UserInfo,Live,house,phone
where userinfo.uid=live.uid 
and live.hid=house.hid
and house.hid=phone.hid