--preparation
CREATE TABLE IF NOT EXISTS Employee (
    id INT PRIMARY KEY,
    salary INT NOT NULL
);

INSERT INTO Employee VALUES
(1, 100)
,(2, 100)
,(3, 100)
,(4, 300)
,(5, 200)
,(6, 200)
;

truncate table employee;

--solution
with distinct_salary as (
    select distinct salary as salary
    from employee
),
ranked_salary as (
    select salary, row_number() over (order by salary desc) as r
    from distinct_salary
)
select rs.salary as "SecondHighestSalary"
from (select 2 as "no") tmp
left join ranked_salary rs on rs.r = 2
;

--solution2
with highest_salary as (
    select max(salary) as salary
    from employee
)
select max(salary) as "SecondHighestSalary"
from employee
where salary < (select salary from highest_salary)
;