-- Stored Procedure: Product_Update
CREATE PROCEDURE [dbo].[Product_UpdateCodeAndPrice]
    @ID INT,
    @Code INT,
    @MRP DECIMAL(10,2),
    @RegularPrice DECIMAL(10,2),
    @DirectPrice DECIMAL(10,2),
    @OutsidePrice DECIMAL(10,2),
    @ModifiedBy VARCHAR(100),
	@ReturnValue INT OUTPUT -- Add output parameter for row count
   
AS
BEGIN
    UPDATE Product
    SET Code = @Code,
        MRP = @MRP,
        RegularPrice = @RegularPrice,
        DirectPrice = @DirectPrice,
        OutsidePrice = @OutsidePrice,
        ModifiedBy = @ModifiedBy,
        ModifiedDate = GETDATE()
    WHERE ID = @ID;

      SET @ReturnValue = @@ROWCOUNT;
END;
