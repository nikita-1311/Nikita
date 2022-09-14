Create Database emp;
use emp
Create table Employee(emp_id int,first_name varchar(20),last_name varchar(20),salary int,department_id int)
Create table Department(id int,department_name varchar(10))
insert into Employee values(1,'Nikita','Bhujbal','18000','123')
insert into Employee values(2,'Sejal','Patil','18000','456')
insert into Employee values(3,'Roshan','Verma','18000','12')
insert into Employee values(4,'Nikita','Bhujbal','18000','123')
insert into Department values(123,'technical')
insert into Department values(456,'hr')
insert into Department values(4,'cs')
select * from Employee
select * from Department 
select e.emp_id,e.first_name,e.last_name,d.department_name from Employee e  inner join Department d on d.id=e.department_id
update Employee set department_id=4 where emp_id=3
select * from Employee 
select e.emp_id,e.first_name,e.last_name,d.department_name from Employee e LEFT OUTER join Department d on d.id=e.department_id
select e.emp_id,e.first_name,e.last_name,d.department_name from Employee e RIGHT OUTER join Department d on d.id=e.department_id
select e.emp_id,e.first_name,e.last_name,d.department_name from Employee e FULL OUTER join Department d on d.id=e.department_id

select * from Department where department_name like '%l' --it should end with I
select * from Department where department_name like 'h%' 
select * from Department where department_name like '%a%' 

select * from Department order by id
select * from Department order by id asc
select * from Department order by id desc

Create function GetFullName(@emp_id int) 
RETURNS varchar(200) as
BEGIN
 return (select CONCAT(first_name,' ',last_name) from Employee where emp_id=@emp_id);
END

select dbo.GetFullName(emp_id) as FULLNAME from Employee
update Employee set salary=19000 where emp_id=1
select Max(salary) from Employee
select MIN(salary) from Employee
select AVG(salary) from Employee 
select COUNT(*) from Employee 
select GETDATE()
select CONCAT(first_name,' ',last_name)FullName from Employee where salary=(select Max(salary) from Employee)
select CONCAT(first_name,' ',last_name)FullName from Employee where salary=(select MIN(salary) from Employee)
select * from Employee 
select MAX(salary) from Employee where salary < (select MAX(salary) from Employee);--2nd highest salary
select CONCAT(first_name,' ',last_name)FullName from Employee where salary < (select MAX(salary) from Employee)
select first_name from Employee group by first_name 
select first_name from Employee group by first_name having count(*)>1
select * from Employee where emp_id between 1 and 3
