select * --連結資料並列出 join分內部連結與外部連結
from UserInfo left join live --'join'內部連結 'left/right outter(可省略) join'外部連結
		on Userinfo.uid=live.uid
	left join house
		on live.hid=house.hid
	left join phone
		on house.hid=phone.hid



/*from userinfo,live,house,phone --從四個資料表擷取
where userinfo.uid=live.uid --資料表參照從userinfo開始 
	and live.hid =house.hid --到House結束 live作為中介表
	and house.hid=phone.hid
	and userinfo.uid ='A01' */