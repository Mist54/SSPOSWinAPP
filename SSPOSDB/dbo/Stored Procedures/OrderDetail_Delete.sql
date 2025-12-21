-- 5. OrderDetail_Delete
CREATE PROCEDURE [dbo].[OrderDetail_Delete]
    @Id INT
AS
BEGIN
    UPDATE [dbo].[OrderDetail]
    SET [IsDeleted] = 0,
        [UpdatedDate] = GETDATE()
    WHERE [Id] = @Id;
END;
