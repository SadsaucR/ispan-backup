select uid, cname --SQL語法不分大小寫，select用來顯示目標欄位
from UserInfo --從UserInfo table中擷取資料
--where cname='王大明' or cname='李大媽' --*SQL用'單引號'表示字串!!!!
--where cname is NULL -- 查找NULL值欄位
--where cname not in('王大明','李大媽') or cname is null
--where cname<> '' and cname is not null
where isnull(cname,' ')<>'' --欄位中放函數效能很差，不要這樣下指令
order by cname --文字排序，依照筆劃數排序
-----------------------------------------                 
select * --我是單行註解
from Bill /*我是多行註解*/
--where fee>=400 and fee<=700  --where 搜索條件<<<用於查找目標所在欄位 <>為'不等於'
--where fee not between 400 and 700 --between 指定範圍 not為'非'
order by fee desc ,tel --按照fee欄位其次依照tel '遞減'排序