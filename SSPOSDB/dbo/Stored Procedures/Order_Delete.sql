-- 5. Order_Delete
CREATE PROCEDURE [dbo].[Order_Delete]
    @Id INT
AS
BEGIN
    UPDATE [dbo].[Order]
    SET [IsDeleted] = 0,
        [UpdatedDate] = GETDATE()
    WHERE [Id] = @Id;
END;

-- Stored Procedures for OrderDetail Table
