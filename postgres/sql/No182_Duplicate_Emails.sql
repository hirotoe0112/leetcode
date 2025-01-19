--preparation
CREATE TABLE person (
    id INT PRIMARY KEY,
    email VARCHAR NOT NULL
);
drop table person;

INSERT INTO person
VALUES
    (1, 'a@example.com'),
    (2, 'b@example.com'),
    (3, 'a@example.com'),
    (4, 'c@example.com')
;

select * from person;

truncate table person;

--solution1
select email
from person
group by email
having count(email) >= 2
;

--solution2
select distinct p1.email
from person p1
inner join person p2 on p1.id <> p2.id and p1.email = p2.email
;