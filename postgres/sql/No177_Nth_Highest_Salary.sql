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

select * from employee;

select dense_rank() over (order by salary desc), salary from employee group by salary;

truncate table employee;

--solution
CREATE OR REPLACE FUNCTION NthHighestSalary(N INT) RETURNS TABLE (Salary INT) AS $$
BEGIN
  RETURN QUERY (
    -- Write your PostgreSQL query statement below.
    with distinct_salary as (
        select distinct e.salary as salary
        from employee e
    ),
    ranked_salary as (
        select ds.salary, row_number() over (order by ds.salary desc) as r
        from distinct_salary ds
    )
    select rs.salary
    from (select N as "no") tmp
    left join ranked_salary rs on rs.r = N
  );
END;
$$ LANGUAGE plpgsql;

--another solution
--dense_rank()で同率があっても数字を飛ばさない順位が取得できる
--普通のrank()だと同率がある場合はその次の順位は数字が飛ばされる
CREATE OR REPLACE FUNCTION NthHighestSalary(N INT) RETURNS TABLE (Salary INT) AS $$
BEGIN
  RETURN QUERY (
    -- Write your PostgreSQL query statement below.
    with ranked_salary as (
        select e.salary, dense_rank() over (order by e.salary desc) as r
        from employee e
    )
    select rs.salary
    from ranked_salary rs
    where rs.r = N
    limit 1
  );
END;
$$ LANGUAGE plpgsql;

select * from nthhighestsalary(4);