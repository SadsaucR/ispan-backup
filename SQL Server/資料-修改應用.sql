--insert 插入資料
--updata 修改現有資料
--delete 刪除資料
-- delete from bill where uid='z01'
--drop table new_table 移除整個表單
insert into UserInfo values (
	'B01','David',NULL,NULL
)
update UserInfo set cname='孫小毛',uid='Z01'
where uid ='B01'
select *
from UserInfo
