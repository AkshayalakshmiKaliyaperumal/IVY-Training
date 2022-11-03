--Write a simple stored procedure to get the total of a particular student 
--and call another stored procedure to list all the students with marks below than that student.
--Input: Student ID
--Output: Student Total (From first SP) Student2, Student3, etc (From Second SP)

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


create or alter procedure total_marks @id int as
begin
declare @total as int
select @total = sum(mark) from marks
group by student_id
having student_id = @id
return @total
end

exec total_marks 1

create or alter procedure total_marks1 @sum int as
begin
exec total_marks 1 
select student_id,sum(mark) as max_marks
from marks
group by student_id
having sum(mark) < @sum
end

exec total_marks1 @total