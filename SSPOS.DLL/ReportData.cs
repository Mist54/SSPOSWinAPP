using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPOS.DLL
{
    public class ReportData
    {
        public static DataTable GetSalesReport(string category = null, string subcategory = null, string uom = null)
        {
            DataTable dt = new DataTable();

            using (SqlCommand cmd = new SqlCommand("Category_AnalysisReport"))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters and handle NULL values
                cmd.Parameters.AddWithValue("@Category", (object)category ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Subcategory", (object)subcategory ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@UOM", (object)uom ?? DBNull.Value);

                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public static bool Order_AccountCloser()
        {
            using (SqlCommand cmd = new SqlCommand("Order_AccountCloser"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                return DataAccess.RunActionCmdReturnBool(cmd);
            }
        }

    }
}
