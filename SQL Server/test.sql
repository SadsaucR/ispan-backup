select * --連結資料並列出 內部連結/外部連結
from info1 join info2 --join內部連結 left join外部連結
		on info1.uid=info2.uid
	join info3
		on info2.hid=info3.hid
