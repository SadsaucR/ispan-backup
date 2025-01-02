select * from Products
where CategoryID=1 or CategoryID=4 or CategoryID=8
order by CategoryID,ProductName

--兩種方式做篩選

select * from Products
where CategoryID in (1,4,8)
order by CategoryID,ProductName