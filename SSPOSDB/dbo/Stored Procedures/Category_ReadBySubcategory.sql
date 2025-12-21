
-- 4. Procedure to read by Subcategory
CREATE PROCEDURE [dbo].[Category_ReadBySubcategory]
    @Subcategory NVARCHAR(255)
AS
BEGIN
    SELECT [ID], [Category], [Subcategory], [UOM]
    FROM [SSPOS].[dbo].[Category]
    WHERE [Subcategory] = @Subcategory;
END;
