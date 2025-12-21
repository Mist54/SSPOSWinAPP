CREATE PROCEDURE [dbo].[SystemUsers_ReadByUserName]
    @UserName NVARCHAR(100)
AS
BEGIN
    SELECT Id, Name, Password, Email, Company, Role, IsActive, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, IsDeleted
    FROM SystemUsers
    WHERE Name = @UserName AND IsDeleted = 0;

	RETURN @@ROWCOUNT
END;
