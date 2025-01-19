--preparation
CREATE TABLE employee (
    id INT PRIMARY KEY,
    name VARCHAR NOT NULL,
    salary INT NOT NULL,
    managerId INT
);
drop table employee;

INSERT INTO employee
VALUES
    (1, 'Joe', 70000, 3),
    (2, 'Henry', 80000, 4),
    (3, 'Sam', 60000, null),
    (4, 'Max', 90000, null)
;

select * from employee;

truncate table employee;

--solution
select e.name as "Employee"
from employee e
inner join employee m on e.managerid = m.id
where e.managerid is not null
and e.salary > m.salary
;