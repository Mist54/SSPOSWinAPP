using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSPOS.DLL
{
    public static class CategoryData
    {
        public static DataTable RetrieveByID(int id)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Category_ReadByID"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);

                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        // Retrieve Category by Category name
        public static DataTable RetrieveByCategory(string category)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Category_ReadByCategory"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Category", category);

                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        // Retrieve Category by Subcategory
        public static DataTable RetrieveBySubcategory(string subcategory)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Category_ReadBySubcategory"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Subcategory", subcategory);

                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        // Retrieve Category by UOM
        public static DataTable RetrieveByUOM(string uom)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Category_ReadByUOM"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UOM", uom);

                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public static DataTable RetrieveAll()
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Category_ReadAll"))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }


        public static DataTable RetrieveDistinctCategory()
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Category_ReadDistinctCategory"))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public static DataTable RetrieveDistinctUOMBySubcategory(string subcategory, string category)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Category_ReadDistinctUOMBySubcategory"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Subcategory", subcategory);
                cmd.Parameters.AddWithValue("@Category", category);

                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public static DataTable RetrieveDistinctSubcategoryByCategory(string category)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Category_ReadDistinctSubcategoryByCategory"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Category", category);

                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }

        public static DataTable RetrieveID(string category, string subcategory, string uOM)
        {
            DataTable dt = null;

            using (SqlCommand cmd = new SqlCommand("Category_ReadID"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Subcategory", subcategory);
                cmd.Parameters.AddWithValue("@UOM", uOM);
                DataSet ds = DataAccess.RunCMDGetDataSet(cmd);
                dt = ds.Tables[0];

                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }

            return dt;
        }



    }
}
