select* --完全連結=左側外部+右側外部 較不常用
from userinfo full join live
		on userinfo.uid=live.uid