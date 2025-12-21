-- Stored Procedure: Product_ReadByProductName
CREATE PROCEDURE [dbo].[Product_ReadByProductName]
    @ProductName VARCHAR(255)
AS
BEGIN
     SELECT 
        P.[ID],
        P.[ProductName],
        P.[Code],
        P.[MRP],
        P.[CategoryID],
        C.[Category] AS [CategoryName],
        C.[Subcategory],
        C.[UOM],
        P.[RegularPrice],
        P.[DirectPrice],
        P.[OutsidePrice],
        P.[CreatedBy],
        P.[CreatedDate],
        P.[ModifiedBy],
        P.[ModifiedDate]
    FROM 
        Product AS P
    LEFT JOIN 
        Category AS C ON P.[CategoryID] = C.[ID]
	  WHERE ProductName = @ProductName 
	 
END;
