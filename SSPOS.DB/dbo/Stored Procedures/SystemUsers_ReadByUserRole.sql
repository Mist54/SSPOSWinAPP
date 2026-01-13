CREATE PROCEDURE [dbo].[SystemUsers_ReadByUserRole]
    @Role INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        [Id],
        [Name],
        [Password],
        [Email],
        [Company],
        [Role],
        [IsActive],
        [CreatedBy],
        [CreatedDate],
        [ModifiedBy],
        [ModifiedDate],
        [IsDeleted]
    FROM [SSPOS].[dbo].[SystemUsers]
    WHERE [Role] = @Role
      AND [IsDeleted] = 0 -- Assuming you only want non-deleted users
    ORDER BY [CreatedDate]; -- You can change this to your preferred sorting order
END
