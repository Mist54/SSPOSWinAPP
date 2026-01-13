
-- 5. Procedure to read by UOM
CREATE PROCEDURE [dbo].[Category_ReadByUOM]
    @UOM NVARCHAR(50)
AS
BEGIN
    SELECT [ID], [Category], [Subcategory], [UOM]
    FROM [SSPOS].[dbo].[Category]
    WHERE [UOM] = @UOM;
END;
