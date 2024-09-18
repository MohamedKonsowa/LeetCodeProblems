/* Write your T-SQL query statement below */
select s.user_id ,  ROUND(
    case 
        when count(c.user_id) = 0 then 0
        else
         1.0 * SUM(CASE WHEN c.action = 'confirmed' THEN 1 ELSE 0 END) / COUNT(c.user_id)
    end
    , 2) AS confirmation_rate
from Signups s
left outer join Confirmations c
on s.user_id = c.user_id
group by s.user_id