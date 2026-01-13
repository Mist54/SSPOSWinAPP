
-- 3. Procedure to read by Category with distinct Subcategory
CREATE PROCEDURE [dbo].[Category_ReadByCategory]
    @Category NVARCHAR(255)
AS
BEGIN
    SELECT  ID,[Category], [Subcategory],UOM
    FROM [SSPOS].[dbo].[Category]
    WHERE [Category] = @Category;
END;
