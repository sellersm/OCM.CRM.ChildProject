
DECLARE     @return_value int,
            @ID uniqueidentifier

EXEC  @return_value = [dbo].[USP_CHANGEAGENT_GETORCREATECHANGEAGENTFROMCONTEXT]
            @ID = @ID OUTPUT


INSERT INTO dbo.USR_CHILDPROJECTCATEGORYCODE
           ([ID]
           ,[DESCRIPTION]
           ,[ACTIVE]
           ,[SEQUENCE]
           ,[ADDEDBYID]
           ,[CHANGEDBYID]
           ,[DATEADDED]
           ,[DATECHANGED])
     VALUES (NEWID(), 'Forgotten Children Project', 1,10,@ID,@ID,GETDATE(),GETDATE()),
			(NEWID(), 'Poverty Project', 1,20,@ID,@ID,GETDATE(),GETDATE())
			
--delete dbo.USR_CHILDPROJECTCATEGORYCODE			
select * from dbo.USR_CHILDPROJECTCATEGORYCODE

--drop table USR_CHILDPROJECTCATEGORYCODE
GO
