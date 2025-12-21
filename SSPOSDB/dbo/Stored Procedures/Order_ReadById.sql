-- 4. Order_ReadById
CREATE PROCEDURE [dbo].[Order_ReadById]
    @Id INT
AS
BEGIN
    SELECT 
        [Id],
        [BillNo],
        [TableNo],
        [TableSection],
        [WaiterId],
        [PriceSection],
        [Status],
        [CreatedBy],
        [CreatedDate],
        [UpdatedBy],
        [UpdatedDate]
    FROM [dbo].[Order]
    WHERE [Id] = @Id AND [IsDeleted] = 0;
END;
