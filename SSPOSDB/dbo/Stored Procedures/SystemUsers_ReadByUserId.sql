CREATE PROCEDURE [dbo].[SystemUsers_ReadByUserId]
    @Id INT
AS
BEGIN
    SELECT Id, Name, Email, Company, Role, IsActive, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate
    FROM SystemUsers
    WHERE Id=@Id AND IsDeleted = 0;
END;
