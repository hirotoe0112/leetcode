--Preparation
CREATE TABLE IF NOT EXISTS "Students" (
    student_id integer PRIMARY KEY,
    student_name varchar
);

--ALTER TABLE "Students" ADD PRIMARY KEY (student_id);

INSERT INTO "Students" VALUES
(1, 'Alice')
,(2, 'Bob')
,(13, 'John')
,(6, 'Alex');

CREATE TABLE IF NOT EXISTS "Subjects" (
    subject_name varchar PRIMARY KEY
);

--ALTER TABLE "Subjects" ADD PRIMARY KEY (subject_name);

INSERT INTO "Subjects" VALUES
('Math')
,('Physics')
,('Programming');

CREATE TABLE IF NOT EXISTS "Examinations" (
    student_id integer,
    subject_name varchar
);

INSERT INTO "Examinations" (student_id, subject_name) VALUES
(1, 'Math')
,(1, 'Physics')
,(1, 'Programming')
,(2, 'Programming')
,(1, 'Physics')
,(1, 'Math')
,(13, 'Math')
,(13, 'Programming')
,(13, 'Physics')
,(2, 'Math')
,(1, 'Math');

--Solution
select stu.student_id, stu.student_name, sub.subject_name, COALESCE(attended_exams, 0) as attended_exams
from "Students" stu
cross join "Subjects" sub
left join
(
    select student_id, subject_name, count(*) as attended_exams
    from "Examinations"
    group by student_id, subject_name
) exam on stu.student_id = exam.student_id and sub.subject_name = exam.subject_name
order by stu.student_id, sub.subject_name

--Solution2
select stu.student_id, stu.student_name, sub.subject_name, count(exam.student_id) as attended_exams
from "Students" stu
cross join "Subjects" sub
left join "Examinations" exam ON
stu.student_id = exam.student_id and sub.subject_name = exam.subject_name
group by stu.student_id, stu.student_name, sub.subject_name
order by stu.student_id, sub.subject_name