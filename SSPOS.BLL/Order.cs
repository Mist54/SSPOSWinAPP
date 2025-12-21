using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SSPOS.DLL;

namespace SSPOS.BLL
{
    public class Order
    {
        #region Fields

        private int _id;
        private string _billNo;
        private int _tableNo;
        private string _tableSection;
        private int _waiterId;
        private string _priceSection;
        private string _status;
        private string _createdBy;
        private DateTime _createdDate;
        private string _updatedBy;
        private DateTime _updatedDate;
        private bool _isDeleted;

        #endregion

        #region Properties

        public int Id { get => _id; set => _id = value; }
        public string BillNo { get => _billNo; set => _billNo = value; }
        public int TableNo { get => _tableNo; set => _tableNo = value; }
        public string TableSection { get => _tableSection; set => _tableSection = value; }
        public int WaiterId { get => _waiterId; set => _waiterId = value; }
        public string PriceSection { get => _priceSection; set => _priceSection = value; }
        public string Status { get => _status; set => _status = value; }
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
        public string UpdatedBy { get => _updatedBy; set => _updatedBy = value; }
        public DateTime UpdatedDate { get => _updatedDate; set => _updatedDate = value; }
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }

        #endregion

        #region Constructors

        public Order()
        {
            // Default constructor
        }

        public Order(int id, string billNo, int tableNo, string tableSection, int waiterId, string priceSection, string status, string createdBy, DateTime createdDate, string updatedBy, DateTime updatedDate, bool isDeleted)
        {
            Id = id;
            BillNo = billNo;
            TableNo = tableNo;
            TableSection = tableSection;
            WaiterId = waiterId;
            PriceSection = priceSection;
            Status = status;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            UpdatedBy = updatedBy;
            UpdatedDate = updatedDate;
            IsDeleted = isDeleted;
        }

        #endregion


        #region CRUD

        public static int Create(string billNo, int tableNo, string tableSection, int waiterId, string priceSection, string status, string createdBy)
        {
            try
            {
                return OrderData.Create(billNo, tableNo, tableSection, waiterId, priceSection, status, createdBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Order> RetrieveAll()
        {
            List<Order> orderList = new List<Order>();
            try
            {
                DataTable dt = OrderData.RetrieveAll();
                DataTableReader r = dt.CreateDataReader();
                while (r.Read())
                    orderList.Add(ConvertReaderToObject(r));
                r.Close();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return orderList;
        }

        public static Order RetrieveByID(int id)
        {
            Order result = null;
            try
            {
                DataTable dt = OrderData.RetrieveByID(id);
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


        public static Order RetrieveByTableAndPosition(int TableId, string TablePosition, string status = null)
        {
            Order result = null;
            try
            {
                DataTable dt = OrderData.RetrieveByTableAndPosition(TableId,TablePosition,status);
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


        public static List<Order> LstRetrieveByTableAndPosition(int TableId, string TablePosition, string status = null)
        {
            List<Order> orderList = new List<Order>();
            try
            {
                DataTable dt = OrderData.RetrieveByTableAndPosition(TableId, TablePosition, status);
                DataTableReader r = dt.CreateDataReader();
                while (r.Read())
                    orderList.Add(ConvertReaderToObject(r));
                r.Close();
                dt.Dispose();
               
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return orderList;
        }


        public static int Update(int id, string billNo, int tableNo, string tableSection, int waiterId, string priceSection, string status, string updatedBy)
        {
            try
            {
                return OrderData.Update(id, billNo, tableNo, tableSection, waiterId, priceSection, status, updatedBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Delete(int id)
        {
            try
            {
                return OrderData.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool UpdateOrderStatus(int orderId, string orderStatus)
        {
            try
            {
                return OrderData.UpdateOrderStatus(orderId, orderStatus);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region ConvertToObject
        private static Order ConvertReaderToObject(DataTableReader reader)
        {
            Order order = new Order();

            try
            {
                order.Id = reader["ID"] != DBNull.Value ? Convert.ToInt32(reader["ID"]) : 0;
                order.BillNo = reader["BillNo"] != DBNull.Value ? reader["BillNo"].ToString() : string.Empty;
                order.TableNo = reader["TableNo"] != DBNull.Value ? Convert.ToInt32(reader["TableNo"]) : 0;
                order.TableSection = reader["TableSection"] != DBNull.Value ? reader["TableSection"].ToString() : string.Empty;
                order.WaiterId = reader["WaiterId"] != DBNull.Value ? Convert.ToInt32(reader["WaiterId"]) : 0;
                order.PriceSection = reader["PriceSection"] != DBNull.Value ? reader["PriceSection"].ToString() : "Regular";
                order.Status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : string.Empty;
                order.CreatedBy = reader["CreatedBy"] != DBNull.Value ? reader["CreatedBy"].ToString() : string.Empty;
                order.CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : DateTime.MinValue;
                order.UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? reader["UpdatedBy"].ToString() : string.Empty;
                order.UpdatedDate = reader["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["UpdatedDate"]) : DateTime.MinValue;
                order.IsDeleted = reader["IsDeleted"] != DBNull.Value ? Convert.ToBoolean(reader["IsDeleted"]) : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading order data: {ex.Message}");
            }

            return order;
        }

        #endregion
    }
}
