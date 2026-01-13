CREATE PROCEDURE [dbo].[Seating_ReadByID]
    @ID INT
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
    WHERE ID = @ID AND IsDeleted = 0;
END;
