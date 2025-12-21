using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SSPOS.DLL
{
    public static class OrderData
    {
        public static int Create(string billNo, int tableNo, string tableSection, int waiterId, string priceSection, string status, string createdBy)
        {
            int returnValue;

            using (SqlCommand cmd = new SqlCommand("Order_Create"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BillNo", billNo);
                cmd.Parameters.AddWithValue("@TableNo", tableNo);
                cmd.Parameters.AddWithValue("@TableSection", tableSection);
                cmd.Parameters.AddWithValue("@WaiterId", waiterId);
                cmd.Parameters.AddWithValue("@PriceSection", priceSection);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                // Add the output parameter for row count
                SqlParameter rowCountParam = new SqlParameter("@NewRowId", SqlDbType.Int);
                rowCountParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(rowCountParam);

                // Execute the stored procedure and get the row count value
                DataAccess.RunCmdOutput_int(cmd);

                returnValue = Convert.ToInt32(rowCountParam.Value); // Get the value of the output parameter
            }

            return returnValue;
        }


        public static DataTable RetrieveAll()
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Order_ReadAll"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public static DataTable RetrieveByID(int id)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Order_ReadByID"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }


        public static DataTable RetrieveByTableAndPosition(int TableId, String TablePosition, string status = null)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Order_GetByTableAndPosition"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableNo", TableId);
                cmd.Parameters.AddWithValue("@TableSection", TablePosition);
                if(status != null)
                {
                    cmd.Parameters.AddWithValue("@status", status);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@status", DBNull.Value);
                }
               
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }


        public static int Update(int id, string billNo, int tableNo, string tableSection, int waiterId, string priceSection, string status, string updatedBy)
        {
            int returnValue = 0;

            using (SqlCommand cmd = new SqlCommand("Order_Update"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@BillNo", billNo);
                cmd.Parameters.AddWithValue("@TableNo", tableNo);
                cmd.Parameters.AddWithValue("@TableSection", tableSection);
                cmd.Parameters.AddWithValue("@WaiterId", waiterId);
                cmd.Parameters.AddWithValue("@PriceSection", priceSection);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@UpdatedBy", updatedBy);

                SqlParameter rowsAffectedParam = new SqlParameter("@RowsAffected", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(rowsAffectedParam);

                returnValue = DataAccess.RunCmdOutput_int(cmd);
            }

            return returnValue;
        }

        public static bool Delete(int id)
        {
            using (SqlCommand cmd = new SqlCommand("Order_Delete"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);

                return DataAccess.RunActionCmdReturnBool(cmd);
            }
        }

        public static bool UpdateOrderStatus(int orderId, string orderStatus)
        {
           
            using (SqlCommand cmd = new SqlCommand("Order_OrderUpdateOrderStatus"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderId", orderId);
                cmd.Parameters.AddWithValue("@status", orderStatus);
                return DataAccess.RunActionCmdReturnBool(cmd);
            }
        }
    }
}
    