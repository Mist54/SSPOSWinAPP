CREATE PROCEDURE [dbo].[Seating_ReadAll]
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
    WHERE IsDeleted = 0;
END;
