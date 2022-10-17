select Department, Employee, Salary
from (select d.name as Department, e.name as Employee, e.salary as Salary, max(e.salary) over (partition by d.name) as max_salary
      from employee e, department d
      where d.id = e.departmentid(+)) i
where Salary = max_salary
