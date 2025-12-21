
-- 5. Procedure to read by UOM
create PROCEDURE [dbo].[Category_ReadID]
	@Category NVARCHAR(255),
	@Subcategory NVARCHAR(255),
	@UOM NVARCHAR(50)
AS
BEGIN
    SELECT [ID], [Category], [Subcategory], [UOM]
    FROM [SSPOS].[dbo].[Category]
    WHERE 
	[Category] = @Category 
	AND	[Subcategory] = @Subcategory
	AND [UOM] = @UOM;
END;
