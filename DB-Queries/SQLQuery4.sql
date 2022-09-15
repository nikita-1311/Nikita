create procedure CreateEmployee(@first_name varchar(50),@last_name varchar(50),@salary varchar(50),@department_id varchar(50))
As
BEGIN
DECLARE @emp_id int
set @emp_id =(select Max(emp_id) from employee);
Insert into employee values(@emp_id+1,@first_name,@last_name,@salary,@department_id)
END

select * from Employee
exec CreateEmployee 'Sejal','Vazare',18000,2
exec CreateEmployee 'Snehal','Bhujbal',18000,3