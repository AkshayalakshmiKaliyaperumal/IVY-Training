create database library
use library

create table logindetails(
    id_no int identity(1000,1) primary key,
	name varchar(30),
	username varchar(20),
	password varchar(20),
	age int,
	phone_number bigint,
	email_id varchar(30)
)
create table books(
	book_id int identity(100,1) primary key,
	book_name varchar(100),
	author_name varchar(30),
	release_date date,
	quantity int,
	rent_price float
)
create table borrow_details(
	borrow_id int identity primary key,
	member_id int,
	book_id int,
	book_name varchar(100),
	borrow_date_from date,
	borrow_date_to date,
	foreign key (member_id) references logindetails(id_no),
	foreign key (book_id) references books(book_id)
)

create table fees(
	Borrow_id int,
	Rent_due float,
	Penalty_price float
	foreign key (borrow_id) references borrow_details(borrow_id)
)

select * from logindetails
select * from books