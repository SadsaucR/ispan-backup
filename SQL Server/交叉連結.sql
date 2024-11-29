select* --交叉連結 容易出錯 關連線要看清楚
from UserInfo,Live,house,phone
where userinfo.uid=live.uid 
and live.hid=house.hid
and house.hid=phone.hid