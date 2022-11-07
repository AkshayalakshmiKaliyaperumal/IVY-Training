
drop table sales_detail
create TABLE sales_detail 
(s_id INT identity PRIMARY KEY,
s_name varchar(20),
amount BIGINT,
city varchar(20),
phone_no bigint unique
)


SELECT * FROM sales_detail


create or alter procedure create_sales(@p_s_name varchar(max), @p_s_amount BigInt, @p_city varchar(max),@p_no bigint)
as
insert into sales_detail values(@p_s_name,@p_s_amount,@p_city,@p_no)
exec create_sales 'sanya',6000,'Delhi'

--delete from sales_detail


insert into sales_detail values ('mukesh',2000,'Delhi',7436829727)
insert into sales_detail values ('manish',4000,'Chennai',9443567890)
insert into sales_detail values ('anand',3000,'Bihar',69804453245)
insert into sales_detail values ('ankit',5000,'Hyderabad',99887653567)
insert into sales_detail values ('sanjana',6000,'Bangalore',8013345758)

--insert into sales_detail values ('nisha',1000,'Bihar')
--insert into sales_detail values ('poojitha',2000,'Bihar')
--insert into sales_detail values ('shilpa',3000,'Bihar')
--insert into sales_detail values ('kishor',4000,'Bihar')

--insert into sales_detail values ('raju',10000,'UP')
--insert into sales_detail values ('ram',20000,'UP')
--insert into sales_detail values ('rakesh',30000,'UP')
--insert into sales_detail values ('rani',40000,'UP')

--insert into sales_detail values ('ramu',200000,'UK')
--insert into sales_detail values ('radha',300000,'UK')
--insert into sales_detail values ('parnav',400000,'UK')
--insert into sales_detail values ('ramesh',50000,'UK')






create or alter procedure create_sale as
select s_name,amount,city from sales_detail where amount <=5000
EXEC create_sale