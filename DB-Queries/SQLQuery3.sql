Create Database Sample2;
use Sample2
Create table Student(roll int,sname varchar(20))
select * from Student
insert into Student values(1,'Nikita')
insert into Student values(2,'Snehal')
insert into Student values(3,'Sameer')
select * from Student 
select * from Student where roll=1
select roll,sname from Student 
select * from Student where roll in (1,2)
select * from Student where roll not in (1,2)
select * from Student where roll not in (3)
select * from Student where roll=1
delete from Student where roll=1
select * from Student 
