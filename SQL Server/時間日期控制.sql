--�ɶ��������
--�{�b�ɶ�
select getdate()
--�{�b�ɶ�����B��
select dateadd(year,-5,GETDATE())
--�{�b�ɶ��P2024/1/1�ۮt�X��
select datediff(day,'2024/1/1',getdate())
--�L�X�������
select datepart(hour,getdate())
--�ۭq�榡�A�ݰѷӰѼƪ�
select FORMAT(getdate(),'M��dd��')
--�ഫ����~�A���������~�A�A��concat�զX�r��
select concat(
	'���إ���',
	datepart(year,getdate())-1911,
	'�~',
	format(getdate(),'M��d��')
	)
--�ɶ�(�h����)
select DATETRUNC(month,GETDATE())

	