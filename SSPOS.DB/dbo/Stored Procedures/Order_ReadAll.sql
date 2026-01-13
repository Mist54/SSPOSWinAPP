-- 3. Order_ReadAll
CREATE PROCEDURE [dbo].[Order_ReadAll]
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
    WHERE [IsDeleted] = 0;
END;
