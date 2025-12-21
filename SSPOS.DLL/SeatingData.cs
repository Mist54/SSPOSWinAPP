using System.Data;
using System.Data.SqlClient;
namespace SSPOS.DLL
{
    public class SeatingData
    {
        public static DataTable RetrieveByID(int id)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Seating_ReadByID"))
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

        public static DataTable RetrieveByTableName(string TableName)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Seating_ReadByTableNumber"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TableNumber ", TableName);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public static DataTable RetrieveAll()
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Seating_ReadAll"))
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


    }
}
