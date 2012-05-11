
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_MONTHCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), '', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,30,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,40,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,50,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,60,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,70,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,80,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,90,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,100,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,110,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,120,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,130,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), '', 1,1000,@ID,@ID,GETDATE(),GETDATE())
--delete dbo.USR_MONTHCODE			
select * from dbo.USR_MONTHCODE

--drop table USR_MONTHCODE
GO
