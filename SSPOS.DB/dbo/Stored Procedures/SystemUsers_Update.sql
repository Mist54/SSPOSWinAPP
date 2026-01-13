CREATE PROCEDURE [dbo].[SystemUsers_Update]
    @Id INT, -- Added parameter for user identification
    @Name NVARCHAR(100),
    @Password NVARCHAR(255),
    @Email NVARCHAR(255),
    @Company NVARCHAR(255),
    @Role TINYINT,
    @IsActive BIT,
    @IsDeleted BIT,
    @ModifiedBy NVARCHAR(100),
    @ModifiedDate DATETIME,
    @rowsAffected INT OUTPUT  -- Add output parameter for affected rows
AS
BEGIN
    SET NOCOUNT ON; -- Prevents extra result sets from interfering with SELECT statements

    UPDATE SystemUsers
    SET 
        Name = @Name,
        Password = @Password,
        Email = @Email,
        Company = @Company,
        Role = @Role,
        IsActive = @IsActive,
        IsDeleted = @IsDeleted,
        ModifiedBy = @ModifiedBy,
        ModifiedDate = @ModifiedDate
    WHERE 
        Id = @Id;  -- Identify the record to update by Id

    -- Set the output parameter to the number of rows affected
    SET @rowsAffected = @@ROWCOUNT;  -- Return the number of affected rows
END;
