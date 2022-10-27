--1. Create an orders/ product /customer table with the following schema. 
--CUSTOMERS table:
--    cust_id
--    name
--    address
--    tel
--    email

create table customers(
    cust_id int primary key,
	name nvarchar(25),
	address nvarchar(50),
	tel_number bigint,
	email nvarchar(30)
)

insert into customers values(1,'Akshaya','Chennai,India',9784566345,'akshaya@gmail.com')
insert into customers values(2,'Akshita','Bangalore,India',9783566377,'akshita@gmail.com')
insert into customers values(3,'Priya','Chennai,India',7594561245,'priya@gmail.com')
insert into customers values(4,'Madhu','Hyderabad,India',9884339345,'madhu@gmail.com')
insert into customers values(5,'Gayathri','Chennai,India',6594346785,'gayathri@gmail.com')

select * from customers

--ITEMS table:
--    item_id
--    name
--    price

create table items(
    item_id int primary key,
	name nvarchar(30),
	price int
) 

insert into items values(1,'Kurti',450)
insert into items values(2,'Shoes',1000)
insert into items values(3,'Shirt',600)
insert into items values(4,'Tshirt',300)
insert into items values(5,'Pants',800)

select * from items


--ORDERS table:
--   order _id
--    customer_id
--    datetime

create table orders(
    order_id int primary key,
	customer_id int,
	date_time datetime,
	foreign key (customer_id) references customers(cust_id)
)


--YYYY-MM-DD hh:mm:ss
insert into orders values(1,2,'2022-07-21 12:20:33')
insert into orders values(2,3,'2022-07-23 15:44:10')
insert into orders values(3,5,'2022-08-01 18:24:29')
insert into orders values(4,4,'2022-08-11 08:05:02')
insert into orders values(5,2,'2022-09-15 05:55:43')


--ORDER_ITEM table:
--    ord_item_id
--    order_id
--    item_id
--    product_quantity"
--Decide and create relations between the tables. Create enough data in the tables as well. 

create table order_item(
    orderitem_id int primary key,
	order_id int,
	item_id int,
	product_quantity int,
	foreign key (item_id) references items(item_id),
	foreign key (order_id) references orders(order_id)
)

insert into order_item values(1,2,3,3)
insert into order_item values(2,4,1,2)
insert into order_item values(3,2,5,1)
insert into order_item values(4,1,4,5)
insert into order_item values(5,2,4,1)

select * from order_item

--"2. Create a student table which has information about Students, their marks, courses, etc. 
--Display on screen the maximum marks, each student has obtained in each course, order it by course. "

create table students(
    student_id int primary key,
    name nvarchar(25)
)

create table courses(
    course_id int primary key,
	course_name nvarchar(25)
)

create table marks(
    student_id int,
	course_id int,
	mark int,
	foreign key (student_id) references students(student_id),
	foreign key (course_id) references courses(course_id)
)

insert into students values(1,'Akshaya')
insert into students values(2,'Priya')
insert into students values(3,'Pooja')
insert into students values(4,'Gayathri')
insert into students values(5,'Lakshmi')

insert into courses values(1,'Maths')
insert into courses values(2,'Chemisty')
insert into courses values(3,'Physics')
insert into courses values(4,'English')
insert into courses values(5,'Biology')

insert into marks values(1,1,80)
insert into marks values(1,2,90)
insert into marks values(1,3,75)
insert into marks values(1,4,82)
insert into marks values(1,5,95)
insert into marks values(2,1,79)
insert into marks values(2,2,92)
insert into marks values(2,3,85)
insert into marks values(2,4,88)
insert into marks values(2,5,89)
insert into marks values(3,1,56)
insert into marks values(3,2,68)
insert into marks values(3,3,66)
insert into marks values(3,4,75)
insert into marks values(3,5,59)
insert into marks values(4,1,80)
insert into marks values(4,2,98)
insert into marks values(4,3,89)
insert into marks values(4,4,87)
insert into marks values(4,5,95)
insert into marks values(5,1,77)
insert into marks values(5,2,78)
insert into marks values(5,3,64)
insert into marks values(5,4,76)
insert into marks values(5,5,85)

select * from marks

select course_id,max(mark) as max_marks
from marks
group by course_id
order by course_id;

--"3. Create a telephone_directory table for atleast 20 citizens. It should have id, name, tel number, address, profession. 
--Query the table to check how many citizens are working professionals, students, etc. 

create table telephone_directory(
    id int primary key,
	name nvarchar(30),
	tel_number bigint unique,
	address nvarchar(30),
	profession nvarchar(25)
)

insert into telephone_directory values(1,'Akshaya',9784566345,'Chennai,India','Lawyer')
insert into telephone_directory values(2,'Akshita',9443564567,'Bangalore,India','Student')
insert into telephone_directory values(3,'Priya',7594561245,'Chennai,India','Teacher')
insert into telephone_directory values(4,'Madhu',9884339345,'Hyderabad,India','Doctor')
insert into telephone_directory values(5,'Gayathri',6594346785,'Chennai,India','Student')
insert into telephone_directory values(6,'Lakshmi',9783746645,'Chennai,India','Lawyer')
insert into telephone_directory values(7,'Akash',9443478867,'Bangalore,India','Student')
insert into telephone_directory values(8,'Dharshini',7334561245,'Chennai,India','Teacher')
insert into telephone_directory values(9,'Madhumita',9882239345,'Hyderabad,India','Doctor')
insert into telephone_directory values(10,'Prakash',2294346785,'Chennai,India','Student')
insert into telephone_directory values(11,'Rishi',9084566345,'Chennai,India','Lawyer')
insert into telephone_directory values(12,'Veera',9663564567,'Bangalore,India','Student')
insert into telephone_directory values(13,'Praveena',7594561233,'Chennai,India','Teacher')
insert into telephone_directory values(14,'Krishnan',9884339344,'Hyderabad,India','Doctor')
insert into telephone_directory values(15,'Karthik',6594346788,'Chennai,India','Student')
insert into telephone_directory values(16,'Pranav',9784566377,'Chennai,India','Lawyer')
insert into telephone_directory values(17,'Meera',9443564666,'Bangalore,India','Student')
insert into telephone_directory values(18,'Shafana',7594560005,'Chennai,India','Teacher')
insert into telephone_directory values(19,'Sundar',9800339345,'Hyderabad,India','Doctor')
insert into telephone_directory values(20,'Srinidhi',6594000785,'Chennai,India','Student')

select * from telephone_directory

select * from telephone_directory
where profession = 'Student'

select * from telephone_directory
where profession Not in ('Student')