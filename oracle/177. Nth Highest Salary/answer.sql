CREATE FUNCTION getNthHighestSalary(N IN NUMBER) RETURN NUMBER IS
result NUMBER;
BEGIN
    /* Write your PL/SQL query statement below */
    with cte as (select salary, dense_rank() over (order by salary desc) as dense_rank from employee)
    select coalesce((select distinct salary from cte r where r.dense_rank = N), null) as SecondHighestSalary
    into result
    from dual;
    RETURN result;
END;
