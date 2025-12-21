-- 3. OrderDetail_ReadAll
CREATE PROCEDURE [dbo].[OrderDetail_ReadAll]
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
    WHERE [IsDeleted] = 0;
END;
