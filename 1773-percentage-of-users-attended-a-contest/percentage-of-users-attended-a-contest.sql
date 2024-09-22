/* Write your T-SQL query statement below */

DECLARE @UsersCount INT;
SET @UsersCount = (SELECT COUNT(*) FROM Users);

select r.contest_id, ROUND((1.0 * COUNT(*) / @UsersCount) * 100, 2) AS percentage
FROM Register r
GROUP BY r.contest_id
order by percentage desc ,contest_id asc