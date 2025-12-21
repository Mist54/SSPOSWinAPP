CREATE TABLE SystemUsers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Password NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL UNIQUE,
    Company NVARCHAR(255),
    Role INT CHECK (Role >= 0 AND Role <= 10),
    IsActive BIT NOT NULL DEFAULT 1,
    CreatedBy NVARCHAR(100),
    CreatedDate DATETIME DEFAULT GETDATE(),
    ModifiedBy NVARCHAR(100),
    ModifiedDate DATETIME,
    IsDeleted BIT NOT NULL DEFAULT 0
);

GO
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

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SystemUsers_ReadAll]
AS
BEGIN
    SELECT * FROM SystemUsers
    WHERE IsDeleted = 0;
END;


GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SystemUsers_ReadByUserName]
    @UserName NVARCHAR(100)
AS
BEGIN
    SELECT Id, Name, Email, Company, Role, IsActive, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate
    FROM SystemUsers
    WHERE Name = @UserName AND IsDeleted = 0;
END;

GO
Create PROCEDURE [dbo].[SystemUsers_Update]
    @Id INT,
    @Name NVARCHAR(100),
    @Password NVARCHAR(255),
    @Email NVARCHAR(255),
    @Company NVARCHAR(255),
    @Role TINYINT,
    @ModifiedBy NVARCHAR(100)
AS
BEGIN
    UPDATE SystemUsers
    SET Name = @Name,
        Password = @Password,
        Email = @Email,
        Company = @Company,
        Role = @Role,
        ModifiedBy = @ModifiedBy,
        ModifiedDate = GETDATE()
    WHERE Id = @Id AND IsDeleted = 0;
END;

GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SystemUsers_ReadByUserId]
    @Id INT
AS
BEGIN
    SELECT Id, Name, Email, Company, Role, IsActive, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate
    FROM SystemUsers
    WHERE Id=@Id AND IsDeleted = 0;
END;
