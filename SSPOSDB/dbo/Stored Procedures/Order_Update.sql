-- 2. Order_Update
CREATE PROCEDURE [dbo].[Order_Update]
    @Id INT,
    @BillNo VARCHAR(50),
    @TableNo INT,
    @TableSection VARCHAR(50),
    @WaiterId INT,
    @PriceSection VARCHAR(50),
    @Status VARCHAR(50),
    @UpdatedBy VARCHAR(50)
AS
BEGIN
    UPDATE [dbo].[Order]
    SET
        [BillNo] = @BillNo,
        [TableNo] = @TableNo,
        [TableSection] = @TableSection,
        [WaiterId] = @WaiterId,
        [PriceSection] = @PriceSection,
        [Status] = @Status,
        [UpdatedBy] = @UpdatedBy,
        [UpdatedDate] = GETDATE()
    WHERE [Id] = @Id;
END;
