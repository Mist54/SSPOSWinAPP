-- 4. OrderDetail_ReadById
CREATE PROCEDURE [dbo].[OrderDetail_ReadByOrderId]
    @OrderId INT
AS
BEGIN
    SELECT 
        [Id],
        [OrderId],
        [ProductId],
        [Price],
        [Qty],
        [Status], 
        [CreatedBy],
        [CreatedDate],
        [UpdatedBy],
        [UpdatedDate]
    FROM [dbo].[OrderDetail]
    WHERE [OrderId] = @OrderId AND [IsDeleted] = 0;
END;
