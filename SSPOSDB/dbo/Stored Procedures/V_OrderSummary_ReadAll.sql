-- 1. Procedure to read all records
CREATE PROCEDURE [dbo].[V_OrderSummary_ReadAll]
AS
BEGIN
   SELECT  [OrderID]
      ,[BillNo]
      ,[TableNo]
      ,[TableSection]
      ,[Waiter]
      ,[OrderDate]
      ,[Status]
      ,[TotalItems]
      ,[TotalAmount]
  FROM [SSPOS].[dbo].[V_OrderSummary]

END;
