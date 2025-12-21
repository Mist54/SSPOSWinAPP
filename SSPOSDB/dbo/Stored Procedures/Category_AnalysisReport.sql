CREATE PROCEDURE [dbo].[Category_AnalysisReport]
    @Category NVARCHAR(255) = NULL,
    @Subcategory NVARCHAR(255) = NULL,
    @UOM NVARCHAR(50) = NULL

AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        c.Category AS CategoryName,  
        c.Subcategory, 
        c.UOM,
		p.ProductName,
		
        SUM(od.Qty) AS TotalQty, 
        SUM(od.Qty * od.Price) AS TotalAmount
    FROM [dbo].[Order] AS o
    INNER JOIN OrderDetail od ON o.Id = od.OrderId
    LEFT JOIN [dbo].[Product] p ON p.Code = od.ProductId
    LEFT JOIN Category c ON p.CategoryID = c.ID
    WHERE 
        (@Category IS NULL OR c.Category = @Category)
        AND (@Subcategory IS NULL OR c.Subcategory = @Subcategory)
        AND (@UOM IS NULL OR c.UOM = @UOM)
    GROUP BY c.Category, c.Subcategory, c.UOM,p.ProductName
    ORDER BY Subcategory;
END;
