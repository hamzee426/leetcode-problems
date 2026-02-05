# Write your MySQL query statement below
SELECT class
FROM Courses as c
GROUP BY c.class
HAVING COUNT(c.student) >= 5;