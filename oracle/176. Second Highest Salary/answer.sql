with cte as (select salary, dense_rank() over (order by salary desc) as dense_rank from employee)
select coalesce((select distinct salary from cte r where r.dense_rank = 2), null) as SecondHighestSalary
from dual
