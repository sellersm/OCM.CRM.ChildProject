
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTSUBCATEGORYCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Street Survival', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Child Survival', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'AID''s Orphans', 1,30,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Trafficking - Sex Trafficking', 1,40,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Trafficking - Exploitative Labor', 1,50,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Armed Conflict - Refugees', 1,60,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Armed Conflict - Child Soldiers', 1,70,@ID,@ID,GETDATE(),GETDATE())
--delete dbo.USR_CHILDPROJECTSUBCATEGORYCODE			
select * from dbo.USR_CHILDPROJECTSUBCATEGORYCODE

--drop table USR_CHILDPROJECTSUBCATEGORYCODE
GO
