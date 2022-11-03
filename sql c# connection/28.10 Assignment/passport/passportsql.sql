--Write a C# program to get a list of values from the user. 
--(Passport information: passport number, candidate name, passport expiry date, years of validity, applied through channel 
--(Normal, Priority),etc) for atleast 10 candidates. Create a table and upload
-- this information to the table using a Stored Procedure.

create table passport(
    passport_no int identity primary key,
	candidate_name nvarchar(40),
	passport_expiry_date date,
	years_of_validity int,
	channel nvarchar(15)
)

create or alter procedure passport_det @name nvarchar(40),@expydate date,@validity int,@channel nvarchar(15) as
insert into passport(candidate_name,passport_expiry_date,years_of_validity,channel) values(@name,@expydate,@validity,@channel)

select * from passport
drop table passport
