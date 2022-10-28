--Create a Stored Procedure to show only the Employees working on C# in the base location of Bangalore.
--Display the result set with Employee ID, Name, Working Language and Base Location.

select * from employee

create or alter procedure sp_1  as
SELECT * From employee where  city = 'Bangalore'
and proj_language = 'c#'
exec sp_1

--Create a Stored Procedure to calculate total marks and display ranks of students accordingly. 
--Have atleast 10 students in the result set.
--Total marks should include marks from Maths, Economics, Commerce, English and Computer Science.

select * from students
alter table students add Maths int, Economics int, Commerce int, English int, Computer int
update students 
set Maths = 83, Economics = 81, Commerce = 85, English = 78, Computer = 89 
where student_id =4


create or alter procedure total_mark
as
declare @total table(Name nvarchar(30), Total int)
insert into @total select name, Maths+Economics+Commerce+English+Computer from students
select *,DENSE_RANK() over(order by Total desc) "Ranks" from @total

exec total_mark

--Display students information (Name, Age, Sex, Course, Year of Study, etc). 
--Give the Year of study as an input parameter and display only those students 
--(If the input is 1, only show first year students.)
--Use Stored Procedure for:
--Creating a table with all the information,
--Displaying all the information,
--Showing the year of study students according to the input parameter.

select * from student
alter table student add year int, age int, sex varchar(10)
update student 
set year = 3 ,age = 20, sex = 'Female' 
where student_id = 5

create or alter procedure stud_year @year int
as
select * from student where year = @year

exec stud_year 1

--Create a user defined function where you can calculate interest on a savings account with the formula pnr/100. 
--If it is a checking account, calculate the interest as 5% on principal amount.

create table bank(
    acc_no int identity primary key,
	principal_amt int,
	no_of_years int,
	interest_rate int
)

insert into bank values(10000,3,5)
insert into bank values(12000,5,5)
insert into bank values(20000,7,5)
insert into bank values(30000,8,5)
insert into bank values(25000,9,5)

select * from bank

create or alter function interest()
returns @res table(acc_no int,Interest_amt int) as
begin
insert into @res select acc_no, (principal_amt*no_of_years*Interest_rate/100) from bank
return
end

select * from interest()
--Create a table that has time from various time zones (US, UK, Dubai, Singapore, etc) 
--Create a UDF where you set the alarm clock to 5 am if the time zone is Dubai, 
--6 am if it is UK and 7 am if it is any other time zone.