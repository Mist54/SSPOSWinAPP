using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SSPOS.DLL;


namespace SSPOS.BLL
{
    public class OrderDetail
    {
        #region Fields

        private int _id;
        private int _orderId;
        private int _productId;
        private decimal _price;
        private int _qty;
        private string _status;
        private string _createdBy;
        private DateTime _createdDate;
        private string _updatedBy;
        private DateTime _updatedDate;
        private bool _isDeleted;

        #endregion

        #region Properties

        public int Id { get => _id; set => _id = value; }
        public int OrderId { get => _orderId; set => _orderId = value; }
        public int ProductId { get => _productId; set => _productId = value; }
        public decimal Price { get => _price; set => _price = value; }
        public int Qty { get => _qty; set => _qty = value; }
        public string Status { get => _status; set => _status = value; }
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
        public string UpdatedBy { get => _updatedBy; set => _updatedBy = value; }
        public DateTime UpdatedDate { get => _updatedDate; set => _updatedDate = value; }
        public bool IsDeleted { get => _isDeleted; set => _isDeleted = value; }



        #endregion

        #region Constructors

        public OrderDetail()
        {
            // Default constructor
        }

        public OrderDetail(int id, int orderId, int productId, decimal price, int qty, string status, string createdBy, DateTime createdDate, string updatedBy, DateTime updatedDate, bool isDeleted)
        {
            Id = id;
            OrderId = orderId;
            ProductId = productId;
            Price = price;
            Qty = qty;
            Status = status;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            UpdatedBy = updatedBy;
            UpdatedDate = updatedDate;
            IsDeleted = isDeleted;
        }

        #endregion

        #region CRUD

        public static int Create(int orderId, int productId, decimal price, int qty, string status, string createdBy)
        {
            try
            {
                return OrderDetailData.Create(orderId, productId, price, qty, status, createdBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<OrderDetail> RetrieveAll()
        {
            List<OrderDetail> orderDetailList = new List<OrderDetail>();
            try
            {
                DataTable dt = OrderDetailData.RetrieveAll();
                DataTableReader r = dt.CreateDataReader();
                while (r.Read())
                    orderDetailList.Add(ConvertReaderToObject(r));
                r.Close();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return orderDetailList;
        }

        public static OrderDetail RetrieveByID(int id)
        {
            OrderDetail result = null;
            try
            {
                DataTable dt = OrderDetailData.RetrieveByID(id);
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


        public static OrderDetail RetrieveByOrderID(int OrderId)
        {
            OrderDetail result = null;
            try
            {
                DataTable dt = OrderDetailData.RetrieveByOrderID(OrderId);
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


        public static int Update(int id, int orderId, int productId, decimal price, int qty, string status, string updatedBy)
        {
            try
            {
                return OrderDetailData.Update(id, orderId, productId, price, qty, status, updatedBy);
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
                return OrderDetailData.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DeletePermanently(int TableId, String TablePosition, int ProductCode)
        {
            try
            {
                return OrderDetailData.DeletePermanently(TableId,TablePosition,ProductCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static List<OrderedItems> ReadAllOrderedItems()
        {
            List<OrderedItems> orderDetailList = new List<OrderedItems>();

            try
            {
                DataTable dt = OrderDetailData.ReadAllOrderdItems();

                using (DataTableReader reader = dt.CreateDataReader())
                {
                    while (reader.Read())
                    {
                        OrderedItems orderedItem = OrderedItems.ConvertReaderToObject(reader);
                        orderDetailList.Add(orderedItem);
                    }
                }

                
                dt.Dispose();
            }
            catch (Exception ex)
            {
              
                Console.WriteLine($"Error reading ordered items: {ex.Message}");
                throw;
            }

            return orderDetailList;
        }


        public static List<OrderedItems> ReadAllOrderedItems(int? tableNo = null, int? waiterId = null, string tablePosition = null, string status = null)
        {
            List<OrderedItems> orderDetailList = new List<OrderedItems>();

            try
            {
                // Call the overloaded method with optional filters
                DataTable dt = OrderDetailData.ReadAllOrderedItems(tableNo, waiterId, tablePosition, status);

                using (DataTableReader reader = dt.CreateDataReader())
                {
                    while (reader.Read())
                    {
                        OrderedItems orderedItem = OrderedItems.ConvertReaderToObject(reader);
                        orderDetailList.Add(orderedItem);
                    }
                }

                dt.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading ordered items: {ex.Message}");
                throw;
            }

            return orderDetailList;
        }



        public static List<OrderedItems> ReadAllOrderedItems(string TableNo, int WaiterId)
        {
            List<OrderedItems> orderDetailList = new List<OrderedItems>();

            try
            {
                DataTable dt = OrderDetailData.ReadAllOrderdItems(TableNo,WaiterId);

                using (DataTableReader reader = dt.CreateDataReader())
                {
                    while (reader.Read())
                    {
                        OrderedItems orderedItem = OrderedItems.ConvertReaderToObject(reader);
                        orderDetailList.Add(orderedItem);
                    }
                }


                dt.Dispose();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error reading ordered items: {ex.Message}");
                throw;
            }

            return orderDetailList;
        }

        #endregion

        #region ConvertToObject
        private static OrderDetail ConvertReaderToObject(DataTableReader reader)
        {
            OrderDetail orderDetail = new OrderDetail();

            try
            {
                orderDetail.Id = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0;
                orderDetail.OrderId = reader["OrderId"] != DBNull.Value ? Convert.ToInt32(reader["OrderId"]) : 0;
                orderDetail.ProductId = reader["ProductId"] != DBNull.Value ? Convert.ToInt32(reader["ProductId"]) : 0;
                orderDetail.Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0;
                orderDetail.Qty = reader["Qty"] != DBNull.Value ? Convert.ToInt32(reader["Qty"]) : 0;
                orderDetail.Status = reader["Status"] != DBNull.Value ? reader["Status"].ToString() : string.Empty;
                orderDetail.CreatedBy = reader["CreatedBy"] != DBNull.Value ? reader["CreatedBy"].ToString() : string.Empty;
                orderDetail.CreatedDate = reader["CreatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["CreatedDate"]) : DateTime.MinValue;
                orderDetail.UpdatedBy = reader["UpdatedBy"] != DBNull.Value ? reader["UpdatedBy"].ToString() : string.Empty;
                orderDetail.UpdatedDate = reader["UpdatedDate"] != DBNull.Value ? Convert.ToDateTime(reader["UpdatedDate"]) : DateTime.MinValue;
                orderDetail.IsDeleted = reader["IsDeleted"] != DBNull.Value && Convert.ToBoolean(reader["IsDeleted"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading order detail data: {ex.Message}");
            }

            return orderDetail;
        }

        #endregion
    }


    public class OrderedItems
    {
        public int OrderId { get; set; }
        public string BillNo { get; set; }
        public int TableNo { get; set; }
        public string TableNumber { get; set; }
        public string TablePosition { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductCode { get; set; }
        public string Category { get; set; }
        public string UOM { get; set; }
        public string OrderDetailStatus { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedDate { get; set; }
        

        public string DisplayTableAndPosition => $"{TableNumber} {TablePosition}";

        // Updated method to return OrderedItems instead of OrderDetail
        public static OrderedItems ConvertReaderToObject(DataTableReader reader)
        {
            OrderedItems orderedItem = new OrderedItems();

            try
            {
                orderedItem.OrderId = reader["OrderId"] != DBNull.Value ? Convert.ToInt32(reader["OrderId"]) : 0;
                orderedItem.BillNo = reader["BillNo"] != DBNull.Value ? reader["BillNo"].ToString() : string.Empty;
                orderedItem.TableNo = reader["TableNo"] != DBNull.Value ? Convert.ToInt32(reader["TableNo"]) : 0;
                orderedItem.TableNumber = reader["TableNumber"] != DBNull.Value ? reader["TableNumber"].ToString() : string.Empty;
                orderedItem.TablePosition = reader["TablePosition"] != DBNull.Value ? reader["TablePosition"].ToString() : string.Empty;
                orderedItem.ProductId = reader["ProductId"] != DBNull.Value ? Convert.ToInt32(reader["ProductId"]) : 0;
                orderedItem.ProductName = reader["ProductName"] != DBNull.Value ? reader["ProductName"].ToString() : string.Empty;
                orderedItem.ProductCode = reader["ProductCode"] != DBNull.Value ? Convert.ToInt32(reader["ProductCode"]) : 0;
                orderedItem.UOM = reader["UOM"] != DBNull.Value ? reader["UOM"].ToString() : string.Empty;
                orderedItem.OrderDetailStatus = reader["OrderDetailStatus"] != DBNull.Value ? reader["OrderDetailStatus"].ToString() : string.Empty;
                orderedItem.Price = reader["Price"] != DBNull.Value ? Convert.ToDecimal(reader["Price"]) : 0m;
                orderedItem.Qty = reader["Qty"] != DBNull.Value ? Convert.ToInt32(reader["Qty"]) : 0;
                orderedItem.Total = reader["Total"] != DBNull.Value ? Convert.ToDecimal(reader["Total"]) : 0m;
                orderedItem.Category = reader["Category"] != DBNull.Value ? reader["Category"].ToString() : string.Empty;
                orderedItem.CreatedDate = reader["CreatedDate"] != DBNull.Value? Convert.ToDateTime(reader["CreatedDate"]) : DateTime.MinValue;


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading ordered item data: {ex.Message}");
            }

            return orderedItem;
        }
    }



}
