--Write a UDF to get the sales values of a particular region. Call another function within to 
--calculate the average sales of that region. Input: for example, Delhi
--Output: sales amt1, sales amt2, sales amt3, etc...... 
--(From first function) Output: Average sales in Delhi (from the second function)

CREATE TABLE sales(
    id int identity primary key,
    name varchar(20),
    amount int,
    city varchar(20)
)

insert into sales values('Akshaya',3000,'Chennai')
insert into sales values('Krishnan',5000,'Chennai')
insert into sales values('Priya',8000,'Bangalore')
insert into sales values('Akash',5000,'Hyderabad')
insert into sales values('Prakash',4000,'Hyderabad')

SELECT * FROM sales


create or alter function sales_location (@location nvarchar(20))
returns table as
return
select amount,city from sales group by city,amount having city = @location

select * from sales_location('Chennai')

create or alter function average(@loc varchar(20))
returns @location table (average int) as
begin
declare @res table (amount int,city varchar(20))
insert into @res select * from sales_location(@loc)
insert into @location select avg(amount) from @res
return 
end

select * from average('Chennai')