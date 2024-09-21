/* Write your T-SQL query statement below */
SELECT p.project_id , 1.0 * ROUND(1.0 * SUM(e.experience_years) / COUNT(*),2)  AS average_years 
FROM Project p
INNER JOIN Employee e
ON p.employee_id  = e.employee_id
GROUP BY p.project_id