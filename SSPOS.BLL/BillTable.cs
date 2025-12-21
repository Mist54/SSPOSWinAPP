using SSPOS.DLL;
using System;
using System.Collections.Generic;
using System.Data;

namespace SSPOS.BLL
{
    public class BillTable
    {
        #region PROPERTIES

        public int OrderID { get; set; }
        public string BillNo { get; set; } = string.Empty;
        // Computed property to ensure FullTableName is always up-to-date
        public string FullTableName => $"{TableNo}-{(TableSection ?? "").Trim()}";
        public int TableNo { get; set; }
        public string TableSection { get; set; } = string.Empty;
        public string Waiter { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = string.Empty;
        public int TotalItems { get; set; }
        public decimal TotalAmount { get; set; }

        

        #endregion

        #region CONSTRUCTORS

        public BillTable() { }

        public BillTable(int orderID, string billNo, int tableNo, string tableSection, string waiter, DateTime orderDate, string status, int totalItems, decimal totalAmount)
        {
            OrderID = orderID;
            BillNo = billNo;
            TableNo = tableNo;
            TableSection = tableSection;
            Waiter = waiter;
            OrderDate = orderDate;
            Status = status;
            TotalItems = totalItems;
            TotalAmount = totalAmount;
        }

        #endregion

        #region CRUD OPERATIONS

        public static List<BillTable> RetrieveAll()
        {
            List<BillTable> tableList = new List<BillTable>();

            try
            {
                DataTable dt = BillTableData.RetrieveAll();
                using (DataTableReader r = dt.CreateDataReader())
                {
                    while (r.Read())
                    {
                        tableList.Add(ConvertReaderToTableList(r));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving BillTable data: {ex.Message}");
            }

            return tableList;
        }

        #endregion

        #region OBJECT MAPPING

        private static BillTable ConvertReaderToTableList(DataTableReader reader)
        {
            return new BillTable
            {
                OrderID = reader["OrderID"] != DBNull.Value ? Convert.ToInt32(reader["OrderID"]) : 0,
                BillNo = reader["BillNo"] != DBNull.Value ? reader["BillNo"].ToString() : string.Empty,
                TableNo = reader["TableNo"] != DBNull.Value ? Convert.ToInt32(reader["TableNo"]) : 0,
                TableSection = reader["TableSection"] != DBNull.Value ? reader["TableSection"].ToString() : string.Empty,
                Waiter = reader["Waiter"] != DBNull.Value ? reader["Waiter"].ToString() : string.Empty,
                OrderDate = reader["OrderDate"] != DBNull.Value ? Convert.ToDateTime(reader["OrderDate"]) : DateTime.MinValue,
                Status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : string.Empty,
                TotalItems = reader["TotalItems"] != DBNull.Value ? Convert.ToInt32(reader["TotalItems"]) : 0,
                TotalAmount = reader["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(reader["TotalAmount"]) : 0m
            };
        }

        #endregion
    }
}
