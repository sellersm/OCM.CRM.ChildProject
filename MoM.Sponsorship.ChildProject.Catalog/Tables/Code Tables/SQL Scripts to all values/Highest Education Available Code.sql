
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTHIGHESTEDUCATIONCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'None', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Primary School', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Secondary School', 1,30,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Vocational Training', 1,40,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'University', 1,50,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Other', 1,1000,@ID,@ID,GETDATE(),GETDATE())
--delete dbo.USR_CHILDPROJECTHIGHESTEDUCATIONCODE			
select * from dbo.USR_CHILDPROJECTHIGHESTEDUCATIONCODE

--drop table USR_CHILDPROJECTHIGHESTEDUCATIONCODE
GO
