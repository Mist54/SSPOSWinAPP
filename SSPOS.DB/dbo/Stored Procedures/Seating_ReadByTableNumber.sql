CREATE PROCEDURE [dbo].[Seating_ReadByTableNumber]
    @TableNumber VARCHAR(10)
AS
BEGIN
    SELECT 
        ID,
        TableNumber,
        Capacity,
        IsReserved,
        ReservationTime,
        Status,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        IsDeleted
    FROM Seating
    WHERE TableNumber = @TableNumber AND IsDeleted = 0;
END;
