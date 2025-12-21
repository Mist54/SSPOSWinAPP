using System;
using System.Data;
using System.Data.SqlClient;

namespace SSPOS.DLL
{
    public partial class SystemUsersData
    {
        public static int Create(string name, string password, string email, string company, int role, bool isActive,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, bool isDeleted)
        {
            int returnValue;

            using (SqlCommand cmd = new SqlCommand("SystemUsers_Create"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Company", company);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@IsDeleted", isDeleted);

                cmd.Parameters.AddWithValue("@CreatedDate", createdDate == null ? (object)DBNull.Value : createdDate);
                cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                cmd.Parameters.AddWithValue("@ModifiedDate", modifiedDate == null ? (object)DBNull.Value : modifiedDate);
                cmd.Parameters.AddWithValue("@ModifiedBy", modifiedBy);

                returnValue = DataAccess.RunCmdOutput_int(cmd);

            }

            return returnValue;
        }

        public static DataTable RetrieveAll(string SearchTerm)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("SystemUsers_ReadAll"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                if (SearchTerm != "")
                {
                    cmd.Parameters.AddWithValue("@SearchTerm", SearchTerm);
                }
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public static DataTable RetrieveById(int Id)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("SystemUsers_ReadById"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public static bool Update(int userId, string name, string password, string email, string company, int role, bool isActive,
                           string modifiedBy, DateTime? modifiedDate, bool isDeleted)
        {
            bool result = false;

            using (SqlCommand cmd = new SqlCommand("SystemUsers_Update"))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Adding parameters to the command
                cmd.Parameters.AddWithValue("@Id", userId); // Add userId as a parameter for identification
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Company", company);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@IsDeleted", isDeleted);
                cmd.Parameters.AddWithValue("@ModifiedBy", modifiedBy);
                cmd.Parameters.AddWithValue("@ModifiedDate", modifiedDate);

                // Output parameter for affected rows
                SqlParameter returnParameter = new SqlParameter("@rowsAffected", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(returnParameter);

                // Execute the command and get the data reader
                using (SqlDataReader reader = DataAccess.RunCMDGetDataReader(cmd))
                {
                    // Check the rows affected
                    if (returnParameter.Value != DBNull.Value && (int)returnParameter.Value > 0)
                    {
                        result = true;
                    }
                }
            }

            return result;
        }



        public static DataTable RetrieveByUserName(string UserName)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("SystemUsers_ReadByUserName"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                DataSet dr = DataAccess.RunCMDGetDataSet(cmd);
                dt = dr.Tables[0];
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            } //close using statement 

            return dt;
        }


        public static DataTable RetrieveByUserRole(int Role)
        {
            DataTable dt = null;

            // Ensure that the connection is open and properly handled by the DataAccess method
            using (SqlCommand cmd = new SqlCommand("SystemUsers_ReadByUserRole"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Role", Role); // Adding parameter for Role

                // Execute the command and fetch the result into a DataSet
                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);

                // Ensure the DataSet has at least one table before accessing it
                if (ds.Tables.Count > 0)
                {
                    dt = ds.Tables[0];
                }
            }

            return dt;
        }

    }

}

