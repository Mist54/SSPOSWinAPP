CREATE PROCEDURE [dbo].[Seating_Update]
    @ID INT,
    @TableNumber VARCHAR(10),
    @Capacity INT,
    @IsReserved BIT,
    @ReservationTime DATETIME,
    @Status VARCHAR(20),
    @UpdatedBy VARCHAR(50)
AS
BEGIN
    UPDATE Seating
    SET 
        TableNumber = @TableNumber,
        Capacity = @Capacity,
        IsReserved = @IsReserved,
        ReservationTime = @ReservationTime,
        Status = @Status,
        UpdatedBy = @UpdatedBy,
        UpdatedDate = GETDATE()
    WHERE ID = @ID AND IsDeleted = 0;
END;
