-- Stored Procedure: Product_ReadByID
CREATE PROCEDURE [dbo].[Product_ReadByID]
    @ID INT
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
	 WHERE P.ID = @ID ;
END;
