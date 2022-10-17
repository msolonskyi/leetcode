select distinct num as ConsecutiveNums
from (select num,
             case when lag(num, 1) over (order by id) = num and lag(num, 2) over (order by id) = num then 1 else 0 end l3
      from logs) i
where l3 = 1
