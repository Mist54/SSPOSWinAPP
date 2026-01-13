
CREATE PROCEDURE [dbo].[OrderDetail_Create]
    @OrderId INT,
    @ProductId INT,
    @Price DECIMAL(18, 2),
    @Qty INT,
    @Status VARCHAR(50),
    @CreatedBy VARCHAR(50),
    @RowCount INT OUTPUT -- Add the output parameter
AS
BEGIN
    SET NOCOUNT ON;

    -- Check if the record exists
    IF EXISTS (
        SELECT 1 FROM [dbo].[OrderDetail]
        WHERE [OrderId] = @OrderId
          AND [ProductId] = @ProductId
          AND [Price] = @Price
          AND [Status] = @Status
    )
    BEGIN
        -- Update the quantity by adding the existing Qty with the new Qty
        UPDATE [dbo].[OrderDetail]
        SET [Qty] = [Qty] + @Qty,
            [UpdatedBy] = @CreatedBy
        WHERE [OrderId] = @OrderId
          AND [ProductId] = @ProductId
          AND [Price] = @Price
          AND [Status] = @Status;
        
        -- Set the output parameter to the number of affected rows
        SET @RowCount = @@ROWCOUNT;
    END
    ELSE
    BEGIN
        -- Insert a new record
        INSERT INTO [dbo].[OrderDetail] 
        (
            [OrderId],
            [ProductId],
            [Price],
            [Qty],
            [Status],
            [CreatedBy],
            [UpdatedBy]
        )
        VALUES
        (
            @OrderId,
            @ProductId,
            @Price,
            @Qty,
            @Status,
            @CreatedBy,
            @CreatedBy
        );
        
        -- Set the output parameter to the number of affected rows
        SET @RowCount = @@ROWCOUNT;
    END
END;
