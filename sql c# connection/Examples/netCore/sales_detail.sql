drop table sales_detail
create TABLE sales_detail 
(s_id INT identity PRIMARY KEY,
s_name varchar(20),
amount BIGINT,
city varchar(20),
email_id varchar(255) 
unique(email_id)
)
--delete from sales_detail


insert into sales_detail values ('mukesh',2000,'Delhi','muke@gmail.com')
insert into sales_detail values ('manish',4000,'Delhi','manish@gmail.com')
insert into sales_detail values ('anand',3000,'Delhi','anand@gmail.com')
insert into sales_detail values ('ankit',5000,'Delhi','ankit@gmail.com')
insert into sales_detail values ('sanjana',6000,'Delhi','sanjana@gmail.com')

insert into sales_detail values ('nisha',1000,'Bihar','nisha@gmail.com')
insert into sales_detail values ('poojitha',2000,'Bihar','pooja@gmail.com')
insert into sales_detail values ('shilpa',3000,'Bihar','shilpa@gmail.com')
insert into sales_detail values ('kishor',4000,'Bihar','kishor@gmail.com')



SELECT * FROM sales_detail


create or alter procedure create_sales(@p_s_name varchar(max), @p_s_amount BigInt, @p_city varchar(max),@p_email varchar(max))
as
insert into sales_detail values(@p_s_name,@p_s_amount,@p_city,@p_email)
exec create_sales 'Raju',6000,'Delhi','Raju@gmail.com'

create or alter procedure update_sales(@p_s_id int,@p_s_name varchar(max), @p_s_amount BigInt, @p_city varchar(max))
as
update sales_detail set s_name=@p_s_name,amount=@p_s_amount,city=@p_city where s_id=@p_s_id
select * from sales_detail 
exec update_sales 5,'Raj',6987,'Patna' 


create or alter procedure create_sale as
select s_name,amount,city,email_id from sales_detail where amount <=5000
EXEC create_sale