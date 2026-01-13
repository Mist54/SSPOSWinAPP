CREATE PROCEDURE [dbo].[Seating_MarkAsDeleted]
    @ID INT,
    @UpdatedBy VARCHAR(50)
AS
BEGIN
    UPDATE Seating
    SET 
        IsDeleted = 1,
        UpdatedBy = @UpdatedBy,
        UpdatedDate = GETDATE()
    WHERE ID = @ID;
END;
