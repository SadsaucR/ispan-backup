--trigger觸發條件(如果trigger存在)
drop trigger if exists userinfo_update_constrain
go
create trigger userinfo_update_constrain on userinfo for update
as 
--trigger動作
--declare 用來宣告變數
begin
	--declare @body nvarchar(50)
	--declare @n int
	--select @n = count(*)from deleted

	--@@rowcount 此處用來計算刪除的資料列數，update(password)為布林型態
	--rollback 撤銷操作
	print @@rowcount
	if @@ROWCOUNT >1 and update(password)
	begin
		print'不可修改一次兩筆以上資料'
		rollback
	end

--	select @body = concat(
--		'在Userinfo資料表中插入',@uid,',',@cname,'的資料'
--	)
	--insert into log (body) values (@body)
end