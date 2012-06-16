
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTTERRAINCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Coastal', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Desert', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Forest', 1,30,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Hills', 1,40,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Island', 1,50,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Jungle', 1,60,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Mountanous', 1,70,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Plains or Flat Land', 1,80,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Other', 1,1000,@ID,@ID,GETDATE(),GETDATE())

--delete dbo.USR_MONTHCODE			
select * from dbo.USR_CHILDPROJECTTERRAINCODE

--drop table USR_MONTHCODE
GO
