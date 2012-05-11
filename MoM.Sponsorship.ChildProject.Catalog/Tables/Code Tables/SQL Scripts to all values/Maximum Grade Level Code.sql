
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTMAXGRADELEVELCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Pre-School', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Kindergarten', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Primary School', 1,30,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Secondary School', 1,40,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Vocational School', 1,50,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Apprenticeship', 1,60,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Other', 1,1000,@ID,@ID,GETDATE(),GETDATE())
--delete dbo.USR_CHILDPROJECTMAXGRADELEVELCODE			
select * from dbo.USR_CHILDPROJECTMAXGRADELEVELCODE

--drop table USR_CHILDPROJECTMAXGRADELEVELCODE
GO
