-- 1. Procedure to read all records
CREATE PROCEDURE [dbo].[Category_ReadDistinctCategory]
AS
BEGIN
    SELECT distinct[Category], 0 as [ID],'' as [Subcategory],'' as [UOM]
    FROM [SSPOS].[dbo].[Category];
END;
