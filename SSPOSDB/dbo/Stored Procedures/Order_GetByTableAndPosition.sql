
CREATE PROCEDURE [dbo].[Order_GetByTableAndPosition]
    @TableNo INT,
    @TableSection VARCHAR(10),
	@status NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    -- Retrieve rows from the Order table based on TableNo and TableSection
    SELECT [Id],
           [BillNo],
           [TableNo],
           [TableSection],
           [WaiterId],
           [PriceSection],
           [Status],
           [CreatedBy],
           [CreatedDate],
           [UpdatedBy],
           [UpdatedDate],
           [IsDeleted]
    FROM [SSPOS].[dbo].[Order]
    WHERE [TableNo] = @TableNo
      AND [TableSection] = @TableSection
	  AND IsDeleted = 0 
	   AND (@status IS NULL OR Status = @status)
END
