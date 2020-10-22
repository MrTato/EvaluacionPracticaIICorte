CREATE PROC SELECT_HumanResources_Department
AS
SELECT [DepartmentID]
      ,[Name]
      ,[GroupName]
      ,[ModifiedDate]
  FROM [HumanResources].[Department]

GO
