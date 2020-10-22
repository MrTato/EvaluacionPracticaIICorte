CREATE PROC INSERT_Production_ProductCategory (
	@Name [dbo].[Name],
	@ModifiedDate datetime
)
AS
INSERT INTO [Production].[ProductCategory]
           ([Name]
           ,[rowguid]
           ,[ModifiedDate])
     VALUES
           (@Name
           ,NEWID()
           ,@ModifiedDate)
GO