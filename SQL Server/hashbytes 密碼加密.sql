--hashbytes �N���K�X'1234'�i��[�K��X
select*
from userinfo
select convert(varchar(200),hashbytes('sha2_512','1234'),2)