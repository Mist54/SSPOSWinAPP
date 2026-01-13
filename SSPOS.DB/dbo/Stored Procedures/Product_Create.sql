
-- Stored Procedure: Product_Create
CREATE PROCEDURE [dbo].[Product_Create]
    @ProductName VARCHAR(255),
    @Code INT,   
    @MRP DECIMAL(10,2),
    @CategoryID INT,
    @RegularPrice DECIMAL(10,2),
    @DirectPrice DECIMAL(10,2),
    @OutsidePrice DECIMAL(10,2),
    @CreatedBy VARCHAR(100)
    
    
AS
BEGIN
    INSERT INTO Product (ProductName, Code, MRP, CategoryID, RegularPrice, DirectPrice, 
						OutsidePrice, CreatedBy, ModifiedBy)
    VALUES (@ProductName, @Code, @MRP, @CategoryID, @RegularPrice, @DirectPrice, 
			@OutsidePrice, @CreatedBy, @CreatedBy);

    RETURN @@ROWCOUNT;
END;
