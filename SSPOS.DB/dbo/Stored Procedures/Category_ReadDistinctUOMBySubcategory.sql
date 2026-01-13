
-- Procedure to read distinct UOMs by Subcategory and Category
CREATE PROCEDURE [dbo].[Category_ReadDistinctUOMBySubcategory]
   @Subcategory NVARCHAR(255),
   @Category NVARCHAR(MAX)
AS
BEGIN
    SELECT DISTINCT [UOM], [ID], [Category], [Subcategory]
    FROM [SSPOS].[dbo].[Category]
    WHERE [Subcategory] = @Subcategory AND [Category] = @Category;
END;
