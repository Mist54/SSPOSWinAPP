CREATE PROCEDURE [dbo].[SystemUsers_ReadAll]
AS
BEGIN
    SELECT * FROM SystemUsers
    WHERE IsDeleted = 0;
END;
