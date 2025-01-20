--preparation
CREATE TABLE customers (
    id INT PRIMARY KEY,
    name VARCHAR NOT NULL
);
drop table customers;

INSERT INTO customers
VALUES
    (1, 'Bob'),
    (2, 'Alice'),
    (3, 'Tom'),
    (4, 'Cathy')
;

CREATE TABLE orders (
    id INT PRIMARY KEY,
    customerId INT NOT NULL,
    FOREIGN KEY (customerId) REFERENCES customers(id)
);

INSERT INTO orders VALUES
(1, 3)
,(2, 1);

select * from customers;
select * from orders;

truncate table customers;
truncate table orders;

--solution1
select name as "Customers" from customers
where id not in (select customerid from orders);

--solution2
select max(name) as "Customers" from customers c
left join orders o on c.id = o.customerid
where o.id is null
group by c.id;