CREATE PROC INSERT_HumanResources_Department (
	@Name [dbo].[Name],
	@GroupName [dbo].[Name],
	@ModifiedDate datetime
)
AS
INSERT INTO [HumanResources].[Department]
           ([Name]
           ,[GroupName]
           ,[ModifiedDate])
     VALUES
           (@Name
           ,@GroupName
           ,@ModifiedDate)
GO