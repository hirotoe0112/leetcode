--preparation
CREATE TABLE Person (
    id INT PRIMARY KEY,
    email VARCHAR NOT NULL
);

drop table person;

INSERT INTO person VALUES
(1, 'a@example.com')
,(2, 'b@example.com')
,(3, 'c@example.com')
,(4, 'b@example.com')

truncate table person;

select * from person;

--solution
delete from person
where id in (
    with tmp as (select id, email, ROW_NUMBER() over (PARTITION BY email ORDER BY id) as r
    from person
    )select id from tmp where r <> 1
);

--solution2
delete from person
where id not in (
    select min(id) from person group by email
);