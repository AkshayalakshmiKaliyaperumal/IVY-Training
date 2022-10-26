--Write a sql query to fetch the unique cities the employees of an organization belong to.

create table employee(
     emp_id int primary key,
     emp_name nvarchar(30),
	 city nvarchar(20)
)
drop table employee

insert into employee values(1,'Akshaya','Chennai')
insert into employee values(2,'Poojitha','Hyderabad')
insert into employee values(3,'Madhu','Chennai')
insert into employee values(4,'Varsha','Bangalore')
insert into employee values(5,'Priya','Pune')
insert into employee values(6,'Ram','Hyderabad')
insert into employee values(7,'Akash','Hyderabad')
insert into employee values(8,'Raj','Chennai')
insert into employee values(9,'Lakshmi','Bangalore')
insert into employee values(10,'Praveen','Chennai')

select * from employee

select distinct city from employee


--Create a cricket player table where the country name and the person name are together the primary key

create table cricket_player(
    player_id int ,
    person_name nvarchar(30) not null,
	country_name nvarchar(20) not null
)
drop table cricket_player
select * from cricket_player

alter table cricket_player add constraint pk_cricket primary key(person_name, country_name)

--Write a sql query to display all the students who have joined the Physics course after the month of July.

create table student(
   student_id int primary key,
   student_name nvarchar(25),
   course_name nvarchar(15),
   doj date
)
 drop table student

insert into student values (1,'Raj', 'Physics' , '8/22/2022')
insert into student values (2, 'Rahul', 'Chemistry', '2/2/2022')
insert into student values (3,'Amal', 'Maths', '11/11/2022')
insert into student values (4,'Sheetal', 'Biology', '11/11/2022')
insert into student values (5,'Priya', 'Physics', '8/8/2022')
insert into student values (6,'Amol', 'Physics', '10/7/2022')
insert into student values (7,'Geetha', 'Physics', '7/8/2022')
insert into student values (10,'Bino', 'Maths','10/5/2022')
insert into student values (12,'Fatima', 'Chemistry','10/9/2022')

select student_name from student 
where course_name = 'Physics'
and MONTH(doj) > 7


--Create 2 similar tables (Students in 2 colleges) and show only the students who are aged over 21 and are studying Mathematics

create table clg1(
   student_id int primary key,
   student_name nvarchar(25),
   age int,
   course_name nvarchar(15)
)
drop table clg1

insert into clg1 values(1,'Raji',22, 'Mathematics')
insert into clg1 values(2, 'Rahul', 20 , 'Chemistry')
insert into clg1 values(3,'Amal', 25, 'Mathematics')
insert into clg1 values(4,'Sheetal', 19, 'Biology')
insert into clg1 values(5,'Priya', 18, 'Mathematics')
insert into clg1 values(6,'Amol', 25, 'Physics')
insert into clg1 values(7,'Geetha',22, 'Physics')
insert into clg1 values(8,'Bino', 23,'Mathematics')
insert into clg1 values(9,'Bino', 20 ,'Physics')
insert into clg1 values(10,'Bino',20, 'Biology')

create table clg2(
   student_id int primary key,
   student_name nvarchar(25),
   age int,
   course_name nvarchar(15)
)
 
 drop table clg2

insert into clg2 values(1,'Raji',22, 'Mathematics')
insert into clg2 values(2, 'Ragu', 20 , 'Chemistry')
insert into clg2 values(3,'Amal', 25, 'Maths')
insert into clg2 values(4,'Sheetal', 19, 'Biology')
insert into clg2 values(5,'Priya', 18, 'Physics')
insert into clg2 values(6,'Amaal', 25, 'Mathematics')
insert into clg2 values(7,'Geetha',22, 'Physics')
insert into clg2 values(8,'Ram', 23,'Mathematics')
insert into clg2 values(9,'Sita', 20 ,'Physics')
insert into clg2 values(10,'Krishan',20, 'Mathematics')

select student_name,age,course_name from clg1 
where age > 21
and course_name = 'Mathematics'
union
select student_name,age,course_name from clg2
where age > 21
and course_name = 'Mathematics'

select student_name,age,course_name from clg1 
where age > 21
and course_name = 'Mathematics'
intersect
select student_name,age,course_name from clg2
where age > 21
and course_name = 'Mathematics'