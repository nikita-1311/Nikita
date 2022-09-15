create database Company;
use Company
create table Emp(e_id int,FirstName varchar(50),LastName varchar(50),salary int,dept_id int)
create table Dep(d_id int,dname varchar(50))
insert into Emp values(1,'Nikita','Bhujbal','18000','12')
insert into Emp values(2,'Snehal','Bhujbal','18000','22')
insert into Dep values(12,'CS')
insert into Dep values(22,'HR')
select * from Emp 
select * from Dep 

create procedure CreateEmp(@FirstName varchar(50),@LastName varchar(50),@salary varchar(50),@dept_id varchar(50))
As 
Begin
Declare @eid int
set @eid=(select Max(e_id) from Emp);
Insert into Emp values(@eid+1,@FirstName,@LastName,@Salary,@dept_id,'')
End
exec CreateEmp 'Sejal','Vazare',18000,20
select * from Emp

create procedure CreateDep(@department_name varchar(50))
As 
Begin
Declare @d_id int
set @d_id=(select Max(d_id) from Dep);
Insert into Dep values(@d_id+1,@department_name,'')
End
exec CreateDep 'CS'
exec CreateDep 'HR'
select * from Dep 