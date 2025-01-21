--preparation
CREATE TABLE Department (
    id INT PRIMARY KEY,
    name VARCHAR NOT NULL
);

CREATE TABLE Employee (
    id INT PRIMARY KEY,
    name VARCHAR NOT NULL,
    salary INT CHECK (salary > 0),
    departmentId INT,
    CONSTRAINT fk_department
        FOREIGN KEY (departmentId)
        REFERENCES Department (id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

drop table department;
drop table employee;

INSERT INTO department
VALUES
    (1, 'IT'),
    (2, 'Sales'),
    (3, 'Marketing'),
    (4, 'HR')
;

INSERT INTO employee VALUES
(1, 'Alice', 70, 1)
,(2, 'Bob', 60, 1)
,(3, 'Tom', 80, 2)
,(4, 'Cathy', 90, 3)
,(5, 'David', 100, 3)
,(6, 'Eva', 110, 4)
,(7, 'Dena', 110, 4)
,(8, 'Nina', 100, 4)

select * from department;
select * from employee;

truncate table department;
truncate table employee;

--solution1
with salary_rank as (
    select e.name as "Employee", d.name as "Department", salary, dense_rank() over (PARTITION BY d.name ORDER BY salary DESC) as s_rank
    from employee e
    inner join department d on e.departmentid = d.id
)
select "Department", "Employee", salary as "Salary"
from salary_rank
where s_rank <= 3;