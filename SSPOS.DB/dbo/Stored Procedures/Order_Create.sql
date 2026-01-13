CREATE PROCEDURE [dbo].[Order_Create]
    @BillNo VARCHAR(50),
    @TableNo INT,
    @TableSection VARCHAR(50),
    @WaiterId INT,
    @PriceSection VARCHAR(50) = 'Regular',  -- Default to 'Regular'
    @Status VARCHAR(50),
    @CreatedBy VARCHAR(50),
    @NewRowId INT OUTPUT -- Add the output parameter
AS
BEGIN
    INSERT INTO [dbo].[Order] 
    (
        [BillNo],
        [TableNo],
        [TableSection],
        [WaiterId],
        [PriceSection],
        [Status],
        [CreatedBy],
        [UpdatedBy]
    )
    VALUES
    (
        @BillNo,
        @TableNo,
        @TableSection,
        @WaiterId,
        @PriceSection,
        @Status,
        @CreatedBy,
        @CreatedBy
    );

    -- Set the output parameter to the row count
    SET  @NewRowId = SCOPE_IDENTITY();
END;
