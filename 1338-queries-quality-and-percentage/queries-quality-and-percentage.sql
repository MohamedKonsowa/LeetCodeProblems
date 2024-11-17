/* Write your T-SQL query statement below */
select query_name,
Round(sum(1.0*rating/position)/Count(*),2) as quality ,
Round(sum(CASE WHEN rating < 3 THEN 1 ELSE 0 END )*100.0 /Count(*) ,2)as poor_query_percentage 

from Queries 
group by query_name
having query_name is not null