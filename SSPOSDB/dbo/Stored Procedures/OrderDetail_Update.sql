-- 2. OrderDetail_Update
CREATE PROCEDURE [dbo].[OrderDetail_Update]
    @Id INT,
    @OrderId INT,
    @ProductId INT,
    @Price DECIMAL(18, 2),
    @Qty INT,
    @Status VARCHAR(50),
    @UpdatedBy VARCHAR(50),
	@RowsAffected INT OUTPUT 
AS
BEGIN
    UPDATE [dbo].[OrderDetail]
    SET
        [OrderId] = @OrderId,
        [ProductId] = @ProductId,
        [Price] = @Price,
        [Qty] = @Qty,
        [Status] = @Status,
        [UpdatedBy] = @UpdatedBy,
        [UpdatedDate] = GETDATE()
    WHERE [Id] = @Id;

	 -- Return the number of rows affected
    SET @RowsAffected = @@ROWCOUNT;
END;
