--preparation
CREATE TABLE Logs (
    id INT PRIMARY KEY,
    num VARCHAR NOT NULL
);

INSERT INTO Logs
VALUES
    (1, '1'),
    (2, '1'),
    (3, '2'),
    (4, '1'),
    (5, '1'),
    (6, '1');

select * from logs;

truncate table logs;

--solution
select distinct num as "ConsecutiveNums"
FROM
(
select
    num,
    CASE WHEN lag(num, 1) over (order by id) = num AND lag(num, 2) over (order by id) = num THEN 'true' ELSE 'false' END as con
from logs
)
where con = 'true'
;

--solution2
select distinct num as "ConsecutiveNums"
from
(
    select num, lag(num,1) over (order by id) as num1, lag(num,2) over (order by id) as num2
    from logs
)
where num1=num and num2=num
;