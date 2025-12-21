using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSPOS.DLL;

namespace SSPOS.BLL
{
    public class Seating
    {
        private int _Id;
        private string _TableName;
        private int _Capacity;
        private bool _IsReserved;
        private DateTime? _ReservationTime;
        private string _Status;
        private string _CreatedBy;
        private DateTime _CreatedDate;
        private string _UpdatedBy;
        private DateTime _UpdatedDate;
        private bool _IsDeleted;


        // Properties
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string TableName
        {
            get { return _TableName; }
            set { _TableName = value; }
        }

        public int Capacity
        {
            get { return _Capacity; }
            set { _Capacity = value; }
        }

        public bool IsReserved
        {
            get { return _IsReserved; }
            set { _IsReserved = value; }
        }

        public DateTime? ReservationTime
        {
            get { return _ReservationTime; }
            set { _ReservationTime = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        public DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }

        public string UpdatedBy
        {
            get { return _UpdatedBy; }
            set { _UpdatedBy = value; }
        }

        public DateTime UpdatedDate
        {
            get { return _UpdatedDate; }
            set { _UpdatedDate = value; }
        }

        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
        }


        // Default Constructor
        public Seating()
        {
            _Id = 0;
            _TableName = string.Empty;
            _Capacity = 0;
            _IsReserved = false;
            _ReservationTime = null;
            _Status = "Available";
            _CreatedBy = string.Empty;
            _CreatedDate = DateTime.Now;
            _UpdatedBy = string.Empty;
            _UpdatedDate = DateTime.Now;
            _IsDeleted = false;
        }

        // Parameterized Constructor
        public Seating(int id, string tableName, int capacity, bool isReserved, 
            DateTime? reservationTime, string status, string createdBy, DateTime createdDate, 
            string updatedBy, DateTime updatedDate, bool isDeleted)
        {
            _Id = id;
            _TableName = tableName;
            _Capacity = capacity;
            _IsReserved = isReserved;
            _ReservationTime = reservationTime;
            _Status = status;
            _CreatedBy = createdBy;
            _CreatedDate = createdDate;
            _UpdatedBy = updatedBy;
            _UpdatedDate = updatedDate;
            _IsDeleted = isDeleted;
        }




        public static List<Seating> RetrieveAll()
        {
            List<Seating> TableList = new List<Seating>();

            try
            {
                DataTable dt = SeatingData.RetrieveAll();
                DataTableReader r = dt.CreateDataReader();
                while (r.Read())
                    TableList.Add(ConvertReaderToObject(r));
                r.Close();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return TableList;
        }


        public static Seating RetrieveByID(int id)
        {
            Seating result = null;
            try
            {
                DataTable dt = SeatingData.RetrieveByID(id);
                using (DataTableReader r = dt.CreateDataReader())
                {
                    if (r.Read())
                    {
                        result = ConvertReaderToObject(r);
                    }
                }
                dt.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }


        public static Seating RetrieveByTableName(string TableName)
        {
            Seating result = null;
            try
            {
                DataTable dt = SeatingData.RetrieveByTableName(TableName);
                using (DataTableReader r = dt.CreateDataReader())
                {
                    if (r.Read())
                    {
                        result = ConvertReaderToObject(r);
                    }
                }
                dt.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        private static Seating ConvertReaderToObject(DataTableReader reader)
        {
            Seating seating = new Seating();

            try
            {
                seating.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0;
                seating.TableName = reader["TableNumber"] != DBNull.Value ? reader["TableNumber"].ToString() : string.Empty;
                seating.Capacity = reader["Capacity"] != DBNull.Value ? Convert.ToInt32(reader["Capacity"]) : 0;
                seating.IsReserved = reader["IsReserved"] != DBNull.Value ? Convert.ToBoolean(reader["IsReserved"]) : false;
                seating.ReservationTime = reader["ReservationTime"] != DBNull.Value ? Convert.ToDateTime(reader["ReservationTime"]) : (DateTime?)null;
                seating.Status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : "Available";
                seating.CreatedBy = reader["CreatedBy"] != DBNull.Value ? reader["CreatedBy"].ToString() : string.Empty;
                seating.CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : DateTime.MinValue;
                seating.UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? reader["UpdatedBy"].ToString() : string.Empty;
                seating.UpdatedDate = reader["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["UpdatedDate"]) : DateTime.MinValue;
                seating.IsDeleted = reader["IsDeleted"] != DBNull.Value ? Convert.ToBoolean(reader["IsDeleted"]) : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading seating data: {ex.Message}");
            }

            return seating;
        }

    }
}