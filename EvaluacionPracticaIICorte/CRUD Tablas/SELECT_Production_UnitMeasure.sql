CREATE PROC SELECT_Production_UnitMeasure
AS
SELECT [UnitMeasureCode]
      ,[Name]
      ,[ModifiedDate]
  FROM [Production].[UnitMeasure]

GO

