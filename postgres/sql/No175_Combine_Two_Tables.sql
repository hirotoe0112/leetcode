--preparation
-- Creating the Person table
CREATE TABLE IF NOT EXISTS Person (
    personId INT PRIMARY KEY,
    lastName VARCHAR NOT NULL,
    firstName VARCHAR NOT NULL
);

-- Insert data into the Person table
INSERT INTO Person (personId, lastName, firstName) VALUES
(1, 'Wang', 'Allen'),
(2, 'Alice', 'Bob');

-- Creating the Address table
CREATE TABLE IF NOT EXISTS Address (
    addressId INT PRIMARY KEY,
    personId INT NOT NULL,
    city VARCHAR NOT NULL,
    state VARCHAR NOT NULL
);

-- Insert data into the Address table
INSERT INTO Address (addressId, personId, city, state) VALUES
(1, 2, 'New York City', 'New York'),
(2, 3, 'Leetcode', 'California');

--solution
select firstName, lastName, city, state
from person p
left join address a on  p.personId = a.personId
--order by p.personId
;