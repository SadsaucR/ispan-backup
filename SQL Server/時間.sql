select datepart(year,getdate())

--epoch time(int���A,���a�ɰ�)
--unix time
--timestamp
select datediff(second,'1970/1/1 0:0:0',GETUTCDATE())

select dateadd(second, 1733127355,'1970/1/1 0:0:0')+8/24.0