CREATE PROC INSERT_Production_UnitMeasure (
	@UnitMeasureCode nchar(3),
	@Name [dbo].[Name],
	@ModifiedDate datetime
)
AS
INSERT INTO [Production].[UnitMeasure]
           ([UnitMeasureCode]
           ,[Name]
           ,[ModifiedDate])
     VALUES
           (@UnitMeasureCode
           ,@Name
           ,@ModifiedDate)
GO

