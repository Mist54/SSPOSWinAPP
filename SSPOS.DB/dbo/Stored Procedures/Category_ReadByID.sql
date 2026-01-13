
-- 2. Procedure to read by ID
CREATE PROCEDURE [dbo].[Category_ReadByID]
    @ID INT
AS
BEGIN
    SELECT [ID], [Category], [Subcategory], [UOM]
    FROM [SSPOS].[dbo].[Category]
    WHERE [ID] = @ID;
END;
