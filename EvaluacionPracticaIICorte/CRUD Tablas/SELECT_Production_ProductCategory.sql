CREATE PROC SELECT_Production_ProductCategory
AS
SELECT [ProductCategoryID]
      ,[Name]
      ,[rowguid]
      ,[ModifiedDate]
  FROM [Production].[ProductCategory]

GO