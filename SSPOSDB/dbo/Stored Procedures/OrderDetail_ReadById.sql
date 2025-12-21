-- 4. OrderDetail_ReadById
CREATE PROCEDURE [dbo].[OrderDetail_ReadById]
    @Id INT
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
    WHERE [Id] = @Id AND [IsDeleted] = 0;
END;
