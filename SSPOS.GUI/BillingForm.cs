using QRCoder;
using SSPOS.BLL;
using SSPOS.GUI.Shared;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace SSPOS.GUI
{
    public partial class BillingForm : Form
    {

        private PrintDocument printDocument = new PrintDocument();
        private bool isDuplicatePrint = false;
        private Timer gridTimer;
        public BillingForm()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            pageSetUp();
        }

        private void pageSetUp()
        {
            //Setting up date format
            dtpBillDateTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpBillDateTime.Value = DateTime.Now;

            SetUpDdlTable();
            SetUpBillingGrid(BillStatus.Billed);
            SetUpPendingOrderGrid(BillStatus.Ordered);
            LoaderManager.Hide();


        }

        private void SetUpDdlTable()
        {
            // Retrieve and filter ordered items with distinct TableName and Position
            ddlTablename.DataSource = OrderDetail.ReadAllOrderedItems()
                .Where(item => item.OrderDetailStatus == BillStatus.Ordered || item.OrderDetailStatus == BillStatus.Billed)
                .GroupBy(item => new { item.TableNumber, item.TablePosition })
                .Select(group => group.First())
                .ToList();

            ddlTablename.DisplayMember = "DisplayTableAndPosition";
            ddlTablename.ValueMember = "TableNo";

            // Set the first item as selected
            if (ddlTablename.Items.Count > 0)
            {
                ddlTablename.SelectedIndex = 0;
            }
        }



        private void SetUpPendingOrderGrid(string status = null)
        {

            grdPendingOrder.DataSource = null;
            grdPendingOrder.Refresh();

            // Populate grid with data
            List<BillTable> orderedItemList = BillTable.RetrieveAll();
            if (!string.IsNullOrEmpty(status))
            {
                orderedItemList = orderedItemList
                    .Where(b => b.Status != null && b.Status.ToLower() == status.ToLower())
                    .ToList();
            }
            if (orderedItemList!=null && orderedItemList.Count > 0)
            {
                grdPendingOrder.DataSource = new BindingSource { DataSource = orderedItemList };

                // Hide unnecessary columns
                var columnsToHide = new[]
                {
                    "OrderId","TableSection", "TableNo", 
                };

                foreach (var column in columnsToHide)
                {
                    if (grdPendingOrder.Columns.Contains(column))
                        grdPendingOrder.Columns[column].Visible = false;
                }

                // Add Timer column if not already present
                if (!grdPendingOrder.Columns.Contains("Timer"))
                {
                    var timerColumn = new DataGridViewTextBoxColumn
                    {
                        Name = "Timer",
                        HeaderText = "Time Elapsed",
                        ReadOnly = true,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    };

                    // Add the column at the end
                    grdPendingOrder.Columns.Add(timerColumn);
                }
                else
                {
                    // Move "Timer" column to the end if it already exists
                    grdPendingOrder.Columns["Timer"].DisplayIndex = grdPendingOrder.Columns.Count - 1;
                }



                CustomizeGrdPendingOrder();


                StartGridTimer();
            }
            else
            {
                grdPendingOrder.DataSource = null;
            }
           

           
        }

        private void StartGridTimer()
        {
            if (gridTimer == null)
            {
                gridTimer = new Timer
                {
                    Interval = 1000 // Update every second
                };
                gridTimer.Tick += GridTimer_Tick;
            }

            gridTimer.Start();
        }

        private void GridTimer_Tick(object sender, EventArgs e)
        {
            // Update the Timer column dynamically
            foreach (DataGridViewRow row in grdPendingOrder.Rows)
            {
                if (row.DataBoundItem is BillTable orderedItem && orderedItem.OrderDate != null)
                {
                    // Calculate elapsed time
                    TimeSpan elapsed = DateTime.Now - orderedItem.OrderDate;
                    string elapsedTime = $"{elapsed.Hours:D2}:{elapsed.Minutes:D2}:{elapsed.Seconds:D2}";

                    // Update Timer column
                    row.Cells["Timer"].Value = elapsedTime;

                    // Apply conditional formatting
                    if (elapsed.TotalHours >= 1)
                    {
                        row.Cells["Timer"].Style.ForeColor = Color.Red; 
                    }
                    else
                    {
                        row.Cells["Timer"].Style.ForeColor = Color.Black; 
                    }
                }
            }
        }

        private void CustomizeGrdPendingOrder()
        {
            // Enable double buffering to reduce flickering
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, grdPendingOrder, new object[] { true });

            // Customize the appearance of the grid
            grdPendingOrder.EnableHeadersVisualStyles = false;
            grdPendingOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            grdPendingOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdPendingOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            // General row styles
            grdPendingOrder.DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Regular);
            grdPendingOrder.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 229, 252);
            grdPendingOrder.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set cell borders and alternating row colors
            grdPendingOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdPendingOrder.GridColor = Color.FromArgb(224, 224, 224);
            grdPendingOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Customize column widths
            grdPendingOrder.Columns["OrderId"].Width = 100;
            grdPendingOrder.Columns["BillNo"].Width = 150;
            grdPendingOrder.Columns["FullTableName"].Width = 100;
            grdPendingOrder.Columns["OrderDate"].Width = 150;
            grdPendingOrder.Columns["Timer"].Width = 150;

            // Set the AutoSizeColumnsMode to fill the available space
            grdPendingOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable grid lines for a cleaner look
            grdPendingOrder.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void SetUpBillingGrid(string status = null)
        {
            //Refreshing the Grid
            grdBilling.DataSource = null;
            grdBilling.Refresh();

            List<BillTable> orderedItemList = BillTable.RetrieveAll();
            if (!string.IsNullOrEmpty(status))
            {
                orderedItemList = orderedItemList
                    .Where(b => b.Status != null && b.Status.ToLower() == status.ToLower())
                    .ToList();
            }
            grdBilling.DataSource = new BindingSource { DataSource = orderedItemList };

            if (grdBilling.Columns.Contains("TableSection"))
                grdBilling.Columns["TableSection"].Visible = false;
            if (grdBilling.Columns.Contains("TableNo"))
                grdBilling.Columns["TableNo"].Visible = false;

            CustomizeGrdBilling();
        }

        private void SetUpGrdBillSetUp()
        {
            string selectedTable = ddlTablename.Text;
            string[] parts = selectedTable.Split(' ');
            string TableName = parts.Length > 0 ? parts[0] : string.Empty;
            int TableNo = GetTableId(TableName);
            string TablePosition = parts.Length > 1 ? parts[1] : string.Empty;
            //string status = BillStatus.Ordered;
            string status = null;

            List<OrderedItems> orderedItemList = OrderDetail.ReadAllOrderedItems(tableNo: TableNo, tablePosition: TablePosition,status: status);

            orderedItemList = orderedItemList.Where(item => item.OrderDetailStatus != BillStatus.Settled).ToList();
            
            string billNumber = orderedItemList.FirstOrDefault()?.BillNo ?? string.Empty;


            if (orderedItemList != null && orderedItemList.Count > 0)
            {
                grdBillSetUp.DataSource = new BindingSource { DataSource = orderedItemList };
                if (grdBillSetUp.Columns.Contains("OrderId"))
                    grdBillSetUp.Columns["OrderId"].Visible = false;
                if (grdBillSetUp.Columns.Contains("BillNo"))
                    grdBillSetUp.Columns["BillNo"].Visible = false;
                if (grdBillSetUp.Columns.Contains("TableNo"))
                    grdBillSetUp.Columns["TableNo"].Visible = false;
                if (grdBillSetUp.Columns.Contains("TableNumber"))
                    grdBillSetUp.Columns["TableNumber"].Visible = false;
                if (grdBillSetUp.Columns.Contains("TablePosition"))
                    grdBillSetUp.Columns["TablePosition"].Visible = false;
                if (grdBillSetUp.Columns.Contains("ProductId"))
                    grdBillSetUp.Columns["ProductId"].Visible = false;
                if (grdBillSetUp.Columns.Contains("OrderDetailStatus"))
                    grdBillSetUp.Columns["OrderDetailStatus"].Visible = false;
                if (grdBillSetUp.Columns.Contains("DisplayTableAndPosition"))
                    grdBillSetUp.Columns["DisplayTableAndPosition"].Visible = false;
                if (grdBillSetUp.Columns.Contains("TableNo"))
                    grdBillSetUp.Columns["TableNo"].Visible = false;
                if (grdBillSetUp.Columns.Contains("CreatedDate"))
                    grdBillSetUp.Columns["CreatedDate"].Visible = false;

                CustomizeGrdBillSetUp();
                UpdateBillTotal();
                setBillStatusAndPosition(billNumber, BillStatus.Ordered, TablePosition);
            }
            else if(orderedItemList.Count <= 0)
            {
                List<OrderedItems> EmptyorderedItemList = new List<OrderedItems>();
                grdBillSetUp.DataSource = new BindingSource { DataSource = EmptyorderedItemList };
                if (grdBillSetUp.Columns.Contains("OrderId"))
                    grdBillSetUp.Columns["OrderId"].Visible = false;
                if (grdBillSetUp.Columns.Contains("BillNo"))
                    grdBillSetUp.Columns["BillNo"].Visible = false;
                if (grdBillSetUp.Columns.Contains("TableNo"))
                    grdBillSetUp.Columns["TableNo"].Visible = false;
                if (grdBillSetUp.Columns.Contains("TableNumber"))
                    grdBillSetUp.Columns["TableNumber"].Visible = false;
                if (grdBillSetUp.Columns.Contains("TablePosition"))
                    grdBillSetUp.Columns["TablePosition"].Visible = false;
                if (grdBillSetUp.Columns.Contains("ProductId"))
                    grdBillSetUp.Columns["ProductId"].Visible = false;
                if (grdBillSetUp.Columns.Contains("OrderDetailStatus"))
                    grdBillSetUp.Columns["OrderDetailStatus"].Visible = false;
                if (grdBillSetUp.Columns.Contains("DisplayTableAndPosition"))
                    grdBillSetUp.Columns["DisplayTableAndPosition"].Visible = false;
                if (grdBillSetUp.Columns.Contains("TableNo"))
                    grdBillSetUp.Columns["TableNo"].Visible = false;
                if (grdBillSetUp.Columns.Contains("CreatedDate"))
                    grdBillSetUp.Columns["CreatedDate"].Visible = false;


                CustomizeGrdBillSetUp();
            }

        }

        private void CustomizeGrdBillSetUp()
        {
            // General settings
            grdBillSetUp.EnableHeadersVisualStyles = false;
            grdBillSetUp.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            grdBillSetUp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdBillSetUp.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grdBillSetUp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdBillSetUp.DefaultCellStyle.BackColor = Color.White;
            grdBillSetUp.DefaultCellStyle.ForeColor = Color.Black;
            grdBillSetUp.DefaultCellStyle.SelectionBackColor = Color.White;
            grdBillSetUp.DefaultCellStyle.SelectionForeColor = Color.Black;
            grdBillSetUp.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Alternating rows
            grdBillSetUp.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;

            // Grid settings
            grdBillSetUp.BorderStyle = BorderStyle.None;
            grdBillSetUp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdBillSetUp.GridColor = Color.LightGray;

            // Auto-sizing
            grdBillSetUp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add padding for better appearance
            grdBillSetUp.DefaultCellStyle.Padding = new Padding(5);

            // Disable row headers
            grdBillSetUp.RowHeadersVisible = false;

            // Apply category-based row highlighting
            HighlightSeasonalRows();
        }

        private void HighlightSeasonalRows()
        {
            foreach (DataGridViewRow row in grdBillSetUp.Rows)
            {
                if (row.DataBoundItem is OrderedItems billItem && billItem.Category == "Seasonal")
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                    row.DefaultCellStyle.ForeColor = Color.DarkOrange; // Optional: Highlight text color
                }
            }
            grdBillSetUp.Refresh();
        }


        private void grdBillSetUp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in grdBillSetUp.Rows)
            {
                if (row.DataBoundItem is OrderedItems billItem && billItem.Category == "Seasonal")
                {
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                    row.DefaultCellStyle.ForeColor = Color.DarkOrange; // Optional: Highlight text color
                }
            }
          
        }

        private void CustomizeGrdBilling()
        {
            // Enable double buffering to reduce flickering
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, grdBilling, new object[] { true });

            // Customize the appearance of the grid
            grdBilling.EnableHeadersVisualStyles = false;
            grdBilling.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            grdBilling.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdBilling.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            // General row styles
            grdBilling.DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Regular);
            grdBilling.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 229, 252);
            grdBilling.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set cell borders and alternating row colors
            grdBilling.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdBilling.GridColor = Color.FromArgb(224, 224, 224);
            grdBilling.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            // Customize column widths
            grdBilling.Columns["OrderID"].Width = 70;
            grdBilling.Columns["BillNo"].Width = 100;
            grdBilling.Columns["TableNo"].Width = 80;
            grdBilling.Columns["Waiter"].Width = 100;
            grdBilling.Columns["OrderDate"].Width = 80;
            grdBilling.Columns["Status"].Width = 100;
            grdBilling.Columns["TotalItems"].Width = 70;
            grdBilling.Columns["TotalAmount"].Width = 120;

            // Set the AutoSizeColumnsMode to fill the available space
            grdBilling.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Disable grid lines for a cleaner look
            grdBilling.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        private void ddlTablename_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUpGrdBillSetUp();
            CalculateAmounts();
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


        protected void setBillStatusAndPosition(string BillNumber, string Status, string Position)
        {
            lblStatus.Text = Status;
            lblTablePosition.Text = Position;
            txtBillNumber.Text = BillNumber;
        }

        private void grdBillSetUp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user double-clicked on a valid cell (not the header or an invalid index)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var clickedRow = grdBillSetUp.Rows[e.RowIndex];

                // Ensure that other cells remain read-only by default
                foreach (DataGridViewCell cell in clickedRow.Cells)
                {
                    cell.ReadOnly = true;
                }

                // Check the category value for the clicked row
                if (clickedRow.Cells["Category"].Value != null &&
                    clickedRow.Cells["Category"].Value.ToString().ToLower() == "seasonal")
                {
                    // Check if the clicked column is "Price"
                    if (grdBillSetUp.Columns[e.ColumnIndex].Name == "Price")
                    {
                        // Make the "Price" cell editable
                        clickedRow.Cells["Price"].ReadOnly = false;


                        // Optionally, you can select the cell to start editing
                        grdBillSetUp.CurrentCell = clickedRow.Cells["Price"];
                    }
                }
            }
        }

        private void grdBillSetUp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (grdBillSetUp.Columns[e.ColumnIndex].Name == "Price")
            {
                var editedCell = grdBillSetUp.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string priceValue = editedCell.Value?.ToString();

                if (decimal.TryParse(priceValue, out decimal price) && price > 0)
                {
                    // Update the Total column if Quantity is also available
                    DataGridViewCell quantityCell = grdBillSetUp.Rows[e.RowIndex].Cells["Qty"];
                    DataGridViewCell totalCell = grdBillSetUp.Rows[e.RowIndex].Cells["Total"];

                    if (decimal.TryParse(quantityCell.Value?.ToString(), out decimal quantity))
                    {
                        totalCell.Value = price * quantity;
                        UpdateBillTotal();
                    }
                    else
                    {
                        totalCell.Value = null; // Or set it to 0 if Quantity is invalid
                    }
                }
                else
                {
                    // Show error and reset the Price value
                    MessageBox.Show("Please enter a valid price greater than 0.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    editedCell.Value = null;
                }
            }
        }

        private void grdBillSetUp_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == grdBillSetUp.Columns["Price"].Index)
            {
                MessageBox.Show("Please enter a valid number for the price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.ThrowException = false;
            }
        }

        private void UpdateBillTotal()
        {
            decimal fullTotal = 0;
            foreach (DataGridViewRow row in grdBillSetUp.Rows)
            {
                if (row.Cells["Total"].Value != null && decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal totalValue))
                {
                    fullTotal += totalValue;
                }
            }

            lblBillTotal.Text = fullTotal.ToString("N3");
            lblBillTotal.Tag = fullTotal.ToString();
            lblTotalItems.Text = grdBillSetUp.Rows.Count.ToString();
        }

        private decimal CalculateDiscount(decimal originalTotal, decimal discountValue, bool isPercentage)
        {
            try
            {
                decimal discountedTotal;

                if (isPercentage)
                {
                    if (discountValue < 0 || discountValue > 100)
                        throw new ArgumentOutOfRangeException("Discount percentage must be between 0 and 100.");
                    discountedTotal = originalTotal - (originalTotal * (discountValue / 100));
                }
                else
                {
                    if (discountValue < 0 || discountValue > originalTotal)
                        throw new ArgumentOutOfRangeException("Fixed discount cannot be negative or greater than the original total.");

                    discountedTotal = originalTotal - discountValue;
                }


                return discountedTotal > 0 ? discountedTotal : 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return originalTotal;
            }
        }

        private decimal CalculateDiscount(decimal billTotal)
        {
            decimal discount = 0;

            if (rdbPercentage.Checked)
            {
                if (decimal.TryParse(txtDiscount.Text, out decimal percentage))
                {
                    discount = billTotal * (percentage / 100);
                }
            }
            else if (rdbAmount.Checked)
            {
                if (decimal.TryParse(txtDiscount.Text, out decimal amount))
                {
                    discount = amount;
                }
            }

            return discount;
        }


        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateAmounts();
        }

        private void rdbAmount_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAmounts();
        }

        private void rdbPercentage_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAmounts();
        }

        protected void CalculateAmounts()
        {
            try
            {
                // Ensure original total is parsed safely
                decimal originalTotal = 0.00m;
                if (!decimal.TryParse(lblBillTotal.Text, out originalTotal))
                {
                    lblBillingTotal.Text = "Invalid Total";
                    return;
                }

                // Ensure discount value is parsed safely
                decimal discountValue = 0.00m;
                if (!decimal.TryParse(txtDiscount.Text, out discountValue) || discountValue < 0)
                {
                    lblBillingTotal.Text = "Invalid Discount";
                    return;
                }

                // Determine discount type (percentage or fixed amount)
                bool isPercentage = rdbPercentage.Checked;

                // Calculate the billing total after discount
                decimal billingTotal = CalculateDiscount(originalTotal, discountValue, isPercentage);

                // Calculate tax (2.25% CGST + 2.25% SGST)
                decimal cgst = billingTotal * 2.25m / 100;
                decimal sgst = billingTotal * 2.25m / 100;

                // Calculate total after tax (Bill total with CGST & SGST)
                decimal billWithTax = billingTotal + cgst + sgst;

                // Calculate round-off amount (difference between billing total and rounded value)
                decimal roundedBillingTotal = Math.Round(billWithTax, 0); // Round to nearest whole number
                decimal roundOffAmount = roundedBillingTotal;

                // Calculate non-tax charges (calculated by subtracting tax from bill with tax)
                decimal nonTaxCharges = billWithTax - (cgst + sgst); // This is original total excluding tax

                // Update labels with formatted amounts
                lblBillingTotal.Text = billWithTax.ToString("N3"); // Format as currency
                lblRoundOffAmount.Text = roundOffAmount.ToString("N3"); // Format as currency
                lblNonTaxCharges.Text = nonTaxCharges.ToString("N3"); // Format as currency
                lblNonTaxCharges.Tag = nonTaxCharges.ToString("N3");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font regularFont = new Font("Arial", 8);
            Font boldFont = new Font("Arial", 9, FontStyle.Bold);
            Font titleFont = new Font("Arial", 12, FontStyle.Bold);
            Font footerFont = new Font("Arial", 9, FontStyle.Italic);

            float leftMargin = 5;
            float yPos = 10;
            int lineHeight = 15;

            // Restaurant Name (Header)
            string restaurantName = ConfigManager.Settings.RestaurantName;
            graphics.DrawString(restaurantName, titleFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight * 2;

            // Print Status Indicator
            string printStatus = isDuplicatePrint ? "** DUPLICATE COPY **" : string.Empty;
            if (isDuplicatePrint)
            {
                using (Font warningFont = new Font("Arial", 10, FontStyle.Bold))
                {
                    graphics.DrawString(printStatus, warningFont, Brushes.Red, leftMargin, yPos);
                    yPos += lineHeight * 1.5f;
                }
            }

            // Header
            graphics.DrawString("Restaurant Bill", boldFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight * 1.5f;

            // Table Headers with adjusted positions
            int col1X = (int)leftMargin;
            int col2X = 90;
            int col3X = 130;
            int col4X = 170;

            graphics.DrawString("Item", regularFont, Brushes.Black, col1X, yPos);
            graphics.DrawString("Price", regularFont, Brushes.Black, col2X, yPos);
            graphics.DrawString("Qty", regularFont, Brushes.Black, col3X, yPos);
            graphics.DrawString("Total", regularFont, Brushes.Black, col4X, yPos);
            yPos += lineHeight;

            // Draw separator line
            graphics.DrawLine(Pens.Black, leftMargin, yPos - 2, 200, yPos - 2);

            // Table Data
            foreach (DataGridViewRow row in grdBillSetUp.Rows)
            {
                if (row.Cells["ProductName"].Value != null)
                {
                    string productName = row.Cells["ProductName"].Value.ToString();
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Qty"].Value);
                    decimal total = price * quantity;

                    // Truncate product name if too long
                    if (productName.Length > 15)
                        productName = productName.Substring(0, 12) + "...";

                    graphics.DrawString(productName, regularFont, Brushes.Black, col1X, yPos);
                    graphics.DrawString(price.ToString("N2"), regularFont, Brushes.Black, col2X, yPos);
                    graphics.DrawString(quantity.ToString(), regularFont, Brushes.Black, col3X, yPos);
                    graphics.DrawString(total.ToString("N2"), regularFont, Brushes.Black, col4X, yPos);
                    yPos += lineHeight;
                }
            }

            // Draw separator line
            graphics.DrawLine(Pens.Black, leftMargin, yPos, 200, yPos);
            yPos += lineHeight;


            // Calculate totals
            decimal billTotal = Convert.ToDecimal(lblBillTotal.Tag);

            decimal nonTaxCharges = Convert.ToDecimal(lblNonTaxCharges.Tag);

            decimal discount = CalculateDiscount(billTotal);
            decimal taxableAmount = billTotal - discount;
            decimal cgst = taxableAmount * 0.0225m;
            decimal sgst = taxableAmount * 0.0225m;
            decimal billWithTax = taxableAmount + cgst + sgst;
            decimal roundOff = Math.Round(billWithTax, 0);
            decimal totalReceivable = roundOff;

            // Print calculations with right alignment for amounts
            void DrawBillLine(string label, decimal amount, bool isBold = false)
            {
                var font = isBold ? boldFont : regularFont;
                graphics.DrawString(label, font, Brushes.Black, leftMargin, yPos);
                graphics.DrawString(amount.ToString("N2"), font, Brushes.Black, 200, yPos, new StringFormat { Alignment = StringAlignment.Far });
                yPos += lineHeight;
            }

            DrawBillLine("Bill Total:", billTotal);
            DrawBillLine("Discount:", discount);
            DrawBillLine("Taxable Amount:", taxableAmount);
            DrawBillLine("CGST (2.25%):", cgst);
            DrawBillLine("SGST (2.25%):", sgst);
            DrawBillLine("Non-Tax Charges:", nonTaxCharges);

            // Final total with double line separator
            graphics.DrawLine(Pens.Black, leftMargin, yPos, 200, yPos);
            graphics.DrawLine(Pens.Black, leftMargin, yPos + 2, 200, yPos + 2);
            yPos += lineHeight * 4;

            DrawBillLine("Total Receivable:", totalReceivable, true);
            yPos += lineHeight;
            // Friendly Closing Message
            string thankYouMessage = "";
            graphics.DrawString(thankYouMessage, footerFont, Brushes.Black, leftMargin, yPos);
            DrawQRCode(graphics, leftMargin, yPos, totalReceivable);
        }

        private void DrawQRCode(Graphics graphics, float leftMargin, float yPos, decimal totalAmount)
        {
            try
            {
                string upiId = ConfigurationManager.AppSettings["UPI_ID"];
                string payeeName = ConfigurationManager.AppSettings["PayeeName"];

                // Format the amount with exactly 2 decimal places, no rounding
                string formattedAmount = totalAmount.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);

                // Create UPI URL with fixed amount - note the 'am' parameter format
                string upiData = $"upi://pay?pa={upiId}&pn={payeeName}&am={formattedAmount}&cu=INR&tn=Payment";

                using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(upiData, QRCodeGenerator.ECCLevel.Q);
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap qrCodeImage = qrCode.GetGraphic(5);
                        // Draw the QR code on the print page
                        graphics.DrawImage(qrCodeImage, leftMargin, yPos, 100, 100);

                        // Draw the "Scan and Pay" message with amount below the QR code
                        yPos += 110;
                        Font messageFont = new Font("Arial", 10, FontStyle.Bold);
                        graphics.DrawString($"Scan and Pay ₹{formattedAmount}", messageFont, Brushes.Black, leftMargin, yPos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            PrintBill();
           
        }

      


        private void PrintBill()
        {
            string[] parts = ddlTablename.Text.Split(' ');

            // Ensure there are at least two parts to avoid an error
            string Tablename = parts.Length > 0 ? parts[0] : string.Empty;
            string TablePosition = parts.Length > 1 ? parts[1] : string.Empty;
            int TableID = GetTableId(Tablename);



            List<Order> Listord = Order.LstRetrieveByTableAndPosition(TableID, TablePosition);

            Order ord = Order.LstRetrieveByTableAndPosition(TableID, TablePosition)
                .FirstOrDefault(o => o.Status == BillStatus.Ordered|| o.Status == BillStatus.Billed);

            if (ord != null && ord.Status != BillStatus.Settled)
            {
                if (ord.Status == BillStatus.Ordered)
                {
                    isDuplicatePrint = false;
                }
                else
                {
                    isDuplicatePrint = true;
                    //MessageBox.Show("Record not found for printing.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //return;
                }

                bool isUpdated = Order.UpdateOrderStatus(ord.Id, BillStatus.Billed);
                if (isUpdated)
                {
                    if (chkPreviewPrint.Checked)
                    {
                        // Create and configure the PrintPreviewDialog
                        PrintPreviewDialog previewDialog = new PrintPreviewDialog
                        {
                            Document = printDocument,
                            Width = 800,
                            Height = 600,
                            KeyPreview = true // Enable keyboard events for the dialog
                        };

                        previewDialog.PrintPreviewControl.Zoom = 1.0;

                        // Handle keyboard shortcuts in the dialog
                        previewDialog.KeyDown += (s, keyEventArgs) =>
                        {
                            if (keyEventArgs.KeyCode == Keys.Escape)
                            {
                                previewDialog.Close(); // Close the preview with the Escape key
                            }
                        };

                        // Show the print preview dialog
                        previewDialog.ShowDialog();

                        // Display a confirmation dialog for printing
                        DialogResult result = MessageBox.Show(
                            "Do you want to proceed to print?",
                            "Confirmation",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1 // Default to "OK"
                        );

                        // Handle the result of the confirmation dialog
                        if (result == DialogResult.OK)
                        {
                            // Print the document
                            printDocument.Print();
                        }
                        else
                        {
                            // Notify the user about the cancellation
                            MessageBox.Show("Printing has been cancelled.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        // Directly print the document without showing the preview
                        printDocument.Print();
                    }
                }

            }

            pageSetUp();
            SetUpGrdBillSetUp();
            clearAmount();
        }

        private void rdoStatusBilled_CheckedChanged(object sender, EventArgs e)
        {
            string status = BillStatus.Billed;
            SetUpBillingGrid(status);
        }

        private void rdoStatusSettled_CheckedChanged(object sender, EventArgs e)
        {
            string status = BillStatus.Settled;
            SetUpBillingGrid(status);
        }

        

        private void btnSettleOrder_Click(object sender, EventArgs e)
        {
            SettleOrder();
        }

        private void SettleOrder()
        {
            string[] parts = ddlTablename.Text.Split(' ');
            bool result = false;

            // Ensure there are at least two parts to avoid an error
            string Tablename = parts.Length > 0 ? parts[0] : string.Empty;
            string TablePosition = parts.Length > 1 ? parts[1] : string.Empty;
            int TableID = GetTableId(Tablename);

            string status = BillStatus.Billed;

            // Retrieve order based on table ID and position
            Order ord = Order.RetrieveByTableAndPosition(TableID, TablePosition, status);

            if (ord != null)
            {
                // Settle the order
                result = settleOrder(ord.Id, BillStatus.Settled);
            }

            // Show the appropriate message
            if (result)
            {
                MessageBox.Show("The order has been successfully settled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to settle the order. Check if its billed and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pageSetUp();
            SetUpGrdBillSetUp();
            clearAmount();

          
            
        }

        protected bool settleOrder(int orderId,string status)
        {

            bool result = false;
            result = Order.UpdateOrderStatus(orderId, status);
            return result;
        }

      
        protected void clearAmount()
        {
            lblBillTotal.Text = "0";
            lblTotalItems.Text = "0";
            lblNonTaxCharges.Text = "0";
            lblReceipts.Text = "0";
            lblBillingTotal.Text = "0";
            lblRoundOffAmount.Text = "0";

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1)
            {
               
                return true;
            }
            else if (keyData == Keys.F2)
            {
                PrintBill();
                return true;
            }
            else if (keyData == Keys.F4)
            {
                SettleOrder();
                return true;
            }
           

            return base.ProcessCmdKey(ref msg, keyData);
        }

        
    }
}
