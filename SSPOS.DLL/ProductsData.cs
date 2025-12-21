using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPOS.DLL
{
    public static class ProductsData
    {
        public static int Create(string productName, int? code, decimal? mrp, int? categoryId,
                          decimal? regularPrice, decimal? directPrice, decimal? outsidePrice,
                          string createdBy)
        {
            int returnValue;

            using (SqlCommand cmd = new SqlCommand("Product_Create"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Code", (object)code ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MRP", (object)mrp ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CategoryID", (object)categoryId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegularPrice", (object)regularPrice ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DirectPrice", (object)directPrice ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@OutsidePrice", (object)outsidePrice ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                returnValue = DataAccess.RunCmdOutput_int(cmd);
            }
            return returnValue;
        }

        public static DataTable RetrieveAll()
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Product_ReadAll"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            } //close using statement

            return dt;
        }

        public static DataTable RetrieveByCode(int code)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Product_ReadByCode"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Code", code);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            } //close using statement

            return dt;
        }

        public static DataTable RetrieveByID(int id)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Product_ReadByID"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            } //close using statement

            return dt;
        }

        public static DataTable RetrieveByProductName(string productname)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Product_ReadByProductName"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", productname);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            } //close using statement

            return dt;
        }

        public static int Update(int id, string productName, int? code, decimal? mrp, int? categoryId, decimal? regularPrice,
                        decimal? directPrice, decimal? outsidePrice, string modifiedBy)
        {
            int returnValue = 0;
            using (SqlCommand cmd = new SqlCommand("Product_Update"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                cmd.Parameters.AddWithValue("@Code", (object)code ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MRP", (object)mrp ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CategoryID", (object)categoryId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegularPrice", (object)regularPrice ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DirectPrice", (object)directPrice ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@OutsidePrice", (object)outsidePrice ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ModifiedBy", modifiedBy);

                SqlParameter rowsAffectedParam = new SqlParameter("@RowsAffected", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(rowsAffectedParam);
                return returnValue = DataAccess.RunCmdOutput_int(cmd);
            }
        }

        public static int UpdateCodeAndPrice(int id, int? code, decimal? mrp, decimal? regularPrice,
                                     decimal? directPrice, decimal? outsidePrice, string modifiedby)
        {
            int returnValue;

            using (SqlCommand cmd = new SqlCommand("Product_UpdateCodeAndPrice"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Code", (object)code ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@MRP", (object)mrp ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@RegularPrice", (object)regularPrice ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DirectPrice", (object)directPrice ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@OutsidePrice", (object)outsidePrice ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@ModifiedBy", modifiedby);

                // Define output parameter for row count
                SqlParameter returnParam = new SqlParameter("@ReturnValue", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(returnParam);

                // Execute the command and fetch the output parameter
                DataAccess.RunCmdOutput_int(cmd);
                returnValue = (int)(returnParam.Value ?? 0); // Retrieve the output parameter value
            }

            return returnValue;
        }

        public static bool DeleteProductById(int id)
        {
            using (SqlCommand cmd = new SqlCommand("Product_Delete"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);

                // Call the RunActionCmdReturnBool method to execute the command and get the result
                return DataAccess.RunActionCmdReturnBool(cmd);
            }
        }
    }

}

