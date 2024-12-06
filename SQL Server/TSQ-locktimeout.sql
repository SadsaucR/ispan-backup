set lock_timeout 5000
	begin try
		select * from UserInfo
	end try
	begin catch

	end catch


--print @@lock_timeout
