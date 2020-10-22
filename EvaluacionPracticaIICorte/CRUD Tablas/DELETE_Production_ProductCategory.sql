CREATE PROC DELETE_Production_ProductCategory (
	@ProductCategoryID int
)
AS
DELETE FROM [Production].[ProductCategory]
      WHERE ProductCategoryID = @ProductCategoryID
GO