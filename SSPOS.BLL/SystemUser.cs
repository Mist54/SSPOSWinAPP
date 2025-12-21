using SSPOS.DLL;
using System;
using System.Collections.Generic;
using System.Data;

namespace SSPOS.BLL
{
    public class SystemUser
    {

        #region Fields

        private int _id;
        private string _name;
        private string _password;
        private string _email;
        private string _company;
        private int _role;
        private bool _isActive;
        private string _createdBy;
        private DateTime _createdDate;
        private string _modifiedBy;
        private DateTime? _modifiedDate;  // Nullable because it may not always have a value
        private bool _isDeleted;

        #endregion //Fields


        #region Props
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Company { get { return _company; } set { _company = value; } }
        public int Role { get { return _role; } set { _role = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string CreatedBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime CreatedDate { get { return _createdDate; } set { _createdDate = value; } }
        public string ModifiedBy { get { return _modifiedBy; } set { _modifiedBy = value; } }
        public DateTime? ModifiedDate { get { return _modifiedDate; } set { _modifiedDate = value; } }
        public bool IsDeleted { get { return _isDeleted; } set { _isDeleted = value; } }
       
        
        #endregion //Props


        #region CTOR
        public SystemUser()
        {
            // Initialize default values if needed
            _id = 0;
            _name = string.Empty;
            _password = string.Empty;
            _email = string.Empty;
            _company = string.Empty;
            _role = 0;
            _isActive = true;
            _createdBy = string.Empty;
            _createdDate = DateTime.Now;
            _modifiedBy = string.Empty;
            _modifiedDate = null;
            _isDeleted = false;

            
        }




        public SystemUser(int id, string name, string password, string email, string company, int role, bool isActive,
            string createdBy, DateTime createdDate, string modifiedBy, DateTime? modifiedDate, bool isDeleted)
        {
            _id = id;
            _name = name;
            _password = password;
            _email = email;
            _company = company;
            _role = role;
            _isActive = isActive;
            _createdBy = createdBy;
            _createdDate = createdDate;
            _modifiedBy = modifiedBy;
            _modifiedDate = modifiedDate;
            _isDeleted = isDeleted;

           
        }
        #endregion CTOR


        public static SystemUser RetrieveByUserName(string userName)
        {
            SystemUser result = null;
            try
            {
                // Retrieve data from the database
                DataTable dt = SystemUsersData.RetrieveByUserName(userName);

                // Use a DataTableReader in a using block to ensure it's disposed properly
                using (DataTableReader r = dt.CreateDataReader())
                {
                    if (r.Read()) // Read the first record
                    {
                        result = ConvertReaderToObject(r); // Convert reader to object
                    }
                }

                // Dispose the DataTable (using block could be used as well if necessary)
                dt.Dispose();

                return result;
            }
            catch (Exception ex)
            {
                // Use 'throw' to preserve the stack trace
                throw ex;
            }
        }

        public static List<SystemUser> RetrieveByUserRole(int UserRole)
        {
            List<SystemUser> users = new List<SystemUser>();
            try
            {
                // Retrieve the users by role directly (assuming SystemUser.RetrieveByUserRole returns a List<SystemUser>)
                DataTable dt = SystemUsersData.RetrieveByUserRole(UserRole);
                DataTableReader r = dt.CreateDataReader();
                while (r.Read())
                    users.Add(ConvertReaderToObject(r));
                r.Close();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                // You can log the exception here if needed
                throw new Exception("An error occurred while retrieving users by role.", ex);
            }

            return users;
        }


        public static bool Update(int userId, string name, string password, string email, string company, int role,
                                bool isActive, string modifiedBy, DateTime? modifiedDate, bool isDeleted)
        {
            try
            {

                bool res = SystemUsersData.Update(userId, name, password, email, company, role, isActive, modifiedBy, modifiedDate, isDeleted);

                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }


        public static List<SystemUser> RetrieveAll(string searchText)
        {
            List<SystemUser> users = new List<SystemUser>();
            try
            {
                // Retrieve the users by role directly (assuming SystemUser.RetrieveByUserRole returns a List<SystemUser>)
                DataTable dt = SystemUsersData.RetrieveAll(searchText);
                DataTableReader r = dt.CreateDataReader();
                while (r.Read())
                    users.Add(ConvertReaderToObject(r));
                r.Close();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                // You can log the exception here if needed
                throw new Exception("An error occurred while retrieving users by role.", ex);
            }

            return users;
        }

        private string getRole(int role)
        {
            if (role == 0)
                return "SuperUser";
            else if (role == 1)
                return "SystemAdmin";
            else if (role == 2)
                return "Manager";
            else if (role == 3)
                return "Waiter";
            else
                return "Unknown";
        }

        private static SystemUser ConvertReaderToObject(DataTableReader r)
        {
            SystemUser user = new SystemUser();

            // Map each column from DataTableReader to the SystemUser object
            user.Id = r["Id"] != DBNull.Value ? Convert.ToInt32(r["Id"]) : 0;
            user.Name = r["Name"] != DBNull.Value ? r["Name"].ToString() : string.Empty;
            user.Password = r["Password"] != DBNull.Value ? r["Password"].ToString() : string.Empty;
            user.Email = r["Email"] != DBNull.Value ? r["Email"].ToString() : string.Empty;
            user.Company = r["Company"] != DBNull.Value ? r["Company"].ToString() : string.Empty;
            user.Role = r["Role"] != DBNull.Value ? Convert.ToInt32(r["Role"]) : 0;
            user.IsActive = r["IsActive"] != DBNull.Value && Convert.ToBoolean(r["IsActive"]);
            user.CreatedBy = r["CreatedBy"] != DBNull.Value ? r["CreatedBy"].ToString() : string.Empty;
            user.CreatedDate = r["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(r["CreatedDate"]) : DateTime.MinValue;
            user.ModifiedBy = r["ModifiedBy"] != DBNull.Value ? r["ModifiedBy"].ToString() : string.Empty;
            user.ModifiedDate = r["ModifiedDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(r["ModifiedDate"]) : null;
            user.IsDeleted = r["IsDeleted"] != DBNull.Value && Convert.ToBoolean(r["IsDeleted"]);
           
            return user;
        }

    }
}
