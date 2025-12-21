using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSPOS.DLL;

/// \namespace SSPOS.BLL
/// \brief Contains the business logic classes for the SSPOS application.
namespace SSPOS.BLL
{
    /// \brief Represents a category in the SSPOS system.
    /// \details The Category class encapsulates the properties and methods
    /// related to categories, such as retrieval by subcategory, UOM, or ID.
    public class Category
    {
        #region Fields

        /// /brief private field section  _id, _category, _subcategory, _uom
        /// /remarks Private field section are refered in the Properties 
        private int _id;
        private string _category;
        private string _subcategory;
        private string _uom;

        #endregion

        #region Properties

        /// \brief Properties section id, category, subcategory, uom
        public int Id { get => _id; set => _id = value; }
        public string CategoryName { get => _category; set => _category = value; }
        public string Subcategory { get => _subcategory; set => _subcategory = value; }
        public string UOM { get => _uom; set => _uom = value; }

        #endregion

        #region Constructors

        // Default constructor
        public Category()
        {
            _id = 0;
            _category = string.Empty;
            _subcategory = string.Empty;
            _uom = string.Empty;
        }

        // Parameterized constructor
        public Category(int id, string category, string subcategory, string uom)
        {
            _id = id;
            _category = category;
            _subcategory = subcategory;
            _uom = uom;
        }

        #endregion

        #region CRUD


        /// \brief Catogory RetriveById Function retrieves catogory using ID
        /// \param int id
        /// \returns Catogory object
        public static Category RetrieveByID(int id)
        {
            Category result = null;
            try
            {
                DataTable dt = CategoryData.RetrieveByID(id);

                using (DataTableReader reader = dt.CreateDataReader())
                {
                    if (reader.Read())
                    {
                        result = Category.ConvertReaderToObject(reader);
                    }
                }

                dt.Dispose();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// \brief Retrieves the List of catogory 
        /// \return List of catogory objects 
        /// \remarks parmeter should be mentioned as true or false to get distinct catogoryList or not
        /// \param boolean distinctCategory 
        /// 
        /// \code 
        ///  category.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0;
        /// \endcode
        public static List<Category> RetrieveAll(bool distinctCategory)
        {
            List<Category> results = new List<Category>();

            DataTable dt;
            if (!distinctCategory)
            {
                dt = CategoryData.RetrieveAll();
            }
            else
            {
                dt = CategoryData.RetrieveDistinctCategory();
            }

            using (DataTableReader reader = dt.CreateDataReader())
            {
                while (reader.Read())
                {
                    results.Add(ConvertReaderToObject(reader));
                }
            }

            return results;
        }






        /// \brief Method to retrieve categories by Subcategory.
        /// \details Retrieves a list of Category objects filtered by the specified subcategory.
        /// \param subcategory The name of the subcategory to filter categories.
        /// \param distinctUOM A boolean indicating whether to retrieve distinct Unit of Measure (UOM).
        /// \return A list of Category objects matching the criteria.
        public static List<Category> RetrieveByCategory(string category, bool distinctsubcategory)
        {
            List<Category> results = new List<Category>();
            try
            {
                DataTable dt;
                if (!distinctsubcategory)
                {
                    dt = CategoryData.RetrieveByCategory(category);
                }
                else
                {
                    dt = CategoryData.RetrieveDistinctSubcategoryByCategory(category);
                }


                using (DataTableReader reader = dt.CreateDataReader())
                {
                    while (reader.Read())
                    {
                        results.Add(Category.ConvertReaderToObject(reader));
                    }
                }

                dt.Dispose();
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// \brief Method to retrieve categories by Subcategory.
        /// \details Retrieves a list of Category objects filtered by the specified subcategory.
        /// \param subcategory The name of the subcategory to filter categories.
        /// \param distinctUOM A boolean indicating whether to retrieve distinct Unit of Measure (UOM).
        /// \return A list of Category objects matching the criteria.
        public static List<Category> RetrieveBySubcategory(string subcategory, string category, bool distinctUOM)
        {
            List<Category> results = new List<Category>();
            try
            {
                DataTable dt;
                if (!distinctUOM)
                {
                    dt = CategoryData.RetrieveBySubcategory(subcategory);
                }
                else
                {
                    dt = CategoryData.RetrieveDistinctUOMBySubcategory(subcategory,category);
                }


                using (DataTableReader reader = dt.CreateDataReader())
                {
                    while (reader.Read())
                    {
                        results.Add(Category.ConvertReaderToObject(reader));
                    }
                }

                dt.Dispose();
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// \brief Method to retrieve categories by Unit of Measure (UOM).
        /// \details Retrieves a list of Category objects filtered by the specified UOM.
        /// \param uom The Unit of Measure to filter categories.
        /// \return A list of Category objects matching the criteria.
        public static List<Category> RetrieveByUOM(string uom)
        {
            List<Category> results = new List<Category>();
            try
            {
                DataTable dt = CategoryData.RetrieveByUOM(uom);

                using (DataTableReader reader = dt.CreateDataReader())
                {
                    while (reader.Read())
                    {
                        results.Add(Category.ConvertReaderToObject(reader));
                    }
                }

                dt.Dispose();
                return results;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// \brief Method to retrieve the ID based on category, subcategory, and UOM.
        /// 
        /// \details Retrieves the ID for a Category object filtered by category name, subcategory, and UOM.
        /// 
        /// \param category The name of the category.
        /// \param subcategory The name of the subcategory.
        /// \param uom The Unit of Measure.
        /// \return The ID of the Category object if found; otherwise, null.
        public static int? RetrieveID(string category, string subcategory, string uom)
        {
            int? result = null; // Use nullable int to handle cases where no ID is found
            try
            {
                DataTable dt = CategoryData.RetrieveID(category, subcategory, uom);

                using (DataTableReader reader = dt.CreateDataReader())
                {
                    if (reader.Read())
                    {
                        // Get the "ID" value directly from the DataTableReader
                        result = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : (int?)null;
                    }
                }

                dt.Dispose();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Methods

       /// \brief Converts the data reader object to the class object 
       /// \param Datatable reader
       /// \remark This function is used in every CRUD operation
        public static Category ConvertReaderToObject(DataTableReader reader)
        {
            Category category = new Category();

            if (reader.HasRows)
            {
                // Assign values from the reader to the fields in the Category object
                category.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0;
                category.CategoryName = reader["Category"] != DBNull.Value ? reader["Category"].ToString() : string.Empty;
                category.Subcategory = reader["Subcategory"] != DBNull.Value ? reader["Subcategory"].ToString() : string.Empty;
                category.UOM = reader["UOM"] != DBNull.Value ? reader["UOM"].ToString() : string.Empty;
            }

            return category;
        }
        #endregion
    }
}
