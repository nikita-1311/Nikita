USE [Company]
GO
/****** Object:  StoredProcedure [dbo].[CreateEmp]    Script Date: 09/15/2022 3:52:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[CreateEmp](@FirstName varchar(50),@LastName varchar(50),@salary varchar(50),@dept_id varchar(50))
As 
Begin
Declare @eid int
set @eid=(select Max(e_id) from Emp);
Insert into Emp values(@eid+1,@FirstName,@LastName,@Salary,@dept_id,CONCAT('Emp',@eid+1))
End