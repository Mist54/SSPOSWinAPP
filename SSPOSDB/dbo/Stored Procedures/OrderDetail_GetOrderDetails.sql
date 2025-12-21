CREATE PROCEDURE [dbo].[OrderDetail_GetOrderDetails]
    @TableNo INT = NULL,           -- Optional filter by TableNo
    @WaiterId INT = NULL,          -- Optional filter by WaiterId
    @IsDeleted BIT = 0,            -- Default to not deleted
    @TablePosition NVARCHAR(50) = NULL, -- Optional filter by TablePosition
    @Status NVARCHAR(50) = NULL    -- Optional filter by Status
AS
BEGIN
    SELECT 
        o.Id AS OrderId,
        o.BillNo,
        o.TableNo,
        s.TableNumber,
        od.ProductId,
        p.ProductName,
        p.Code AS ProductCode,
        o.TableSection AS TablePosition,
        c.UOM,
		c.Category,
        od.Status AS OrderDetailStatus,
        od.Price,
        od.Qty,
        od.Qty * od.Price AS Total,
		o.CreatedDate 
    FROM 
        [SSPOS].[dbo].[Order] o
    INNER JOIN 
        [SSPOS].[dbo].[OrderDetail] od ON o.Id = od.OrderId
    LEFT JOIN 
        [SSPOS].[dbo].[Product] p ON p.Code = od.ProductId
    LEFT JOIN 
        [SSPOS].[dbo].[Seating] s ON s.ID = o.TableNo
    LEFT JOIN 
        [SSPOS].[dbo].[Category] c ON c.ID = p.CategoryID
    WHERE 
        o.IsDeleted = @IsDeleted
        AND (@TableNo IS NULL OR o.TableNo = @TableNo)  -- Filter by TableNo if provided
        AND (@WaiterId IS NULL OR o.WaiterId = @WaiterId)  -- Filter by WaiterId if provided
        AND (@TablePosition IS NULL OR o.TableSection = @TablePosition) -- Filter by TablePosition if provided
        AND (@Status IS NULL OR od.Status = @Status)  -- Filter by Status if provided
END;
