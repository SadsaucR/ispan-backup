--cursor 搭配 while 應用----
drop procedure if exists initpassword
go 
create procedure initpassword as 
--程式
begin
--宣告 cursor 提取userinfo中未被刪除且沒有密碼的用戶
	declare d_pwd cursor for select uid,birthday from userinfo 
	where isdeleted is null and password is null
	declare @uid nvarchar(50)
	declare @pwd nvarchar(50)
	declare @bd datetime2
--動作
	--將cursor提取的資料送進已宣告的變數
	open d_pwd
	fetch d_pwd into @uid,@bd
	/*
	while 迴圈 (@@fetch_status : cursor執行fetch所退回之值 0:成功 -1:結束 -2:失敗)

	動作:
	1.設定@pwd 為 @uid末兩碼+@bd中的day
	2.將@pwd送入資料表中對應的用戶(以uid判定)
	3.此處的fetch用來抓下一筆的資料，並結束迴圈。
	意思為:當cursor成功提取資料時，將提取的資料用來設定@pwd，並將值送入表，抓下一筆...LOOP。
	*/
	while @@FETCH_STATUS=0
	begin
		set @pwd=concat(right(@uid,2),format(@bd,'dd'))	
		update UserInfo set password = @pwd where uid=@uid
		fetch d_pwd into @uid,@bd
	end
	close d_pwd
end
