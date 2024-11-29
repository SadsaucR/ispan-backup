--函數應用 將bill資料表內的tel列出並加總tel對應的fee資料'
select tel ,sum(fee) --sum加總 --max最大 --avg平均 --stdev標準差
from bill
group by tel --group by 群組