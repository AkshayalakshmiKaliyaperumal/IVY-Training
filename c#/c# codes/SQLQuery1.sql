create database project
use project
drop table logindetails
drop table books

create table logindetails(
    id_no int identity(1000,1) primary key,
	name varchar(40),
	phone_number bigint,
	age int,
	email_id varchar(40) unique,
	password varchar(30)
)

insert into logindetails values('Akshaya',7889056433,21,'akshaya@gmail.com','Akshu@2222')

create table books(
	book_id int identity(100,1) primary key,
	book_name varchar(100),
	author_name varchar(30),
	genre varchar(25),
	release_date date,
	quantity int,
	rent_price decimal
)

insert into books values('Pride and Prejudice','Jane Austen','Historical Romance','1/28/1813',5,100)

create table borrow_details(
	borrow_id int identity primary key,
	book_id int,
	book_name varchar(100),
	rent_price decimal,
	name varchar(40),
	email_id varchar(40),
    borrow_date_from date,
	borrow_date_to date,
)

select * from books
select * from logindetails
select * from borrow_details


delete from borrow_details
where borrow_id = 7

delete from logindetails where id_no = 1004

create or alter procedure Login_details @email_id nvarchar(40)
as
select password from logindetails where email_id = @email_id

exec Login_details 'akshaya@gmail.com'

create or alter procedure Register @name varchar(40),@phone_number bigint,@age int,@email_id varchar(35),@password varchar(20)
as
insert into logindetails values(@name,@phone_number,@age,@email_id,@password)

exec Register 'Priya',7889336433,22,'priya@gmail.com','priya'

create or alter procedure search @search varchar(25)
as
select * from books
where genre = @search

exec search 'Thriller'

create or alter procedure addbooks @bookname varchar(100),@authorname varchar(40),@genre varchar(25),@releasedate date,@quantity int,@rentprice decimal
as
insert into books values(@bookname,@authorname,@genre,@releasedate,@quantity,@rentprice)

exec addbooks 'Two States','Chetan Bhagat','Romance','10/8/2009',3,80.50


create or alter procedure update_books @bookid int, @quantity int,@rentprice decimal
as
update books
set quantity=@quantity, rent_price=@rentprice
where book_id=@bookid

exec update_books 103,2,95

create or alter procedure delete_books @bookid int
as
delete from books where book_id=@bookid

exec delete_books 103

create or alter procedure bookslist
as
select * from books

exec bookslist

select * from borrow_details

create or alter procedure borrowdetails @book_id int,@book_name varchar(100),@rent_price decimal,@name varchar(40),@email_id varchar(40),@borrow_date_from date,@borrow_date_to date
as
insert into borrow_details values(@book_id,@book_name,@rent_price,@name,@email_id,@borrow_date_from,@borrow_date_to)

exec borrowdetails 101,'Two States',80.50,'Asha','asha@gmail.com','2022-11-19','2022-12-10'

create or alter procedure borrowrecords
as
select * from borrow_details

exec borrowrecords

select * from books

create or alter procedure quantityupdate @bookname varchar(100)
as
update books
set quantity = quantity-1
where book_name = @bookname
and quantity > 0;

exec quantityupdate 'Pride and Prejudice'

