CREATE PROC DELETE_Production_UnitMeasure (
	@UnitMeasureCode nchar(6)
)
AS
DELETE FROM [Production].[UnitMeasure]
      WHERE UnitMeasureCode = @UnitMeasureCode
GO