--用了索引，就像卡洛因，會上癮。
select * from test  
where a=20 and c=20 and b=20


select b,c from test
where 
--a=20 
--and 
b=20 
and c=20
/*
a(+) b(-) c(+)
a(+) b(-)
a(+) 
a(-) b(+) c(-)
a(-) b(+) 
a(-) 
*/
