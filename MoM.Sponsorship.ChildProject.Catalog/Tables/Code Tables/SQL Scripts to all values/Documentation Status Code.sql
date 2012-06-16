
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTDOCUMENTATIONSTATUSCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Yes - 2012', 1,110,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'No - 2012', 1,120,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Yes - 2011', 1,130,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'No - 2011', 1,140,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Yes - 2010', 1,150,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'No - 2010', 1,160,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Yes - 2009', 1,170,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'No - 2009', 1,180,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Yes - 2008', 1,190,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'No - 2008', 1,200,@ID,@ID,GETDATE(),GETDATE())
			
--delete dbo.USR_CHILDPROJECTDOCUMENTATIONSTATUSCODE			
select * from dbo.USR_CHILDPROJECTDOCUMENTATIONSTATUSCODE

--drop table USR_CHILDPROJECTDOCUMENTATIONSTATUSCODE
GO
