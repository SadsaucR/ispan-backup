--�u������
select quar,sum(sum_fee) as sum_fee 
from(
select datepart(Quarter,dd)as quar , sum(fee) as sum_fee
from bill
where (datepart(year,dd)=2019)
group by datepart(quarter,dd)
--�ʶ��ɹs�A�ܭ��n'�ϥ�union all'
--��z:�N�h�Ӭd�ߪ����G�X�֡A�B�O�d�Ҧ����G�C
union all
select 1,0
union all
select 2,0
union all
select 3,0
union all
select 4,0
)as tmp
group by quar




