using System;
using System.Collections.Generic;
using System.Data;
using SSPOS.DLL;

namespace SSPOS.BLL
{
    public class Report
    {
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string UOM { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public decimal TotalAmount { get; set; }

        // Constructor
        public Report(string categoryName, string subCategoryName, string uom, string productName, int qty, decimal totalAmount)
        {
            CategoryName = categoryName;
            SubCategoryName = subCategoryName;
            UOM = uom;
            Qty = qty;
            TotalAmount = totalAmount;
            ProductName = productName;
        }

     

        // Retrieve Sales Report (Business Logic Layer)
        public static List<Report> GetSalesReport(string category = null, string subcategory = null, string uom = null)
        {
            List<Report> reportList = new List<Report>();
            try
            {
                DataTable dt = ReportData.GetSalesReport(category, subcategory, uom); // Calls Data Layer
                DataTableReader reader = dt.CreateDataReader();

                while (reader.Read())
                {
                    reportList.Add(ConvertReaderToObject(reader));
                }

                reader.Close();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving sales report", ex);
            }

            return reportList;
        }

        public static bool Order_AccountCloser()
        {
            bool result = false;
            result = ReportData.Order_AccountCloser();
            return result;
        }


        // Convert DataReader to Report Object
        private static Report ConvertReaderToObject(IDataReader reader)
        {
            return new Report(
                reader["CategoryName"] as string,
                reader["Subcategory"] as string,
                reader["UOM"] as string,
                reader["ProductName"] as string,
                reader["TotalQty"] != DBNull.Value ? Convert.ToInt32(reader["TotalQty"]) : 0,
                reader["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(reader["TotalAmount"]) : 0
            );
        }

        

    }
}
