--preparation
CREATE TABLE Scores (
    id INT PRIMARY KEY,
    score NUMERIC(10, 2) NOT NULL
);

INSERT INTO Scores
VALUES
    (1, 95.50),
    (2, 87.25),
    (3, 100.00),
    (4, 72.89);

select * from scores;

truncate table scores;

--solution
select score, dense_rank() over (order by score desc) as rank
from scores;