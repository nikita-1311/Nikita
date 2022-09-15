USE [Company]
GO
/****** Object:  StoredProcedure [dbo].[CreateDep]    Script Date: 09/15/2022 4:11:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[CreateDep](@department_name varchar(50))
As 
Begin
Declare @d_id int
set @d_id=(select Max(d_id) from Dep);
Insert into Dep values(@d_id+1,@department_name,CONCAT('Sejal',@department_name))
End