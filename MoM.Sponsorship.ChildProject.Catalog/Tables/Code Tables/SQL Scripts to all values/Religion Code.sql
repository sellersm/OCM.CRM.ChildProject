
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_RELIGIONCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Animist', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Buddhist', 1,20,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Catholic', 1,30,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Coptic', 1,40,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Hindu', 1,50,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Muslim', 1,60,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Orthodox', 1,70,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Protestant', 1,80,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Voodoo', 1,90,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Witchcraft', 1,100,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Other', 1,1000,@ID,@ID,GETDATE(),GETDATE())
--delete from dbo.USR_RELIGIONCODE where ID ='11D2FAC4-DB35-4506-9A47-AD51BF03DD3C'	
select * from dbo.USR_RELIGIONCODE

--drop table USR_RELIGIONCODE
GO
