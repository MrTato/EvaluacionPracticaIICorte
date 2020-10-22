CREATE PROC UPDATE_Production_UnitMeasure (
	@UnitMeasureCode nchar(3),
	@Name [dbo].[Name],
	@ModifiedDate datetime
)
AS
UPDATE [Production].[UnitMeasure]
   SET [Name] = @Name
      ,[ModifiedDate] = @ModifiedDate
 WHERE UnitMeasureCode = @UnitMeasureCode
GO