using MaterialSkin.Controls;
using SSPOS.BLL;
using System;
using System.Windows.Forms;
using SSPOS.GUI.Shared;
namespace SSPOS.GUI
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();


            //Removes the related page for user
            SystemUser systemUser = SystemUser.RetrieveByUserName(SessionManager.UserName);
            if (systemUser != null)
            {
                if (systemUser.Role > 1)
                {
                    MainTabControl.TabPages.Remove(StockManagementPage);
                }

            }
            setDashboardPage();


        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainTabControl.Focus();
            
        }


        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Message = "";
            string caption = "";
            // Check if the selected tab is the "Logout" tab
            if (MainTabControl.SelectedTab == LogoutPage)
            {
                Message = "Are you sure you want to logout?";
                caption = "Logout Confirmation";
                DialogResult result = Master.ShowMessageBox(Message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Resets the property before log out
                    //Properties.Settings.Default.Reset();
                    //Properties.Settings.Default.Save();

                    Message = "You logged out successfully";
                    caption = "Logout Confirmation";
                    Master.ShowMessageBox(Message, caption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MainTabControl.SelectedIndex = 0;//Set the first tab as default
                    // Ensure the correct tab is selected
                    MainTabControl.SelectedTab = HomePage;
                }
            }
            else if (MainTabControl.SelectedTab == StockManagementPage)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else if (MainTabControl.SelectedTab == OrderPage)
            {
                LoaderManager.Show("Setting up the orders please wait ...!"); //Shows the loader
                // Remove any existing controls from OrderPage
                if (OrderPage.Controls.Count > 0)
                {
                    var existingControl = OrderPage.Controls[0];
                    OrderPage.Controls.Remove(existingControl);
                    existingControl.Dispose(); // Dispose of the existing control to free resources
                }

                // Initialize the OrderForm and configure it
                OrderForm orderForm = new OrderForm
                {
                    TopLevel = false,
                    ControlBox = false,                   // Hide the control box
                    FormBorderStyle = FormBorderStyle.None, // Remove borders
                    Dock = DockStyle.Fill,                // Fill the tab page fully
                    AutoScaleMode = AutoScaleMode.None,   // Prevent scaling issues
                };

                // Remove any padding or margin from both the form and tab page
                OrderPage.Padding = new Padding(0);
                OrderPage.Margin = new Padding(0);
                orderForm.Padding = new Padding(0);
                orderForm.Margin = new Padding(0);

                // Add OrderForm to OrderPage tab
                OrderPage.Controls.Add(orderForm);
                orderForm.Show(); // Display the form

                // Ensure the correct tab is selected
                MainTabControl.SelectedTab = OrderPage;
            }
            else if (MainTabControl.SelectedTab == BillingPage)
            {
                LoaderManager.Show("Setting up the bills Please wait ...!"); //Shows the loader
                // Remove any existing controls from BillingPage
                if (BillingPage.Controls.Count > 0)
                {
                    var existingControl = BillingPage.Controls[0];
                    BillingPage.Controls.Remove(existingControl);
                    existingControl.Dispose(); // Dispose of the existing control to free resources
                }

                // Initialize the BillingForm and configure it
                BillingForm billingForm = new BillingForm
                {
                    TopLevel = false,
                    ControlBox = false,                   // Hide the control box
                    FormBorderStyle = FormBorderStyle.None, // Remove borders
                    Dock = DockStyle.Fill,                // Fill the tab page fully
                    AutoScaleMode = AutoScaleMode.None,   // Prevent scaling issues
                };

                // Remove any padding or margin from both the form and tab page
                BillingPage.Padding = new Padding(0);
                BillingPage.Margin = new Padding(0);
                billingForm.Padding = new Padding(0);
                billingForm.Margin = new Padding(0);

                // Add BillingForm to BillingPage tab
                BillingPage.Controls.Add(billingForm);
                billingForm.Show(); // Display the form

                // Ensure the correct tab is selected
                MainTabControl.SelectedTab = BillingPage;
            }
            else if(MainTabControl.SelectedTab == HomePage)
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
            MainTabControl.SelectedTab = HomePage;
        }
    }
}

