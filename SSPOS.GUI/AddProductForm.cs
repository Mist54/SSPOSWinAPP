using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SSPOS.BLL;
using SSPOS.GUI.Shared;

namespace SSPOS.GUI
{
    public partial class AddProductForm : Form
    {
        private List<Product> productList;
        private List<Product> filteredProductList;
        string loggedInUser = SessionManager.UserName;

        private bool _isFormLoaded = false;

        public AddProductForm()
        {
            InitializeComponent();
            SetUpGrid();
            populateCatogory();

            //Setup
            ddlCategory.SelectedIndex = -1;
            ddlSubCatogory.SelectedIndex = -1;
            ddlSubCatogory.Enabled = false;
            ddlUOMs.SelectedIndex = -1;
            ddlUOMs.Enabled = false;
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            _isFormLoaded = true;
            ddlCategory.Focus();
        }

        private void SetUpGrid()
        {
            // Bind the product list to the DataGridView
            productList = Product.RetrieveAll(loggedInUser);

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

        private void grdProduct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Additional adjustments after data binding is complete, if needed
            // For now, it will just confirm the grid is filled and ready
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchGrid();
        }

        protected void searchGrid()
        {
            string searchTerm = txtSearch.Text.ToLower(); // Get the search term and convert to lower case
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // If the search term is empty, reset the filtered list to the original list
                filteredProductList = new List<Product>(productList);
            }
            else
            {
                // Filter the product list based on the search term
                filteredProductList = productList
                    .Where(p => p.ProductName.ToLower().Contains(searchTerm) ||
                                 p.Code.ToString().ToLower().Contains(searchTerm) ||
                                 p.UOM.ToLower().Contains(searchTerm))
                    .ToList();
            }

            grdProduct.DataSource = filteredProductList;
            grdProduct.Refresh();
        }

        private void populateCatogory()
        {
            List<Category> category = Category.RetrieveAll(true);
            ddlCategory.DataSource = category;
            ddlCategory.DisplayMember = "CategoryName";
            ddlCategory.ValueMember = "Id";
            ddlCategory.Refresh();
        }

        private void populateSubCategory(string category)
        {
            ddlSubCatogory.Enabled = true;
            ddlSubCatogory.SelectedIndex = -1;
            List<Category> subCatogory = Category.RetrieveByCategory(category,true);
            ddlSubCatogory.DataSource = subCatogory;
            ddlSubCatogory.DisplayMember = "Subcategory";
            ddlSubCatogory.ValueMember = "Id";
            ddlSubCatogory.Refresh();

        }

        private void populateEOMs(string subCategory, string category)
        {
            ddlUOMs.Enabled = true;
            ddlUOMs.SelectedIndex = -1;
            List<Category> UOMs = Category.RetrieveBySubcategory(subCategory, category, true);
            ddlUOMs.DataSource = UOMs;
            ddlUOMs.DisplayMember = "UOM";
            ddlUOMs.ValueMember = "Id";
            ddlUOMs.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchGrid();
        }

        private void ddlCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ddlCategory.SelectedItem != null)
            {
                var selectedCategoryName = ((Category)ddlCategory.SelectedItem).CategoryName;
                populateSubCategory(selectedCategoryName);

                txtProductname.Focus();

            }


        }

        private void ddlSubCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (ddlSubCatogory.SelectedItem != null && ddlCategory.SelectedItem != null )
            {
                var selectedSubcategory = ((Category)ddlSubCatogory.SelectedItem).Subcategory;
                var selectedCategoryName = ((Category)ddlCategory.SelectedItem).CategoryName;
                populateEOMs(selectedSubcategory, selectedCategoryName);

            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void SaveProduct()
        {
            try
            {
                // Validate and trim product name
                string productName = txtProductname.Text.Trim();
                if (string.IsNullOrEmpty(productName))
                {
                    Master.ShowError("Product name is required.");
                    return;
                }

                // Validate and parse numeric fields
                if (!TryParseInt(txtProductCode.Text, out int productCode, "Invalid product code.") ||
                    !TryParseDecimal(txtMRP.Text, out decimal MRPPrice, "Invalid MRP Price.") ||
                    !TryParseDecimal(txtRegularPrice.Text, out decimal RegularPrice, "Invalid Regular Price.") ||
                    !TryParseDecimal(txtOutsidePrice.Text, out decimal OutsidePrice, "Invalid Outside Price.") ||
                    !TryParseDecimal(txtDirectPrice.Text, out decimal DirectPrice, "Invalid Direct Price."))
                {
                    return;
                }

                // Validate category, subcategory, and UOM selection
                var selectedCategory = ddlCategory.SelectedItem as Category;
                var selectedSubcategory = ddlSubCatogory.SelectedItem as Category;
                var selectedUOM = ddlUOMs.SelectedItem as Category;

                if (selectedCategory == null || selectedSubcategory == null || selectedUOM == null)
                {
                    Master.ShowError("Please select valid category, subcategory, and UOM.");
                    return;
                }

                // Retrieve category ID
                int? categoryId = Category.RetrieveID(selectedCategory.CategoryName, selectedSubcategory.Subcategory, selectedUOM.UOM);
                if (categoryId == null)
                {
                    Master.ShowError("Invalid category combination.");
                    return;
                }

                // Create the product
                try
                {
                    Product prd = Product.RetrieveByCode(SessionManager.UserName, productCode);
                    if (prd == null)
                    {
                        Product.Create(productName, productCode, MRPPrice, categoryId, RegularPrice, DirectPrice, OutsidePrice, SessionManager.UserName);
                        Master.ShowMessageBox("Product saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Master.ShowMessageBox("Cannot save product with same productcode.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                // Refresh the product grid
                SetUpGrid();


            }
            catch (Exception ex)
            {
                Master.ShowError($"An error occurred: {ex.Message}");
            }
        }


        // Helper method for integer parsing with error messaging
        private bool TryParseInt(string input, out int result, string errorMessage)
        {
            if (!int.TryParse(input.Trim(), out result))
            {
                 Master.ShowError(errorMessage);
                return false;
            }
            return true;
        }

        // Helper method for decimal parsing with error messaging
        private bool TryParseDecimal(string input, out decimal result, string errorMessage)
        {
            if (!decimal.TryParse(input.Trim(), out result))
            {
                 Master.ShowError(errorMessage);
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ProductUpdate();
        }

        private void ProductUpdate()
        {
            try
            {
                // Validate and retrieve values from the input controls
                string productName = txtProductname.Text.Trim();
                if (string.IsNullOrEmpty(productName))
                {
                    MessageBox.Show("Product name is required.");
                    return;
                }

                int productCode = TryParseInt(txtProductCode.Text, "Invalid product code.");
                if (productCode == 0) return;

                decimal MRPPrice = TryParseDecimal(txtMRP.Text, "Invalid MRP Price.");
                if (MRPPrice == 0) return;

                decimal RegularPrice = TryParseDecimal(txtRegularPrice.Text, "Invalid Regular Price.");
                if (RegularPrice == 0) return;

                decimal OutsidePrice = TryParseDecimal(txtOutsidePrice.Text, "Invalid Outside Price.");
                if (OutsidePrice == 0) return;

                decimal DirectPrice = TryParseDecimal(txtDirectPrice.Text, "Invalid Direct Price.");
                if (DirectPrice == 0) return;

                // Retrieve selected items from dropdowns
                var selectedCategory = ddlCategory.SelectedItem as Category;
                var selectedSubcategory = ddlSubCatogory.SelectedItem as Category;
                var selectedUOM = ddlUOMs.SelectedItem as Category;

                // Ensure category, subcategory, and UOM are selected
                if (selectedCategory == null || selectedSubcategory == null || selectedUOM == null)
                {
                    Master.ShowError("Please select valid category, subcategory, and UOM.");
                    return;
                }

                // Retrieve category ID based on selected values
                int? categoryId = Category.RetrieveID(selectedCategory.CategoryName, selectedSubcategory.Subcategory, selectedUOM.UOM);
                if (categoryId == null)
                {
                    Master.ShowError("Invalid category combination.");
                    return;
                }

                // Current username for auditing purposes
                string updatedBy = SessionManager.UserName;
                Product prd = Product.RetrieveByCode(SessionManager.UserName, productCode);
                if (prd != null)
                {
                    // Update the product
                    int result = Product.Update(SessionProduct.ProductId, productName, productCode, MRPPrice, categoryId,
                        RegularPrice, DirectPrice, OutsidePrice, updatedBy);
                    if (result > 0)
                    {
                        Master.ShowMessageBox("Product updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Master.ShowError("Error while updating the product. Contact the admin.");
                    }


                }
                else
                {
                    Master.ShowMessageBox("Product not found with product code " + txtProductCode.Text.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                SetUpGrid();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Violation of UNIQUE KEY constraint"))
                {
                    Master.ShowError("The product code already exists. Please use a unique code.");
                }
                else
                {
                    Master.ShowError($"An error occurred: {ex.Message}");
                }
            }
        }

        // Helper methods for parsing integers and decimals with error handling
        private int TryParseInt(string input, string errorMessage)
        {
            if (!int.TryParse(input.Trim(), out int result))
            {
                Master.ShowError(errorMessage);
                return 0;
            }
            return result;
        }

        private decimal TryParseDecimal(string input, string errorMessage)
        {
            if (!decimal.TryParse(input.Trim(), out decimal result))
            {
                Master.ShowError(errorMessage);
                return 0;
            }
            return result;
        }


        private void btnCodePopulate_Click(object sender, EventArgs e)
        {

            PopulateProduct();


        }

        protected void PopulateProduct()
        {
            if (!int.TryParse(txtProductCode.Text.Trim(), out int productCode))
            {
                Master.ShowMessageBox("Please enter a valid product code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Product prd = Product.RetrieveByCode(SessionManager.UserName, productCode);

            if (prd != null)
            {

                txtProductname.Text = prd.ProductName;
                txtMRP.Text = prd.MRP.ToString();
                txtRegularPrice.Text = prd.RegularPrice.ToString();
                txtOutsidePrice.Text = prd.OutsidePrice.ToString();
                txtDirectPrice.Text = prd.DirectPrice.ToString();

                // Assuming Category, Subcategory, and UOM are also properties of the Product
                ddlCategory.SelectedItem = ddlCategory.Items.Cast<Category>().FirstOrDefault(c => c.CategoryName == prd.CategoryName);
                ddlSubCatogory.SelectedItem = ddlSubCatogory.Items.Cast<Category>().FirstOrDefault(sc => sc.Subcategory == prd.Subcategory);
                ddlUOMs.SelectedItem = ddlUOMs.Items.Cast<Category>().FirstOrDefault(uom => uom.UOM == prd.UOM);


                // Tag the Product ID for future reference
                txtProductname.Tag = prd.Id;
                SessionProduct.ProductId = prd.Id;
                // Disable the Save button if editing an existing record
                btnSave.Enabled = false;

            }
            else
            {
                // Show warning if product is not found
                Master.ShowMessageBox("Product not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();

            
        }

        protected void clearForm()
        {
            // Clear textboxes
            txtProductname.Text = string.Empty;
            txtProductCode.Text = string.Empty;
            txtMRP.Text = string.Empty;
            txtRegularPrice.Text = string.Empty;
            txtOutsidePrice.Text = string.Empty;
            txtDirectPrice.Text = string.Empty;

            // Reset dropdown selections to default (null or first item)
            ddlCategory.SelectedIndex = -1;
            ddlSubCatogory.SelectedIndex = -1;
            ddlUOMs.SelectedIndex = -1;

            ddlSubCatogory.Enabled = false;
            ddlUOMs.Enabled = false;

            btnSave.Enabled = true;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void DeleteProduct()
        {
            // Check if required fields are empty
            if (string.IsNullOrEmpty(txtProductname.Text) &&
                string.IsNullOrEmpty(txtProductCode.Text) &&
                string.IsNullOrEmpty(txtMRP.Text) &&
                string.IsNullOrEmpty(txtRegularPrice.Text) &&
                string.IsNullOrEmpty(txtOutsidePrice.Text) &&
                ddlCategory.SelectedIndex == -1 &&
                ddlSubCatogory.SelectedIndex == -1 &&
                ddlUOMs.SelectedIndex == -1)
            {
                Master.ShowError("Please fill or populate all the record first.");
                btnCodePopulate.Focus();
                return;
            }

            // Confirm deletion
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this product?",
                                                        "Confirm Deletion",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                // Check if a valid product ID is assigned to txtProductname.Tag
                if (txtProductname.Tag is int productId && productId > 0)
                {
                    bool prdDelete = Product.DeleteProductById(loggedInUser, productId);
                    if (prdDelete)
                    {
                        Master.ShowWarning("Product deleted successfully.");
                    }
                    else
                    {
                        Master.ShowError("Failed to delete the product. Please try again.");
                    }
                    SetUpGrid();
                    grdProduct.Refresh();
                    clearForm();
                }
                else
                {
                    Master.ShowError("Invalid product ID. Please ensure the record is correctly populated.");
                }
            }
        }

        private void AddProductForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F)
            {
                txtSearch.Focus();
            }
        }

        private void grdProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = grdProduct.Rows[e.RowIndex];


                int productCode = Convert.ToInt32(row.Cells["Code"].Value);


                txtProductCode.Text = productCode.ToString();
                PopulateProduct();
            }
        }

        //Override the globle key process to identify and capture the keystrokes
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //F1 Key pressed ->For save
            if (keyData == Keys.F1)
            {
                SaveProduct();
                return true;
            }
            else if (keyData == Keys.F3)
            {
                clearForm();  
                return true;
            }
            else if (keyData == Keys.F5)
            {
                DeleteProduct();
            }
            else if (keyData == Keys.F2)
            {
                if (this.ActiveControl !=txtSearch )
                {
                    // Set focus to txtCode
                    txtSearch.Focus();
                }
                else
                {
                    searchGrid();
                }
            }
            else if(keyData == Keys.F4)
            {
                ProductUpdate();
            }
            else if(keyData == Keys.F6)
            {
                PopulateProduct();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtProductname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtProductCode.Focus();
            }
        }

        private void txtMRP_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtRegularPrice.Focus();
            }
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtMRP.Focus();
            }
        }

        private void txtRegularPrice_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtDirectPrice.Focus();
            }
        }

        private void txtDirectPrice_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtOutsidePrice.Focus();
            }
        }
    }
}
