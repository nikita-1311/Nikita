Create Database emp;
use emp
Create table Employee(emp_id int,first_name varchar(10),last_name varchar(10),salary int,department_id int)
Create table Department(id int,department_name varchar(10))
insert into Employee values(1,'Nikita','Bhujbal','18000','123')
insert into Employee values(2,'Sejal','Patil','18000','456')
insert into Employee values(3,'Roshan','Verma','18000','12')
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


