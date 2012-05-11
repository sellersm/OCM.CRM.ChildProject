
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTSTATUSCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Active', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Active - Reserved', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Pending', 1,30,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Phasing Out', 1,40,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Closed', 1,50,@ID,@ID,GETDATE(),GETDATE())
			
--delete dbo.USR_CHILDPROJECTSTATUSCODE			
select * from dbo.USR_CHILDPROJECTSTATUSCODE



--drop table USR_CHILDPROJECTSTATUSCODE
GO
