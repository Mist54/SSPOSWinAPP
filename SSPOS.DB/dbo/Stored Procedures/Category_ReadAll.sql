-- 1. Procedure to read all records
CREATE PROCEDURE [dbo].[Category_ReadAll]
AS
BEGIN
    SELECT [ID], [Category], [Subcategory], [UOM]
    FROM [SSPOS].[dbo].[Category];
END;
