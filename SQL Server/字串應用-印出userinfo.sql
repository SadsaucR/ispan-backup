--userinfo 印出來  排除沒有姓名的
--substring()用於從字符串中提取子字符串
select distinct substring(cname,2,1) -- cname從第2字取1字
from userinfo
where cname is not null and cname <> ''
--trim()將字串頭尾去空白
--concat將多個字串符，連接起來，無視Null值
select concat('[',trim('abc'),']')