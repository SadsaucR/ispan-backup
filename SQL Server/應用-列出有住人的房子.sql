select count(*) as n  --此處為外層，將hid[1],hid[3]轉為兩行資料
from( 
--------------此區間為內層查詢，步驟如下，
select count(hid) as n --擷取live資料表底下的hid () 
from live     --從live.hid參照，有4筆資料>>hid[1,1,1,3]
group by hid　--將資料按hid分組　group後結果為兩組資料，hid[1],hid[3]有住人
---------------
)as x
-------------------------------
select count(*)-        --計算沒住人的房子
(select count(*) as n    --原理:count(*) from House 房子總數 >>4
from(						--減掉有住人的屋子>>2
select count(hid) as n			-- 4-2=2 即空屋數
from live
group by hid
)as x
)
from House      
------------------------------
select count(*) as '空屋' --從外部連結查詢沒有住人的房子
from house left join live  --live外部連入house
	on house.hid = live.hid 
where uid is null　--參照出hid[2],hid[4]無uid資料
