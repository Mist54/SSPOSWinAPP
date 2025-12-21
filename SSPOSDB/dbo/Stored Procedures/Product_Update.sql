CREATE PROCEDURE [dbo].[Product_Update]
    @ID INT,
    @ProductName VARCHAR(255),
    @Code INT,
    @MRP DECIMAL(10,2),
    @CategoryID INT,
    @RegularPrice DECIMAL(10,2),
    @DirectPrice DECIMAL(10,2),
    @OutsidePrice DECIMAL(10,2),
    @ModifiedBy VARCHAR(100),
    @RowsAffected INT OUTPUT  -- Adding output parameter
AS
BEGIN
    -- Update statement
    UPDATE Product
    SET ProductName = @ProductName,
        Code = @Code,
        MRP = @MRP,
        CategoryID = @CategoryID,
        RegularPrice = @RegularPrice,
        DirectPrice = @DirectPrice,
        OutsidePrice = @OutsidePrice,
        ModifiedBy = @ModifiedBy,
        ModifiedDate = GETDATE()
    WHERE ID = @ID;

    -- Set the output parameter to the number of affected rows
    SET @RowsAffected = @@ROWCOUNT;
    
    -- Optional: If no rows were affected, set @RowsAffected to 0
    IF @RowsAffected = 0
    BEGIN
        SET @RowsAffected = 0;  -- Ensure zero if no rows are affected
    END
END;
