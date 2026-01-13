Create PROCEDURE [dbo].[SystemUsers_Create]
    @Name NVARCHAR(100),
    @Password NVARCHAR(255),
    @Email NVARCHAR(255),
    @Company NVARCHAR(255),
    @Role INT,
    @CreatedBy NVARCHAR(100)
AS
BEGIN
    INSERT INTO SystemUsers(Name, Password, Email, Company, Role,  CreatedBy, CreatedDate)
    VALUES (@Name, @Password, @Email, @Company, @Role, @CreatedBy, GETDATE());
END;

