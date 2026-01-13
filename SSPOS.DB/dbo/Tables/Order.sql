CREATE TABLE [dbo].[Order] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [BillNo]       VARCHAR (50) NOT NULL,
    [TableNo]      INT          NOT NULL,
    [TableSection] VARCHAR (50) NOT NULL,
    [WaiterId]     INT          NOT NULL,
    [PriceSection] VARCHAR (50) DEFAULT ('Regular') NOT NULL,
    [Status]       VARCHAR (50) NOT NULL,
    [CreatedBy]    VARCHAR (50) NOT NULL,
    [CreatedDate]  DATETIME     DEFAULT (getdate()) NOT NULL,
    [UpdatedBy]    VARCHAR (50) NOT NULL,
    [UpdatedDate]  DATETIME     DEFAULT (getdate()) NOT NULL,
    [IsDeleted]    BIT          DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE TRIGGER [dbo].[trg_UpdateBillNo]
ON [dbo].[Order]
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Process only rows where the status changed from 'Ordered' to 'Billed'
    IF NOT EXISTS (
        SELECT 1
        FROM inserted i
        JOIN deleted d ON i.Id = d.Id
        WHERE i.Status = 'Billed'
          AND d.Status = 'Ordered' -- Ensure only 'Ordered' → 'Billed' transition
    )
    BEGIN
        RETURN;
    END

    -- Get the current maximum bill number (only counting those that are already sequential numbers)
    DECLARE @maxBillNo INT;
    SELECT @maxBillNo = MAX(TRY_CAST(BillNo AS INT))
    FROM dbo.[Order]
    WHERE TRY_CAST(BillNo AS INT) IS NOT NULL;

    -- If none exists, start with 0 so the first new one will be 1.
    SET @maxBillNo = ISNULL(@maxBillNo, 0);

    ;WITH BillCTE AS (
        SELECT o.Id,
               NewBillNo = @maxBillNo + ROW_NUMBER() OVER (ORDER BY o.Id)
        FROM dbo.[Order] o
        INNER JOIN inserted i ON o.Id = i.Id
        INNER JOIN deleted d ON o.Id = d.Id
        WHERE i.Status = 'Billed'
          AND d.Status = 'Ordered' -- Ensure only 'Ordered' → 'Billed' transition
    )
    UPDATE o
    SET BillNo = CAST(cte.NewBillNo AS VARCHAR(50))
    FROM dbo.[Order] o
    INNER JOIN BillCTE cte ON o.Id = cte.Id;
END;
