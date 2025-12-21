using MaterialSkin.Controls;
using SSPOS.BLL;
using SSPOS.GUI.Shared;
using System;
using System.Linq;
using System.Windows.Forms;
namespace SSPOS.GUI
{
    public partial class AdminForm : MaterialForm
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            AdminTabControl.Focus();

            setDashboardPage();
        }


        private void AdminTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string message = "";
            string caption = "";

            // Check if the selected tab is the "Logout" tab
            if (AdminTabControl.SelectedTab == LogoutPage)
            {
                message = "Are you sure you want to logout?";
                caption = "Logout Confirmation";
                DialogResult result = Master.ShowMessageBox(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                   
                    message = "You logged out successfully";
                    caption = "Logout Confirmation";
                    Master.ShowMessageBox(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    AdminTabControl.SelectedIndex = 0; // Revert to the first tab if logout is canceled
                }
            }
            else if (AdminTabControl.SelectedTab == BillingPage)
            {
                // Navigate to the billing page
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

                

            }
            else if (AdminTabControl.SelectedTab == StockManagementPage)
            {
                // Create and configure the ProductForm
                ProductForm productForm = new ProductForm
                {
                    TopLevel = false,
                    ControlBox = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                    Padding = new Padding(0),
                    Margin = new Padding(0)
                };

                StockManagementPage.Padding = new Padding(0);
                StockManagementPage.Margin = new Padding(0);

                // Remove any existing controls from StockManagementPage
                if (StockManagementPage.Controls.Count > 0)
                    StockManagementPage.Controls.RemoveAt(0);
                try
                {
                    // Check if no resizing is in progress before adding controls
                    if (StockManagementPage.Controls.Count == 0 || !productForm.IsHandleCreated)
                    {
                        this.BeginInvoke((Action)(() =>
                        {
                            StockManagementPage.Controls.Add(productForm);
                            productForm.Visible = true;
                        }));
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"Error when loading the components:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}";
                    Master.ShowMessageBox(errorMessage, "Back-end Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                // Ensure the correct tab is selected
                this.AdminTabControl.SelectedTab = StockManagementPage;
            }
            else if (AdminTabControl.SelectedTab == ProductManagementPage)
            {
                // Remove any existing controls from ProductManagementPage
                if (ProductManagementPage.Controls.Count > 0)
                {
                    var existingControl = ProductManagementPage.Controls[0];
                    ProductManagementPage.Controls.Remove(existingControl);
                    existingControl.Dispose(); // Dispose of the existing control to free resources
                }

                // Initialize the AddProductForm and configure it
                AddProductForm addProductForm = new AddProductForm
                {
                    TopLevel = false,
                    ControlBox = false,                  // Hide the control box
                    FormBorderStyle = FormBorderStyle.None, // Remove borders
                    Dock = DockStyle.Fill,               // Fill the tab page fully
                    AutoScaleMode = AutoScaleMode.None,  // Prevent scaling issues
                };

                // Remove any padding or margin from both the form and tab page
                ProductManagementPage.Padding = new Padding(0);
                ProductManagementPage.Margin = new Padding(0);
                addProductForm.Padding = new Padding(0);
                addProductForm.Margin = new Padding(0);

                // Add AddProductForm to ProductManagementPage tab
                ProductManagementPage.Controls.Add(addProductForm);
                addProductForm.Show(); // Display the form

                // Ensure the correct tab is selected
                AdminTabControl.SelectedTab = ProductManagementPage;

            }
            else if (AdminTabControl.SelectedTab == ReportPage)
            {
                // Check if ReportForm is already added to avoid duplicates
                if (!ReportPage.Controls.OfType<ReportForm>().Any())
                {
                    // Initialize ReportForm and configure it
                    ReportForm reportForm = new ReportForm
                    {
                        TopLevel = false,
                        ControlBox = false,                  // Hide the control box
                        FormBorderStyle = FormBorderStyle.None, // Remove borders
                        Dock = DockStyle.Fill,               // Fill the tab page fully
                        AutoScaleMode = AutoScaleMode.None,  // Prevent scaling issues
                        Padding = new Padding(0),           // Remove padding
                        Margin = new Padding(0)             // Remove margin
                    };

                    // Add ReportForm to ReportPage tab
                    ReportPage.Controls.Add(reportForm);
                    reportForm.Show(); // Display the form
                }

                // Ensure the correct tab is selected
                AdminTabControl.SelectedTab = ReportPage;
            }
            else if (AdminTabControl.SelectedTab == addUserPage)
            {
                LoaderManager.Show("Setting up the page please wait ...!");
                // Check if ReportForm is already added to avoid duplicates
                if (!addUserPage.Controls.OfType<ReportForm>().Any())
                {
                    // Initialize ReportForm and configure it
                    AddUserForm addUserForm = new AddUserForm
                    {
                        TopLevel = false,
                        ControlBox = false,                  // Hide the control box
                        FormBorderStyle = FormBorderStyle.None, // Remove borders
                        Dock = DockStyle.Fill,               // Fill the tab page fully
                        AutoScaleMode = AutoScaleMode.None,  // Prevent scaling issues
                        Padding = new Padding(0),           // Remove padding
                        Margin = new Padding(0)             // Remove margin
                    };

                    
                    addUserPage.Controls.Add(addUserForm);
                    addUserForm.Show(); // Display the form
                }

                // Ensure the correct tab is selected
                AdminTabControl.SelectedTab = addUserPage;
            }

            else if (AdminTabControl.SelectedTab == HomePage)
            {
                setDashboardPage();
            }

        }


        private void setDashboardPage()
        {
            if (HomePage.Controls.Count > 0)
            {
                var existingControl = HomePage.Controls[0];
                HomePage.Controls.Remove(existingControl);
                existingControl.Dispose(); // Dispose of the existing control to free resources
            }

            // Initialize the BillingForm and configure it
            DashboardForm dashboard = new DashboardForm
            {
                TopLevel = false,
                ControlBox = false,                   // Hide the control box
                FormBorderStyle = FormBorderStyle.None, // Remove borders
                Dock = DockStyle.Fill,                // Fill the tab page fully
                AutoScaleMode = AutoScaleMode.None,   // Prevent scaling issues
            };

            // Remove any padding or margin from both the form and tab page
            HomePage.Padding = new Padding(0);
            HomePage.Margin = new Padding(0);
            dashboard.Padding = new Padding(0);
            dashboard.Margin = new Padding(0);

            // Add BillingForm to BillingPage tab
            HomePage.Controls.Add(dashboard);
            dashboard.Show(); // Display the form

            // Ensure the correct tab is selected
            AdminTabControl.SelectedTab = HomePage;
        }


    }
}
