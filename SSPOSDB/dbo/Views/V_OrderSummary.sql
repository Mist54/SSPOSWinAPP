CREATE VIEW [dbo].[V_OrderSummary] AS
SELECT
    o.Id AS OrderID,
    o.BillNo,
    o.TableNo,
    o.TableSection,
    u.[Name] AS Waiter,
    o.CreatedDate AS OrderDate,
    o.[Status],
    SUM(od.Qty) AS TotalItems,
    SUM(od.Qty * od.Price) AS TotalAmount
FROM
    OrderDetail od
INNER JOIN
    [Order] o ON od.OrderId = o.Id
INNER JOIN 
    SystemUsers u ON u.Id = o.WaiterId
GROUP BY
    o.Id,
    o.BillNo,
    o.[Status],
    o.TableNo,
    o.TableSection,
    o.CreatedDate,
    u.[Name];
