-- 1. Procedure to read all records
CREATE PROCEDURE [dbo].[Category_ReadDistinctSubcategoryByCategory]
   @Category NVARCHAR(255)
AS
BEGIN
    SELECT distinct[Subcategory], 0 as [ID], [Category],''as [UOM]
    FROM [SSPOS].[dbo].[Category]
	WHERE [Category] = @Category;
END;
