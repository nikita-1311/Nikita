create Database Company2;
use Company
CREATE TABLE [dbo].[Employeemaster](  
	
    [UserId] [int] IDENTITY(1,1) NOT NULL,  
	
    [UserName] [varchar](50) NOT NULL,  
	
    [LoginName] [varchar](50) NULL,  
	
    [Password] [varchar](50) NOT NULL,  
	
    [Email] [varchar](50) NULL,  
	
    [ContactNo] [varchar](15) NULL,  
	
    [Address] [varchar](50) NULL,  
	
    [IsApporved] [int] NULL,  
	
    [Status] [int] NULL,  
	
    [TotalCnt] [int] NULL,)

	select * from Employeemaster
	CREATE PROCEDURE [dbo].[LoginForm]
	@username varchar(50)='',@password varchar(50)='' 
	AS BEGIN
	Declare @userid int=0,@TotalCnt int=0
	SELECT @userid=UserId, @TotalCnt =TotalCnt from Employeemaster 
	where LoginName=@UserName and password=@Password and Status>3 and IsApporved=1
	if(@TotalCnt>=5)
	Begin
	select 0 UserId,'' UserName,'' LoginName,'' Password,'' Email,'' ContactNo,   
	
    ''Address,0 IsApporved,-1 Status  
	
    end  
	
    if(@UserId>0)  
	
    begin  
	
        select UserId, UserName, LoginName, Password, Email, ContactNo,   
	
        Address, IsApporved, Status from  Employeemaster um   
	
        where UserId=@UserId
		end
		 else  
	
    begin  
	
       Update Employeemaster set @TotalCnt=TotalCnt+1    
	
       where LoginName=@UserName and Status=1 and IsApporved=1  
	
       select 0 UserId,'' UserName,'' LoginName,'' Password,'' Email,'' ContactNo,   
	
    ''Address,0 IsApporved,0 Status  
	
    end  
	
    end