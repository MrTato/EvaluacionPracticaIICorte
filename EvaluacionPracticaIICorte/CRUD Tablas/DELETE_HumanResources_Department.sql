CREATE PROC DELETE_HumanResources_Department (
	@DepartamentoID smallint
)
AS
DELETE FROM [HumanResources].[Department]
      WHERE @DepartamentoID = @DepartamentoID
GO