using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSPOS.DLL;

namespace SSPOS.BLL
{
    public class Product
    {
        #region Fields

        // Product table fields
        private int _id;
        private string _productName;
        private int? _code;
        private decimal? _mrp;
        private int? _categoryId;
        private decimal? _regularPrice;
        private decimal? _directPrice;
        private decimal? _outsidePrice;
        private string _createdBy;
        private DateTime _createdDate;
        private string _modifiedBy;
        private DateTime _modifiedDate;
       

        // Category table fields
        private string _categoryName;
        private string _subcategory;
        private string _uom; // Unit of Measure from Category table

        #endregion

        #region Properties

        public int Id { get => _id; set => _id = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public int? Code { get => _code; set => _code = value; }
        public decimal? MRP { get => _mrp; set => _mrp = value; }
        public int? CategoryId { get => _categoryId; set => _categoryId = value; }
        public decimal? RegularPrice { get => _regularPrice; set => _regularPrice = value; }
        public decimal? DirectPrice { get => _directPrice; set => _directPrice = value; }
        public decimal? OutsidePrice { get => _outsidePrice; set => _outsidePrice = value; }
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
        public string ModifiedBy { get => _modifiedBy; set => _modifiedBy = value; }
        public DateTime ModifiedDate { get => _modifiedDate; set => _modifiedDate = value; }
        // Category table properties
        public string CategoryName { get => _categoryName; set => _categoryName = value; }
        public string Subcategory { get => _subcategory; set => _subcategory = value; }
        public string UOM { get => _uom; set => _uom = value; }
        #endregion


        #region CTOR

        public Product()
        {
            _id = 0;
            _productName = string.Empty;
            _code = null;
            _mrp = null;
            _categoryId = null;
            _regularPrice = null;
            _directPrice = null;
            _outsidePrice = null;
            _createdBy = string.Empty;
            _createdDate = DateTime.MinValue;
            _modifiedBy = string.Empty;
            _modifiedDate = DateTime.MinValue;
            _categoryName = string.Empty;
            _subcategory = string.Empty;
            _uom = string.Empty;
        }

        // Parameterized constructor
        public Product(int id, string productName, int? code, decimal? mrp, int? categoryId, decimal? regularPrice,
                       decimal? directPrice, decimal? outsidePrice, string createdBy, DateTime createdDate,
                       string modifiedBy, DateTime modifiedDate, bool? isDeleted, string categoryName,
                       string subcategory, string uom)
        {
            _id = id;
            _productName = productName;
            _code = code;
            _mrp = mrp;
            _categoryId = categoryId;
            _regularPrice = regularPrice;
            _directPrice = directPrice;
            _outsidePrice = outsidePrice;
            _createdBy = createdBy;
            _createdDate = createdDate;
            _modifiedBy = modifiedBy;
            _modifiedDate = modifiedDate;
            _categoryName = categoryName;
            _subcategory = subcategory;
            _uom = uom;
        }
        #endregion

        #region CRUD

        public static int Create(string productName, int? code, decimal? mrp, int? categoryId,
                          decimal? regularPrice, decimal? directPrice, decimal? outsidePrice,
                          string createdBy)
        {
            try
            {
                int res = ProductsData.Create(productName, code, mrp, categoryId, regularPrice, directPrice, 
                    outsidePrice, createdBy);

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Product> RetrieveAll(string usrName)
        {
            List<Product> Productlist = new List<Product>();
            try
            {
                DataTable dt = ProductsData.RetrieveAll();
                DataTableReader r = dt.CreateDataReader();
                while (r.Read())
                    Productlist.Add(ConvertReaderToObject(r));
                r.Close();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                //Activity.Create(usrName, "Location", "RetrieveAll", DateTime.Now, false, "All fields");
                throw ex;
            }

            //Activity.Create(usrName, "Location", "RetrieveAll", DateTime.Now, true, "All Fields");
            return Productlist;
        }

        public static List<Product> RetrieveByProductName(string userName, string productname)
        {
            List<Product> Productlist = new List<Product>();
            try
            {
                DataTable dt = ProductsData.RetrieveByProductName(productname);
                DataTableReader r = dt.CreateDataReader();
                while (r.Read())
                    Productlist.Add(ConvertReaderToObject(r));
                r.Close();
                dt.Dispose();

                return Productlist;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Product RetrieveByID(string userName, int id)
        {
            Product result = null;
            try
            {
                DataTable dt = ProductsData.RetrieveByID(id);

                using (DataTableReader r = dt.CreateDataReader())
                {
                    if (r.Read()) // Read the first record
                    {
                        result = ConvertReaderToObject(r); // Convert reader to object
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
        public static Product RetrieveByCode(string userName, int Code)
        {
            Product result = null;
            try
            {
                DataTable dt = ProductsData.RetrieveByCode(Code);

                using (DataTableReader r = dt.CreateDataReader())
                {
                    if (r.Read()) // Read the first record
                    {
                        result = ConvertReaderToObject(r); // Convert reader to object
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

        public static int Update(int id, string productName, int? code, decimal? mrp, int? categoryId,
                          decimal? regularPrice, decimal? directPrice, decimal? outsidePrice, string modifiedby)
        {
            try
            {
                int res = ProductsData.Update(id, productName, code, mrp, categoryId, regularPrice,
                                                directPrice, outsidePrice, modifiedby);

                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public static int UpdateCodeAndPrice(int id, int? code, decimal? mrp, decimal? regularPrice, decimal? directPrice,
                                            decimal? outsidePrice, string modifiedby)
        {
            try
            {
                int res = ProductsData.UpdateCodeAndPrice(id, code, mrp, regularPrice, directPrice, outsidePrice, modifiedby);

                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public static bool DeleteProductById(string usrName,int id)
        {
            bool res = ProductsData.DeleteProductById(id);
            return res;

        }



        #endregion CRUD

        #region ConvertToObject
        private static Product ConvertReaderToObject(DataTableReader reader)
        {
            Product product = new Product();

            try
            {
                // Ensure reader has rows and is positioned correctly
                if (!reader.HasRows)
                    throw new InvalidOperationException("Reader has no rows.");

                product.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0;
                product.ProductName = reader["ProductName"] != DBNull.Value ? reader["ProductName"].ToString() : string.Empty;
                product.Code = reader["Code"] != DBNull.Value ? (int?)Convert.ToInt32(reader["Code"]) : null;
                product.UOM = reader["UOM"] != DBNull.Value ? reader["UOM"].ToString() : string.Empty;
                product.MRP = reader["MRP"] != DBNull.Value ? (decimal?)Convert.ToDecimal(reader["MRP"]) : null;
                product.CategoryId = reader["CategoryID"] != DBNull.Value ? (int?)Convert.ToInt32(reader["CategoryID"]) : null;
                product.RegularPrice = reader["RegularPrice"] != DBNull.Value ? (decimal?)Convert.ToDecimal(reader["RegularPrice"]) : null;
                product.DirectPrice = reader["DirectPrice"] != DBNull.Value ? (decimal?)Convert.ToDecimal(reader["DirectPrice"]) : null;
                product.OutsidePrice = reader["OutsidePrice"] != DBNull.Value ? (decimal?)Convert.ToDecimal(reader["OutsidePrice"]) : null;
                product.CreatedBy = reader["CreatedBy"] != DBNull.Value ? reader["CreatedBy"].ToString() : string.Empty;
                product.CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : DateTime.MinValue;
                product.ModifiedBy = reader["ModifiedBy"] != DBNull.Value ? reader["ModifiedBy"].ToString() : string.Empty;
                product.ModifiedDate = reader["ModifiedDate"] != DBNull.Value ? Convert.ToDateTime(reader["ModifiedDate"]) : DateTime.MinValue;
                product.CategoryName = reader["CategoryName"] != DBNull.Value ? reader["CategoryName"].ToString() : string.Empty;
                product.Subcategory = reader["Subcategory"] != DBNull.Value ? reader["Subcategory"].ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Error reading product data: {ex.Message}");
            }

            return product;
        }


        #endregion ConvertToObject


    }
}
