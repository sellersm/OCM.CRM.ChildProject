
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT



INSERT INTO USR_CHILDPROJECTCOMMUNITYTYPECODE 
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Rural', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Urban', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Suburban', 1,30,@ID,@ID,GETDATE(),GETDATE())
			
--delete dbo.USR_CHILDPROJECTCOMMUNITYTYPECODE			
select * from dbo.USR_CHILDPROJECTCOMMUNITYTYPECODE

--drop table USR_CHILDPROJECTCOMMUNITYTYPECODE
GO
