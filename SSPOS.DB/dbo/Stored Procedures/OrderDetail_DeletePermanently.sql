CREATE PROCEDURE [dbo].[OrderDetail_DeletePermanently]
    @TableId INT,
    @TablePosition VARCHAR(10),
    @ProductCode INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Declare a variable to hold the number of rows affected
    DECLARE @RowsAffected INT;

    -- Perform the delete operation and capture the number of rows affected
    DELETE OD
    FROM [dbo].[OrderDetail] OD
    INNER JOIN [dbo].[Order] O ON O.Id = OD.OrderId
    WHERE O.TableNo = @TableId 
          AND O.TableSection = @TablePosition
          AND OD.ProductId = @ProductCode;

    SET @RowsAffected = @@ROWCOUNT;

    -- Return 1 if rows were affected, otherwise 0
    IF @RowsAffected > 0
        RETURN 1;
    ELSE
        RETURN 0;
END
