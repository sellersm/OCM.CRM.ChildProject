
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTPERFORMANCECODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Good', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Poor', 1,20,@ID,@ID,GETDATE(),GETDATE())
			
--delete dbo.USR_CHILDPROJECTPERFORMANCECODE			
select * from dbo.USR_CHILDPROJECTPERFORMANCECODE

--drop table USR_CHILDPROJECTPERFORMANCECODE
GO
