
CREATE PROCEDURE [dbo].[Order_OrderUpdateOrderStatus]
    @status NVARCHAR(20),
    @OrderId INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        -- Validate input parameters
        IF @status IS NULL OR LEN(@status) = 0
            THROW 50000, 'Invalid status value.', 1;

        IF @OrderId IS NULL OR @OrderId <= 0
            THROW 50001, 'Invalid OrderId value.', 1;

        BEGIN TRANSACTION;

        -- Update Order table
        UPDATE [dbo].[Order]
        SET Status = @status
        WHERE Id = @OrderId;

		DECLARE @OrderRows INT = @@ROWCOUNT;

        -- Update OrderDetail tablea
        UPDATE [dbo].[OrderDetail]
        SET Status = @status
        WHERE OrderId = @OrderId;

		DECLARE @OrderDetailRows INT = @@ROWCOUNT;

         IF @OrderRows > 0 AND @OrderDetailRows > 0
        BEGIN
            COMMIT TRANSACTION;
            RETURN 1; -- Indicate success if at least one row was updated
        END
        ELSE
        BEGIN
            ROLLBACK TRANSACTION;
            RETURN 0; -- Indicate failure if no rows were updated
        END
    END TRY
    BEGIN CATCH
        -- Rollback transaction in case of an error
        IF XACT_STATE() <> 0
            ROLLBACK TRANSACTION;

        -- Return failure value
        RETURN 0; -- Indicate failure
    END CATCH
END
