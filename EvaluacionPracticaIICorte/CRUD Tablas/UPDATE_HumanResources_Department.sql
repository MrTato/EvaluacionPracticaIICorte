CREATE PROC UPDATE_HumanResources_Department (
	@DepartmentID smallint,
	@Name [dbo].[Name],
	@GroupName [dbo].[Name],
	@ModifiedDate datetime
)
AS
UPDATE [HumanResources].[Department]
   SET [Name] = @Name
      ,[GroupName] = @GroupName
      ,[ModifiedDate] = @ModifiedDate
 WHERE DepartmentID = @DepartmentID
GO