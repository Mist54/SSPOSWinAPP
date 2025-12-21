using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SSPOS.BLL;
using SSPOS.GUI.Shared;

namespace SSPOS.GUI
{
    public partial class OrderForm : Form
    {
        private List<Product> productList;
        string loggedInUser = SessionManager.UserName;
        //setting up the temp list
        private List<OrderRecord> tempOrderList = new List<OrderRecord>();
        public OrderForm()
        {
            InitializeComponent();
           
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            pageSetup();
            this.BeginInvoke((Action)(() => ddlTablename.Focus()));


        }


        protected void pageSetup()
        {
           
            SetUpGrid();
            bindDdlSection();
            SetUpDdlTable();
            SetupDdlWaiter();
            SetUpOrderGrid();
            txtQty.Text = "1";//Setting up the default values
            LoaderManager.Hide();
           

          
        }


        private void SetUpGrid(string searchString = null)
        {
            // Bind the product list to the DataGridView
            productList = Product.RetrieveAll(loggedInUser);

            // Assign searchString with priority to txtProductcode.Text if it's not empty
            string effectiveSearchString = !string.IsNullOrEmpty(txtProductcode.Text.Trim())
                ? txtProductcode.Text.Trim()
                : searchString?.Trim();

            if (!string.IsNullOrEmpty(effectiveSearchString))
            {
                // Filter the product list based on Code or ProductName
                productList = productList.Where(product =>
                    product.Code.ToString().Contains(effectiveSearchString) ||
                    product.ProductName.IndexOf(effectiveSearchString, StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();
            }

            //Show only required Columns
            grdProduct.DataSource = new BindingSource(productList, null); // Using BindingSource for better data binding
            grdProduct.Columns["Id"].Visible = false;
            grdProduct.Columns["CategoryId"].Visible = false;
            grdProduct.Columns["CreatedBy"].Visible = false;
            grdProduct.Columns["CreatedDate"].Visible = false;
            grdProduct.Columns["ModifiedBy"].Visible = false;
            grdProduct.Columns["ModifiedDate"].Visible = false;
            grdProduct.Columns["CreatedDate"].Visible = false;
            grdProduct.Columns["Subcategory"].Visible = false;
            grdProduct.Columns["CategoryName"].Visible = false;
            CustomizeGrid();
        }

        private void CustomizeGrid()
        {
            // Customize the appearance of the grid
            grdProduct.EnableHeadersVisualStyles = false;
            grdProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            grdProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            // General row styles
            grdProduct.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular);
            grdProduct.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 229, 252);
            grdProduct.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set cell borders and alternating row colors
            grdProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdProduct.GridColor = Color.FromArgb(224, 224, 224);
            grdProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Customize column widths
            grdProduct.Columns["ProductName"].Width = 150;
            grdProduct.Columns["Code"].Width = 100;
            grdProduct.Columns["UOM"].Width = 70;
            grdProduct.Columns["MRP"].Width = 80;

            // Set the AutoSizeColumnsMode to fill the available space
            grdProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable grid lines for a cleaner look
            grdProduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void CustomizeTempOrderGrid()
        {
            // Customize the appearance of the grid
            grdTempOrder.EnableHeadersVisualStyles = false;
            grdTempOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            grdTempOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdTempOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            // General row styles
            grdTempOrder.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular);
            grdTempOrder.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 229, 252);
            grdTempOrder.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set cell borders and alternating row colors
            grdTempOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdTempOrder.GridColor = Color.FromArgb(224, 224, 224);
            grdTempOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Customize column widths
            grdTempOrder.Columns["TableName"].Width = 150;
            grdTempOrder.Columns["WaiterName"].Width = 150;
            grdTempOrder.Columns["ProductCode"].Width = 100;
            grdTempOrder.Columns["Quantity"].Width = 70;
            grdTempOrder.Columns["Section"].Width = 100;
            grdTempOrder.Columns["TablePosition"].Width = 100;
            grdTempOrder.Columns["ProductPrice"].Width = 80;
            grdTempOrder.Columns["TotalPrice"].Width = 100;

            // Set the AutoSizeColumnsMode to fill the available space
            grdTempOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable grid lines for a cleaner look
            grdTempOrder.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }


        protected void bindDdlSection()
        {
            List<string> sectionOptions = new List<string> { "Regular", "Outside", "Direct" };
            ddlSection.DataSource = sectionOptions;
        }


        protected void SetUpOrderGrid()
        {
            // Retrieve all ordered items from the data source
            List<OrderedItems> orderedItemList = OrderDetail.ReadAllOrderedItems();
            orderedItemList = orderedItemList.Where(item => item.OrderDetailStatus == BillStatus.Ordered).ToList();
            if(orderedItemList.Count > 0)
            {
                // Trim and retrieve input values
                string tablename = ddlTablename.Text.Trim();
                int tablenumber = GetTableId(tablename); // Assuming GetTableId correctly maps tablename to a table number
                string tablePosition = txtPosition.Text.Trim();

                // Filter the ordered items if all input fields have valid values
                if (!string.IsNullOrEmpty(tablename) &&
                    !string.IsNullOrEmpty(tablePosition) && !string.IsNullOrEmpty(txtProductcode.Text.Trim()))
                {
                    orderedItemList = orderedItemList
                        .Where(item =>
                            item.TableNumber == tablenumber.ToString() &&
                            item.TablePosition.Equals(tablePosition, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                // Bind the filtered list to the DataGridView
                grdOrder.DataSource = new BindingSource { DataSource = orderedItemList };

                // Adjust column visibility
                if (grdOrder.Columns.Contains("OrderId"))
                    grdOrder.Columns["OrderId"].Visible = false;
                if (grdOrder.Columns.Contains("BillNo"))
                    grdOrder.Columns["BillNo"].Visible = false;
                if (grdOrder.Columns.Contains("TableNo"))
                    grdOrder.Columns["TableNo"].Visible = false;

                // Additional customization of the grid
                CustomizeGrdOrder();
            }
            
        }


        private void CustomizeGrdOrder()
        {
            // Enable double buffering to reduce flickering
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, grdOrder, new object[] { true });

            // Customize the appearance of the grid
            grdOrder.EnableHeadersVisualStyles = false;
            grdOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            grdOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            // General row styles
            grdOrder.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular);
            grdOrder.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 229, 252);
            grdOrder.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set cell borders and alternating row colors
            grdOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdOrder.GridColor = Color.FromArgb(224, 224, 224);
            grdOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Customize column widths
            grdOrder.Columns["OrderId"].Width = 100;
            grdOrder.Columns["BillNo"].Width = 150;
            grdOrder.Columns["TableNo"].Width = 100;
            grdOrder.Columns["TableNumber"].Width = 150;
            grdOrder.Columns["ProductId"].Width = 100;
            grdOrder.Columns["ProductName"].Width = 200;
            grdOrder.Columns["UOM"].Width = 80;
            grdOrder.Columns["OrderDetailStatus"].Width = 150;
            grdOrder.Columns["Price"].Width = 100;
            grdOrder.Columns["Qty"].Width = 70;
            grdOrder.Columns["Total"].Width = 120;

            // Set the AutoSizeColumnsMode to fill the available space
            grdOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable grid lines for a cleaner look
            grdOrder.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }


        protected void incrementTablePosition()
        {
            string currentText = txtPosition.Text;

            if (string.IsNullOrEmpty(currentText) || currentText.Length != 1 || !char.IsLetter(currentText[0]))
            {

                txtPosition.Text = "a".ToUpper();

                return;

            }
            char currentChar = char.ToLower(currentText[0]);
            if (currentChar == 'z')
            {
                // Wrap around to 'a'
                txtPosition.Text = "a".ToUpper();

            }
            else
            {

                char nextChar = (char)(currentChar + 1);
                txtPosition.Text = nextChar.ToString().ToUpper();
            }

        }
        protected void DecrementTablePosition()
        {
            string currentText = txtPosition.Text;

            // Check for invalid input or empty text
            if (string.IsNullOrEmpty(currentText) || currentText.Length != 1 || !char.IsLetter(currentText[0]))
            {
                txtPosition.Text = "Z";
                return;
            }

            char currentChar = char.ToLower(currentText[0]);

            if (currentChar == 'a')
            {
                // Wrap around to 'Z'
                txtPosition.Text = "Z";
            }
            else
            {
                // Decrement the character
                char prevChar = (char)(currentChar - 1);
                txtPosition.Text = prevChar.ToString().ToUpper();
            }

        }

        private void btnRemovePosition_Click(object sender, EventArgs e)
        {
            DecrementTablePosition();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            incrementTablePosition();
        }

        private void btnSearchgrdProduct_Click(object sender, EventArgs e)
        {
            string searchString = txtSearchgrdProduct.Text.Trim();
            SetUpGrid(searchString);
        }

        private void txtProductcode_TextChanged(object sender, EventArgs e)
        {
            SetUpGrid();
            UpdateProductPrice();
            SetUpOrderGrid();
        }

        private void UpdateProductPrice()
        {


            int productCode = 0;
            string productPrice = "";

            // Try parsing the product code from the textbox
            if (int.TryParse(txtProductcode.Text.Trim(), out productCode))
            {
                // Retrieve the product based on the product code
                Product product = Product.RetrieveByCode(loggedInUser, productCode);
                if (product == null)
                {
                    return;
                }

                // Get the selected section from the ComboBox
                string selectedSection = ddlSection.SelectedItem?.ToString();

                // Determine the price based on the selected section
                switch (selectedSection)
                {
                    case "Direct":
                        productPrice = product.DirectPrice.ToString();
                        break;

                    case "Outside":
                        productPrice = product.OutsidePrice.ToString();
                        break;

                    case "Regular":
                        productPrice = product.RegularPrice.ToString();
                        break;

                    default:
                        productPrice = "";
                        break;
                }

                // Update the label with the selected product price
                lblSelectedProductPrice.Text = productPrice.Trim();

                lblSelectedProductTotalPrice.Text = (decimal.TryParse(productPrice, out decimal productPriceDecimal) 
                    && decimal.TryParse(txtQty.Text, out decimal quantityDecimal)) ? 
                    (productPriceDecimal * quantityDecimal).ToString("0.00") : "0";

            }
        }

        protected void SetUpDdlTable()
        {
            List<Seating> tableRecords = Seating.RetrieveAll();
            // Step 3: Bind the list to the ComboBox
            ddlTablename.DataSource = tableRecords;
            ddlTablename.DisplayMember = "TableName";
            ddlTablename.ValueMember = "Id";

            // Optional: Set a default selected item
            ddlTablename.SelectedIndex = -1; // No selection by default
        }

        private void SetupDdlWaiter()
        {
            int userRole = RoleStatus.Waiter;
            List<SystemUser> WaiterList = SystemUser.RetrieveByUserRole(userRole);


            ddlWaiter.DataSource = WaiterList;
            ddlWaiter.DisplayMember = "Name";
            ddlWaiter.ValueMember = "Id";

           
            ddlWaiter.SelectedIndex = 1; 
        }

        private void AddOrUpdateOrder(string tableName, string waiterName, int productCode, int quantity,
       string section, string tablePosition, decimal productPrice)
        {
            // Check if the product code and table position already exist in the list
            var existingOrder = tempOrderList.FirstOrDefault(o =>
                o.ProductCode == productCode && o.TablePosition == tablePosition && o.TableName == tableName);

            if (existingOrder != null)
            {
                // Update the quantity of the existing order
                var result = MessageBox.Show("This order already exists. Do you want to update the quantity?",
                    "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int totalQty = existingOrder.Quantity + quantity;

                    if (totalQty > 9)
                    {
                        var qtyExceeds = MessageBox.Show("The total quantity exceeds 9. Do you want to proceed?",
                            "Quantity Exceeds Limit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (qtyExceeds == DialogResult.Yes)
                        {
                            existingOrder.Quantity += quantity;
                        }
                        else
                        {
                            return; // User canceled the action
                        }
                    }
                    else
                    {
                        existingOrder.Quantity += quantity;
                    }
                }
                else
                {
                    return; // User chose not to update the quantity
                }
            }
            else
            {
                // Validate quantity before adding a new record
                if (quantity > 9)
                {
                    var qtyExceeds = MessageBox.Show("The quantity exceeds 9. Do you want to proceed?",
                        "Quantity Exceeds Limit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (qtyExceeds == DialogResult.No)
                    {
                        return; // User canceled the action
                    }
                }

                // Add a new order record
                OrderRecord newOrder = new OrderRecord
                {
                    TableName = tableName,
                    WaiterName = waiterName,
                    ProductCode = productCode,
                    Quantity = quantity,
                    Section = section,
                    TablePosition = tablePosition,
                    ProductPrice = productPrice
                };

                tempOrderList.Add(newOrder);
            }

            // Refresh the order grid after adding or updating
            RefreshOrderGrid();
        }

        private void RefreshOrderGrid()
        {
            grdTempOrder.DataSource = null;
            grdTempOrder.DataSource = tempOrderList;
            grdOrder.Refresh();
            CustomizeTempOrderGrid();
        }

        private void RemoveOrder(int productCode, string tablePosition, string tableName)
        {
            // Ask for confirmation with a MessageBox
            var result = MessageBox.Show(
                "Are you sure you want to remove this order?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            // If user clicks 'Yes', proceed with removing the order
            if (result == DialogResult.Yes)
            {
                var orderToRemove = tempOrderList.FirstOrDefault(o => o.ProductCode == productCode && o.TablePosition == tablePosition && o.TableName == tableName) ;

                if (orderToRemove != null)
                {
                    tempOrderList.Remove(orderToRemove);
                    MessageBox.Show("Order removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshOrderGrid();
            }
        }


        private void grdProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                DataGridViewRow row = grdProduct.Rows[e.RowIndex];

                
                int productCode = Convert.ToInt32(row.Cells["Code"].Value);

                
                txtProductcode.Text = productCode.ToString();
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            UpdateProductPrice();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveTempOrder();
            txtProductcode.Focus();
        }


        protected void saveTempOrder()
        {
            // Ensure the combo box selections are not null before calling ToString()
            string tableName = ddlTablename.Text.Trim();
            string waiterName = ddlWaiter.Text.Trim();
            string sectionName = ddlSection.Text.Trim();
            string tablePosition = txtPosition.Text.Trim();
            try
            {
                string status = BillStatus.Billed;
                int tableId = GetTableId(tableName);
                List<OrderedItems> orderedItemList = OrderDetail.ReadAllOrderedItems(tableNo: tableId, tablePosition: tablePosition, status: status);
                if(orderedItemList.Count > 0)
                {
                    MessageBox.Show("The table is occupied and billed, Settle it first to get new orders.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

            }
            catch (Exception ex)
            {

            }
            

            // Try to parse numeric values to avoid exceptions
            if (!int.TryParse(txtQty.Text.Trim(), out int qty))
            {
                MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtProductcode.Text.Trim(), out int productCode))
            {
                MessageBox.Show("Please enter a valid product code.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(lblSelectedProductPrice.Text, out decimal productPrice))
            {
                MessageBox.Show("Product price is invalid.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Table name is required.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(waiterName))
            {
                MessageBox.Show("Waiter name is required.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product prd = Product.RetrieveByCode(SessionManager.UserName, productCode);
            if (prd != null)
            {
                // Call the method to add or update the order
                AddOrUpdateOrder(tableName, waiterName, productCode, qty, sectionName, tablePosition, productPrice);
            }
            else
            {
                MessageBox.Show("No product found with Product code : " + productCode + ".", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
        }

       
        private void ddlSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProductPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteOrder();
        }

        private void deleteOrder()
        {
            // Ensure the ComboBox selection is not null before calling ToString()
            string tableName = ddlTablename.Text;
            string tablePosition = txtPosition.Text.Trim();
            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(tablePosition))
            {
                MessageBox.Show("Check table name or table position", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            // Try parsing the Productcode to ensure it's a valid integer
            if (!int.TryParse(txtProductcode.Text.Trim(), out int productCode))
            {
                MessageBox.Show("Please enter a valid product code.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the method to remove the order
            RemoveOrder(productCode, tablePosition, tableName);
        }


        private void grdTempOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = grdTempOrder.Rows[e.RowIndex];

               
                int productCode = Convert.ToInt32(row.Cells["ProductCode"].Value);
                string tableName = row.Cells["TableName"].Value.ToString();
                string tablePosition = row.Cells["TablePosition"].Value.ToString();
                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);

                // Set ComboBox and TextBox values

                var item = ddlTablename.Items.Cast<object>().FirstOrDefault(i => i.ToString() == tableName);
                if (item != null)
                {
                    ddlTablename.SelectedItem = item;
                }
                ddlTablename.Refresh();
                txtPosition.Text = tablePosition;
                txtProductcode.Text = productCode.ToString();
                txtQty.Text = qty.ToString();
            }
        }

        protected void SaveOrder()
        {
            try
            {
                if (!ValidateGrid())
                    return;

                string billNumber = GenerateBillNumber();
                bool orderSaved = ProcessOrders(billNumber);

                if (orderSaved)
                {
                    ShowSuccessMessage();
                    CleanupAfterSave();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private bool ValidateGrid()
        {
            if (grdTempOrder.Rows.Count == 0 || grdTempOrder.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                ShowWarning("No orders to save.");
                return false;
            }
            return true;
        }

        private string GenerateBillNumber()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }

        private bool ProcessOrders(string billNumber)
        {
            int? currentOrderId = null;
            bool orderSaved = false;

            foreach (DataGridViewRow row in grdTempOrder.Rows)
            {
                if (row.IsNewRow) continue;

                var orderData = ExtractOrderData(row);
                if (!orderData.IsValid)
                    return false;

                try
                {
                    orderSaved = ProcessSingleOrder(orderData, billNumber, ref currentOrderId);
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                    return false;
                }
            }

            return orderSaved;
        }

        private (bool IsValid, string TableName, string WaiterName, string ProductCode,
                string SectionName, string TablePosition, int TableId, int WaiterId,
                int ProductId, int Quantity, decimal ProductPrice) ExtractOrderData(DataGridViewRow row)
        {
            var tableName = row.Cells["tableName"].Value?.ToString();
            var waiterName = row.Cells["waiterName"].Value?.ToString();
            var productCode = row.Cells["productCode"].Value?.ToString();
            var sectionName = row.Cells["Section"].Value?.ToString();
            var tablePosition = row.Cells["tablePosition"].Value?.ToString();

            if (string.IsNullOrEmpty(tableName) || string.IsNullOrEmpty(waiterName) || string.IsNullOrEmpty(productCode))
            {
                ShowWarning("Missing critical fields (Table, Waiter, Product).");
                return (false, null, null, null, null, null, 0, 0, 0, 0, 0);
            }

            int tableId = GetTableId(tableName);
            int waiterId = GetWaiterId(waiterName);
            int productId = Convert.ToInt32(productCode);
            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value ?? 0);
            decimal productPrice = Convert.ToDecimal(row.Cells["productPrice"].Value ?? 0);

            if (quantity <= 0 || productPrice <= 0)
            {
                ShowWarning("Invalid quantity or price in the row.");
                return (false, null, null, null, null, null, 0, 0, 0, 0, 0);
            }

            return (true, tableName, waiterName, productCode, sectionName, tablePosition,
                    tableId, waiterId, productId, quantity, productPrice);
        }

        private bool ProcessSingleOrder(
            (bool IsValid, string TableName, string WaiterName, string ProductCode,
             string SectionName, string TablePosition, int TableId, int WaiterId,
             int ProductId, int Quantity, decimal ProductPrice) orderData,
            string billNumber,
            ref int? currentOrderId)
        {
            var existingOrder = Order.RetrieveByTableAndPosition(orderData.TableId, orderData.TablePosition,BillStatus.Ordered);

            if (existingOrder != null)
            {
                return UpdateExistingOrder(existingOrder, orderData);
            }
            else
            {
                return CreateNewOrder(orderData, billNumber, ref currentOrderId);
            }
        }

        private bool UpdateExistingOrder(Order existingOrder,
            (bool IsValid, string TableName, string WaiterName, string ProductCode,
             string SectionName, string TablePosition, int TableId, int WaiterId,
             int ProductId, int Quantity, decimal ProductPrice) orderData)
        {
            var existingOrderDetail = OrderDetail.RetrieveByOrderID(existingOrder.Id);
            if (existingOrderDetail.ProductId == orderData.ProductId)
            {
                int updateQty = existingOrderDetail.Qty + orderData.Quantity;
                return OrderDetail.Update(
                    existingOrderDetail.Id,
                    existingOrder.Id,
                    existingOrderDetail.ProductId,
                    existingOrderDetail.Price,
                    updateQty,
                    BillStatus.Ordered,
                    SessionManager.UserName) > 0;
            }
            else
            {
                return OrderDetail.Create(
                    existingOrder.Id,
                    orderData.ProductId,
                    orderData.ProductPrice,
                    orderData.Quantity,
                    BillStatus.Ordered,
                    SessionManager.UserName) > 0;
            }
        }

        private bool CreateNewOrder(
            (bool IsValid, string TableName, string WaiterName, string ProductCode,
             string SectionName, string TablePosition, int TableId, int WaiterId,
             int ProductId, int Quantity, decimal ProductPrice) orderData,
            string billNumber,
            ref int? currentOrderId)
        {
            if (!currentOrderId.HasValue)
            {
                currentOrderId = Order.Create(
                    billNumber,
                    orderData.TableId,
                    orderData.TablePosition,
                    orderData.WaiterId,
                    orderData.SectionName,
                    BillStatus.Ordered,
                    SessionManager.UserName);
            }

            return OrderDetail.Create(
                currentOrderId.Value,
                orderData.ProductId,
                orderData.ProductPrice,
                orderData.Quantity,
                BillStatus.Ordered,
                SessionManager.UserName) > 0;
        }

        private void ShowSuccessMessage()
        {
            MessageBox.Show("Order saved successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Invalid Input",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void HandleError(Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CleanupAfterSave()
        {
            tempOrderList.Clear();
            RefreshOrderGrid();
        }

        // Method to retrieve table ID based on table name
        private int GetTableId(string tableName)
        {
            int TableId = 0;
            Seating Table = Seating.RetrieveByTableName(tableName);
            if (Table != null)
            {
                TableId = Table.Id;

            }
            return TableId;
        }

        // Method to retrieve waiter ID based on waiter name
        private int GetWaiterId(string waiterName)
        {
            int waiterId = 0;
            SystemUser waiter = SystemUser.RetrieveByUserName(waiterName);
            if (waiter != null)
            {
                waiterId = waiter.Id;
            }
            return waiterId;
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            SaveOrder();
            SetUpOrderGrid();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            CancelOrder();


        }

        private void CancelOrder()
        {
            var confirmationResult = MessageBox.Show(
               "Are you sure you want to cancel the order?",
               "Confirm Cancellation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (confirmationResult == DialogResult.Yes)
            {
                bool hasRecords = false;

                // First, check if there are any valid records in the grid
                foreach (DataGridViewRow row in grdOrder.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        hasRecords = true;
                        break;
                    }
                }

                // If no records are found, show an error message and exit
                if (!hasRecords)
                {
                    MessageBox.Show("No records found in the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Process each record if records are present
                foreach (DataGridViewRow row in grdOrder.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Get the ProductCode from the current row
                        int productCode;
                        if (int.TryParse(row.Cells["ProductCode"].Value?.ToString(), out productCode))
                        {
                            if (productCode == Convert.ToInt32(txtProductcode.Text))
                            {
                                // Call the CancelOrder function with the ProductCode
                                CancelOrder(productCode);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid ProductCode in the grid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }


        protected void CancelOrder(int productCode)
        {
            // Retrieve table name and position from UI elements
            string tableName = ddlTablename.Text?.Trim();
            string tablePosition = txtPosition.Text?.Trim();

            // Validate table name
            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Table name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get table ID
            int tableId = GetTableId(tableName);
            if (tableId <= 0)
            {
                MessageBox.Show("Invalid table name or position. Please check and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to delete the order
            try
            {
                bool isDeleted = OrderDetail.DeletePermanently(tableId, tablePosition, productCode);
                if (isDeleted)
                {
                    MessageBox.Show("Order successfully canceled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to cancel the order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Log and display any unexpected errors
                Console.WriteLine($"Error canceling order: {ex.Message}");
                MessageBox.Show("An unexpected error occurred while canceling the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetUpOrderGrid();
                RefreshOrderGrid();
            }
        }

        private void ddlWaiter_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ddlSection.Focus();
            }
        }

        private void ddlSection_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtPosition.Focus();
            }
        }

        private void txtProductcode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }

        private void txtPosition_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtProductcode.Focus();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1)
            {
                saveTempOrder();
                return true;
            }
            else if(keyData == Keys.F5)
            {
                deleteOrder();
                return true;
            }
            else if (keyData == Keys.F9)
            {
                CancelOrder();
                return true;
            }
            else if (keyData == Keys.F2)
            {
                SaveOrder();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ddlTablename_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUpOrderGrid();
        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            SetUpOrderGrid();
        }
    }

}
