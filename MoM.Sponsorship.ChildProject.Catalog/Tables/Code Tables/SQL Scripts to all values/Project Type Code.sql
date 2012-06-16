
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTTYPECODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Child Development Center', 1,1,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Children''s Home (parents living)', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Mercy Center', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Oprhange', 1,30,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'School', 1,40,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Other', 1,1000,@ID,@ID,GETDATE(),GETDATE())
--delete dbo.USR_CHILDPROJECTTYPECODE			
select * from dbo.USR_CHILDPROJECTTYPECODE

--drop table USR_CHILDPROJECTTYPECODE
GO
