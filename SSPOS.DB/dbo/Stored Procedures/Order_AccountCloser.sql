CREATE PROCEDURE Order_AccountCloser
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Success BIT = 1;
    
    BEGIN TRY
        -- Disable constraints temporarily
        ALTER TABLE OrderDetail NOCHECK CONSTRAINT ALL;
        ALTER TABLE [Order] NOCHECK CONSTRAINT ALL;
        
        -- Delete all records
        DELETE FROM OrderDetail;
        DELETE FROM [Order];
        
        -- Reset Identity columns
        DBCC CHECKIDENT ('OrderDetail', RESEED, 0);
        DBCC CHECKIDENT ('[Order]', RESEED, 0);
        
        -- Re-enable constraints
        ALTER TABLE OrderDetail CHECK CONSTRAINT ALL;
        ALTER TABLE [Order] CHECK CONSTRAINT ALL;
    END TRY
    BEGIN CATCH
        SET @Success = 0;
    END CATCH

    SELECT @Success AS Result;
END;
