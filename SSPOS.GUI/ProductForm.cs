using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SSPOS.BLL;
using SSPOS.GUI.Shared;

namespace SSPOS.GUI
{
    public partial class ProductForm : Form
    {
        private List<Product> productList;
        private object originalCellValue;
        string loggedInUser = SessionManager.UserName;

        public ProductForm()
        {
            InitializeComponent();

            populateProductDropdown();
            SetupGrid();
            grdProduct.DataBindingComplete += grdProduct_DataBindingComplete;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ddlProductnames.Focus();
        }

        private void SetupGrid()
        {
            if(productList.Count == 0)
            {
                // Bind the product list to the DataGridView
                productList = Product.RetrieveAll(SessionManager.UserName);

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
            CustomizeGrid();
        }

        private void populateProductDropdown()
        {
            List<Product> lstProduct = Product.RetrieveAll(SessionManager.UserName);
            ddlProductnames.DataSource = lstProduct;
            ddlProductnames.DisplayMember = "ProductName";
            ddlProductnames.ValueMember = "Id";
            ddlProductnames.Refresh();
            ddlProductnames.SelectedIndex = -1;
        }

        private void grdProduct_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Store the original cell value before editing starts
            originalCellValue = grdProduct[e.ColumnIndex, e.RowIndex].Value;
        }

        private void grdProduct_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            bool isInvalidInput = false;

            // Check if the column is "Code" and validate as integer
            if (grdProduct.Columns[e.ColumnIndex].Name == "Code")
            {
                if (!int.TryParse(Convert.ToString(e.FormattedValue), out int code) || code < 0)
                {
                    MessageBox.Show("Enter only positive integer values in the Code section.", "Invalid Input");
                    e.Cancel = true;
                    isInvalidInput = true;
                }
                else
                {
                    // Check for duplicate code in other rows
                    foreach (DataGridViewRow row in grdProduct.Rows)
                    {
                        if (row.Index != e.RowIndex && row.Cells["Code"].Value != null &&
                            (int)row.Cells["Code"].Value == code)
                        {
                            MessageBox.Show("A product with this code already exists. Please enter a unique code.", "Duplicate Code");
                            e.Cancel = true;
                            isInvalidInput = true;
                            break;
                        }
                    }
                }
            }
            // Validate price columns
            else if (grdProduct.Columns[e.ColumnIndex].Name == "MRP" ||
                     grdProduct.Columns[e.ColumnIndex].Name == "RegularPrice" ||
                     grdProduct.Columns[e.ColumnIndex].Name == "OutsidePrice" ||
                     grdProduct.Columns[e.ColumnIndex].Name == "DirectPrice")
            {
                if (!decimal.TryParse(Convert.ToString(e.FormattedValue), out decimal price) || price < 0)
                {
                    MessageBox.Show("Enter only positive decimal values in the selected price section.", "Invalid Input");
                    e.Cancel = true;
                    isInvalidInput = true;
                }
            }

            // Restore original value if validation fails
            if (e.Cancel && originalCellValue != null && isInvalidInput)
            {
                grdProduct[e.ColumnIndex, e.RowIndex].Value = originalCellValue;
            }
        }
        private void grdProduct_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear originalCellValue after editing ends to avoid accidental reuse
            originalCellValue = null;
           
        }

        private void CustomizeGrid()
        {
            // Customize the header appearance
            grdProduct.EnableHeadersVisualStyles = false;
            grdProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 71, 79);
            grdProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdProduct.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16F, FontStyle.Bold);

            // Apply general row styles
            grdProduct.DefaultCellStyle.Font = new Font("Arial", 16F, FontStyle.Regular);
            grdProduct.DefaultCellStyle.SelectionBackColor = Color.FromArgb(179, 229, 252);
            grdProduct.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Enable sorting for specific columns
            grdProduct.Columns["ProductName"].SortMode = DataGridViewColumnSortMode.Automatic;
            grdProduct.Columns["MRP"].SortMode = DataGridViewColumnSortMode.Automatic;

            // Customize editable and non-editable columns
            grdProduct.Columns["MRP"].DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            grdProduct.Columns["RegularPrice"].DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            grdProduct.Columns["DirectPrice"].DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            grdProduct.Columns["OutsidePrice"].DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            grdProduct.Columns["ProductName"].DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            grdProduct.Columns["UOM"].DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            grdProduct.Columns["Code"].DefaultCellStyle.SelectionBackColor = Color.LightGreen;
            grdProduct.Columns["Subcategory"].DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            grdProduct.Columns["CategoryName"].DefaultCellStyle.SelectionBackColor = Color.DarkGray;


            // Disable grid lines and set alternating row colors
            grdProduct.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdProduct.GridColor = Color.FromArgb(224, 224, 224);
            grdProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        
        private void grdProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (grdProduct.IsHandleCreated)
            {
                grdProduct.BeginInvoke((MethodInvoker)delegate
                {
                    grdProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    CustomizeGrid();
                    grdProduct.AllowUserToAddRows = false;
                    grdProduct.AllowUserToDeleteRows = false;

                    // Set read-only status for specific columns
                    grdProduct.Columns["MRP"].ReadOnly = false;
                    grdProduct.Columns["OutsidePrice"].ReadOnly = false;
                    grdProduct.Columns["DirectPrice"].ReadOnly = false;
                    grdProduct.Columns["RegularPrice"].ReadOnly = false;
                    grdProduct.Columns["Code"].ReadOnly = false;
                    grdProduct.Columns["ProductName"].ReadOnly = true;
                    grdProduct.Columns["CategoryName"].ReadOnly = true;
                    grdProduct.Columns["Subcategory"].ReadOnly = true;
                    grdProduct.Columns["UOM"].ReadOnly = true;

                 

                    grdProduct.DataBindingComplete -= grdProduct_DataBindingComplete; // Unsubscribe
                });
            }
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            CheckCode();
        }

        private void CheckCode()
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                txtCode.Focus();
                return;
            }

            if (!int.TryParse(txtCode.Text.Trim(), out int code))
            {
                MessageBox.Show("Please enter a valid numeric code.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product existingProduct = IsCodeExists(code);
            if (existingProduct != null)
            {
                MessageBox.Show("This code already exists. Please choose another code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                lblCardProductName.Text = "Product name :" + "" + "" + existingProduct.ProductName;
                lblCardProductName.Visible = true;

                lblCardProductCode.Text = "Product code :" + "" + existingProduct.Code.ToString();
                lblCardProductCode.Visible = true;

                lblCardMessage.Text = "Make sure to update the existing code for the product.";
                lblCardMessage.ForeColor = Color.FromArgb(30, 144, 255);
                lblCardMessage.Visible = true;
                pnlSplit.Visible = true;
                txtCode.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("The code is available.", "Code Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected Product IsCodeExists(int code)
        {
           
            Product existingProduct = Product.RetrieveByCode(SessionManager.UserName, code);
            if(existingProduct == null)
            {
                
                return null;
            }
            else
            {
                return existingProduct;
            }
            
        }

        private void ddlProductnames_SelectedIndexChanged(object sender, EventArgs e)
        {
            productList = Product.RetrieveByProductName(SessionManager.UserName, ddlProductnames.Text.Trim());
            SetupGrid();
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveRecords();
        }

        protected void SaveRecords()
        {
            foreach (DataGridViewRow row in grdProduct.Rows)
            {
                // Only process rows that have been modified and are not the new row
                if (!row.IsNewRow && row.Tag != null && (bool)row.Tag == true)
                {
                    try
                    {
                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        decimal mrpValue = Convert.ToDecimal(row.Cells["MRP"].Value);
                        decimal outsidePriceValue = Convert.ToDecimal(row.Cells["OutsidePrice"].Value);
                        decimal directPriceValue = Convert.ToDecimal(row.Cells["DirectPrice"].Value);
                        decimal regularPriceValue = Convert.ToDecimal(row.Cells["RegularPrice"].Value);
                        int codeValue = Convert.ToInt32(row.Cells["Code"].Value);

                        // Perform the update operation
                        int updateResult = Product.UpdateCodeAndPrice(id, codeValue, mrpValue, regularPriceValue,
                                                                      directPriceValue, outsidePriceValue, loggedInUser);

                        // Show a success message only if the update was successful
                        if (updateResult > 0)
                        {
                            MessageBox.Show("Update Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            grdProduct.Refresh();
                            SetupGrid();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that may occur during the update
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        // Reset the tag after the update to avoid redundant updates
                        row.Tag = null;
                    }
                }
            }
        }

        private void grdProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Mark the entire row as modified if any cell changes
            if (e.RowIndex >= 0)
            {
                grdProduct.Rows[e.RowIndex].Tag = true; // Use Tag property to flag the row
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        protected void ClearForm()
        {
            ddlProductnames.SelectedIndex = -1;
            SetupGrid();
            lblCardProductCode.Visible = false;
            lblCardProductName.Visible = false;
            lblCardMessage.Visible = false;
            pnlSplit.Visible = false;
            txtCode.Text = "";
            
        }

        private void ProductForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if Alt + F is pressed
            if (e.Alt && e.KeyCode == Keys.F)
            {
                ddlProductnames.Focus();
            }
        }


        //Override the globle key process to identify and capture the keystrokes
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //F1 Key pressed ->For save
            if (keyData == Keys.F1)
            {
                SaveRecords();
                return true; 
            }
            else if(keyData == Keys.F3)
            {
                ClearForm();
                return true;
            }
            else if(keyData == Keys.F5)
            {

            }
            else if(keyData == Keys.F2)
            {
                if (this.ActiveControl != txtCode)
                {
                    // Set focus to txtCode
                    txtCode.Focus();
                }
                else
                {
                    CheckCode();
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
