select Department, Employee, Salary
from (select d.name as Department, e.name as Employee, e.salary as Salary, dense_rank() over (partition by e.departmentid order by e.salary desc) as dense_rank
      from employee e, department d
      where d.id = e.departmentid) i
where dense_rank between 1 and 3