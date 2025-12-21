CREATE PROCEDURE [dbo].[Seating_Create]
    @TableNumber VARCHAR(10),
    @Capacity INT,
    @IsReserved BIT,
    @ReservationTime DATETIME,
    @Status VARCHAR(20),
    @CreatedBy VARCHAR(50)
AS
BEGIN
    INSERT INTO Seating (
        TableNumber,
        Capacity,
        IsReserved,
        ReservationTime,
        Status,
        CreatedBy,
        CreatedDate
    )
    VALUES (
        @TableNumber,
        @Capacity,
        @IsReserved,
        @ReservationTime,
        @Status,
        @CreatedBy,
        GETDATE()
    );
END;
