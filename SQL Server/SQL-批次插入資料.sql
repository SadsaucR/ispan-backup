declare @n int = 100001
while @n<=1000000
begin
insert into test (A,B,C) values (20,20,20)
set @n=@n+1
end
