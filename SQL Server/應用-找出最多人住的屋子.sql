--題目為:找出最多人住的房子 因此最後目標應為address
--先理好步驟再下手
--1.先把目標的表join起來
--2.把目標群組起來
--3.找出極端值(Max)
--4.將極端值return到house.address
--先知道執行步驟，才知道從何下手

--1.此處用到house,live資料表，因此先將他們join起來
--2.選擇house.address，live.hid為每棟屋子的人數，count函數傳回資料數(int)，之後才可以拿來做比較。

select house.address ,count(live.hid) as n
	from house left join live
	on house.hid=live.hid
	group by address , live.hid
--上段程式列出地址以及每棟房子的人數。
--3.找出極端值，使用max()函數
select*
from(
select house.address ,count(live.hid) as n
	from house left join live
	on house.hid=live.hid
	group by address , live.hid
	) as x
where n=(
	select max(n)
	from(
	select house.address ,count(live.hid) as n
	from house left join live
	on house.hid=live.hid
	group by address , live.hid
	)as y
	)
--4.將最大值資料只select address的部分
select address
from(
select house.address,count(live.hid) as n
from house left join live
on house.hid = live.hid
group by house.address ,live.hid
) as x	
where n=(
	select max(n)
	from(
	select house.address ,count(live.hid) as n
	from house left join live
	on house.hid = live.hid
	group by house.address ,live.hid
	) as x
	)
	




	