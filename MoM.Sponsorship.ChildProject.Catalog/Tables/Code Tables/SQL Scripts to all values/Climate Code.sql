
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTCLIMATECODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Dry', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Humid', 1,20,@ID,@ID,GETDATE(),GETDATE())

--delete dbo.USR_CHILDPROJECTCLIMATECODE			
select * from dbo.USR_CHILDPROJECTCLIMATECODE

--drop table USR_CHILDPROJECTCLIMATECODE
GO
