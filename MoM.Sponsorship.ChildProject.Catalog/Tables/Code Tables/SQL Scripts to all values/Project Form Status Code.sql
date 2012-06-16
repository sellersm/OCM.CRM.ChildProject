
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTFORMSTATUSCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), '2012 - Yes', 1,110,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '2011 - Yes', 1,120,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '2010 - Yes', 1,130,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '2009 - Yes', 1,140,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '2008 - Yes', 1,150,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'No', 1,160,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Not Required', 1,170,@ID,@ID,GETDATE(),GETDATE())
			
--delete dbo.USR_CHILDPROJECTFORMSTATUSCODE			
select * from dbo.USR_CHILDPROJECTFORMSTATUSCODE

--drop table USR_CHILDPROJECTFORMSTATUSCODE
GO
