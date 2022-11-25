create database netcore
use netcore

select * from __EFMigrationsHistory
select * from departments
select * from employees

create or alter procedure emp_dept(@dept_id int)
as 
Select * from employees where Department_id = @dept_id

exec emp_dept 2