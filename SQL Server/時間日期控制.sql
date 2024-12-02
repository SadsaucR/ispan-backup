--時間日期控制
--現在時間
select getdate()
--現在時間日期運算
select dateadd(year,-5,GETDATE())
--現在時間與2024/1/1相差幾天
select datediff(day,'2024/1/1',getdate())
--印出部分日期
select datepart(hour,getdate())
--自訂格式，需參照參數表
select FORMAT(getdate(),'M月dd日')
--轉換民國年，先換算民國年，再用concat組合字串
select concat(
	'中華民國',
	datepart(year,getdate())-1911,
	'年',
	format(getdate(),'M月d日')
	)
--時間(去尾數)
select DATETRUNC(month,GETDATE())

	