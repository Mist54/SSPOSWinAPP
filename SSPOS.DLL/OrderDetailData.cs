using System;
using System.Data;
using System.Data.SqlClient;

namespace SSPOS.DLL
{
    public static class OrderDetailData
    {
        public static int Create(int orderId, int productId, decimal price, int qty, string status, string createdBy)
        {
            int returnValue;

            using (SqlCommand cmd = new SqlCommand("OrderDetail_Create"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Qty", qty);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                // Add the output parameter for row count
                SqlParameter rowCountParam = new SqlParameter("@RowCount", SqlDbType.Int);
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
            DataTable dt;

            using (SqlCommand cmd = new SqlCommand("OrderDetail_ReadAll"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];
            }

            return dt;
        }

        public static DataTable RetrieveByID(int id)
        {
            DataTable dt;

            using (SqlCommand cmd = new SqlCommand("OrderDetail_ReadByID"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];
            }

            return dt;
        }

        public static DataTable RetrieveByOrderID(int OrderId)
        {
            DataTable dt;

            using (SqlCommand cmd = new SqlCommand("OrderDetail_ReadByOrderId"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@OrderId", OrderId);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];
            }

            return dt;
        }

        public static int Update(int id, int orderId, int productId, decimal price, int qty, string status, string updatedBy)
        {
            int returnValue;

            using (SqlCommand cmd = new SqlCommand("OrderDetail_Update"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Qty", qty);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@UpdatedBy", updatedBy);

                // Add the output parameter for RowsAffected
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
            using (SqlCommand cmd = new SqlCommand("OrderDetail_Delete"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);

                return DataAccess.RunActionCmdReturnBool(cmd);
            }
        }

        public static bool DeletePermanently(int TableId, String TablePosition, int ProductCode)
        {
            using (SqlCommand cmd = new SqlCommand("OrderDetail_DeletePermanently"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableId", TableId);
                cmd.Parameters.AddWithValue("@TablePosition", TablePosition);
                cmd.Parameters.AddWithValue("@ProductCode", ProductCode);

                return DataAccess.RunActionCmdReturnBool(cmd);
            }
        }

        public static DataTable ReadAllOrderdItems(string TableNo, int WaiterId)
        {
            DataTable dt;

            using (SqlCommand cmd = new SqlCommand("OrderDetail_GetOrderDetails"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableNo", TableNo);
                cmd.Parameters.AddWithValue("@WaiterId", WaiterId);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];
            }

            return dt;
        }

        public static DataTable ReadAllOrderdItems()
        {
            DataTable dt;

            using (SqlCommand cmd = new SqlCommand("OrderDetail_GetOrderDetails"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];
            }

            return dt;
        }

        public static DataTable ReadAllOrderedItems(int? tableNo = null, int? waiterId = null, string tablePosition = null, string status = null)
        {
            DataTable dt;

            using (SqlCommand cmd = new SqlCommand("OrderDetail_GetOrderDetails"))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Add optional parameters only if they are provided
                if (tableNo.HasValue)
                    cmd.Parameters.AddWithValue("@TableNo", tableNo.Value);
                else
                    cmd.Parameters.AddWithValue("@TableNo", DBNull.Value);

                if (waiterId.HasValue)
                    cmd.Parameters.AddWithValue("@WaiterId", waiterId.Value);
                else
                    cmd.Parameters.AddWithValue("@WaiterId", DBNull.Value);

                cmd.Parameters.AddWithValue("@TablePosition", tablePosition ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);

                // Execute the command and get the data
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];
            }

            return dt;
        }

    }
}
