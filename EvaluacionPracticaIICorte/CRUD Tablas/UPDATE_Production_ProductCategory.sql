CREATE PROC UPDATE_Production_ProductCategory (
	@ProductCategoryID int,
	@Name [dbo].[Name],
	@ModifiedDate datetime
)
AS
UPDATE [Production].[ProductCategory]
   SET [Name] = @Name
      ,[ModifiedDate] = @ModifiedDate
 WHERE ProductCategoryID = @ProductCategoryID
GO