/* Write your T-SQL query statement below */
select name
From Employee
where Id in
( Select managerId from Employee
 group by managerId
 having count(*) > =5)