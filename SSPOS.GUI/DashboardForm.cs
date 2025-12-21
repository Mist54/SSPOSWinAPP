using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSPOS.GUI.Shared;
using SSPOS.BLL;
using MaterialSkin.Controls;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace SSPOS
{
    public partial class DashboardForm : Form
    {
        private List<Report> lstReport;
        private string restaurantName;

        public DashboardForm()
        {
            InitializeComponent();
            pageSetUp();
           
        }

        public void pageSetUp()
        {
            lblDashboardTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            SystemUser systemUser = SystemUser.RetrieveByUserName(SessionManager.UserName);

            if (systemUser != null)
            {
                List<SystemUser> waiterCount = SystemUser.RetrieveByUserRole(RoleStatus.Waiter);
                lblWaiterCount.Text = waiterCount.Count.ToString();

                List<Product> productCount = Product.RetrieveAll(systemUser.Name);
                lblProductCount.Text = productCount.Count.ToString();

                List<Order> orderCount = Order.RetrieveAll();
                lblTodayOrderCount.Text = orderCount.Count.ToString();

                lblloggedInUser.Text = systemUser.Name.ToString();


                if (systemUser.Role == 0) // Super User
                {
                    lblLoggedInUserRole.Text = "Super User";
                    lblLoggedInUserRole.ForeColor = Color.MediumVioletRed; // A bold color for high importance
                }
                else if (systemUser.Role == 1) // Admin
                {
                    lblLoggedInUserRole.Text = "Admin";
                    lblLoggedInUserRole.ForeColor = Color.Teal; // Professional and calm
                }
                else if (systemUser.Role == 3) // Waiter
                {
                    lblLoggedInUserRole.Text = "Waiter";
                    lblLoggedInUserRole.ForeColor = Color.DodgerBlue; // Friendly and service-oriented
                }
                else if (systemUser.Role == 2) // Manager (assuming Manager is 2)
                {
                    lblLoggedInUserRole.Text = "Manager";
                    lblLoggedInUserRole.ForeColor = Color.Orange;
                }


                List<SystemUser> lstSystemUser = SystemUser.RetrieveAll("");
                PopulateUserCards(lstSystemUser, flpSystemUsers);

                List<Category> lstCategories = Category.RetrieveAll(false);
                lstCategories = lstCategories.GroupBy(c => c.CategoryName).Select(g => g.First()).ToList();


                BindChartProductCategory(productCount, lstCategories);

                string ResturentName = ConfigManager.Settings.RestaurantName;
                string Owner = ConfigManager.Settings.Owner;
                string ContactNumber = ConfigManager.Settings.Contact;
            }

        }

        public void PopulateUserCards(List<SystemUser> users, FlowLayoutPanel flowPanel)
        {
            // Clear previous cards
            flowPanel.Controls.Clear();

            foreach (var user in users)
            {
                // Determine role using if-else
                string roleName = "Unknown";
                if (user.Role == 0) roleName = "SuperUser";
                else if (user.Role == 1) roleName = "SystemAdmin";
                else if (user.Role == 2) roleName = "Manager";
                else if (user.Role == 3) roleName = "Waiter";

                // Create Material Card
                MaterialCard card = new MaterialCard
                {
                    Width = 320,
                    Height = 180,
                    BackColor = Color.White,
                    Padding = new Padding(15),
                    Margin = new Padding(5),
                  
                };

                // Name Label (Bold and Bigger)
                Label lblName = new Label
                {
                    Text = user.Name,
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true,
                    ForeColor = Color.FromArgb(33, 37, 41) // Darker text color
                };

                // Email Label (Subtle and smaller)
                Label lblEmail = new Label
                {
                    Text = user.Email,
                    Font = new Font("Arial", 10, FontStyle.Italic),
                    Location = new Point(10, 40),
                    AutoSize = true,
                    ForeColor = Color.Gray
                };

                // Role Label (Different Color Based on Role)
                Label lblRole = new Label
                {
                    Text = $"Role: {roleName}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 70),
                    AutoSize = true,
                    ForeColor = GetRoleColor(user.Role) // Different colors for roles
                };

                // Active/Inactive Label (Highlighted in Green/Red)
                Label lblStatus = new Label
                {
                    Text = user.IsActive ? "Active" : "Inactive",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 100),
                    AutoSize = true,
                    ForeColor = user.IsActive ? Color.Green : Color.Red
                };

                // Created Date Label (Styled for Readability)
                Label lblCreated = new Label
                {
                    Text = $"Created: {user.CreatedDate:MMM dd, yyyy}",
                    Font = new Font("Arial", 9, FontStyle.Regular),
                    Location = new Point(10, 130),
                    AutoSize = true,
                    ForeColor = Color.DimGray
                };

                // Add controls to card
                card.Controls.Add(lblName);
                card.Controls.Add(lblEmail);
                card.Controls.Add(lblRole);
                card.Controls.Add(lblStatus);
                card.Controls.Add(lblCreated);

                // Add card to FlowLayoutPanel
                flowPanel.Controls.Add(card);
            }
        }


        private Color GetRoleColor(int role)
        {
            if (role == 0) return Color.DarkBlue;  // SuperUser
            if (role == 1) return Color.DarkRed;   // SystemAdmin
            if (role == 2) return Color.DarkGreen; // Manager
            if (role == 3) return Color.DarkOrange; // Waiter
            return Color.Black;
        }

        private void BindChartProductCategory(List<Product> products, List<Category> categories)
        {
            // Clear existing series to avoid duplication
            chartProductCatogory.Series.Clear();

            // Create a new Series
            Series series = new Series("Product Categories");
            series.ChartType = SeriesChartType.Column; 

            // Group Products by Category and Sum Quantities
            foreach (var category in categories)
            {
                int productCount = products.Count(p => p.CategoryId == category.Id);

                // Add category name and product count to chart
                series.Points.AddXY(category.CategoryName, productCount);
            }

            // Add Series to Chart
            chartProductCatogory.Series.Add(series);

            // Set Chart Title
            chartProductCatogory.Titles.Clear();
            chartProductCatogory.Titles.Add("Products by Category");

            // Customize appearance (optional)
            series.IsValueShownAsLabel = true; // Show values on bars
            chartProductCatogory.ChartAreas[0].AxisX.Title = "Categories";
            chartProductCatogory.ChartAreas[0].AxisY.Title = "Total Quantity";

            StyleMaterialChart(chartProductCatogory);
        }

        private void StyleMaterialChart(Chart chart)
        {
            if (chart.ChartAreas.Count == 0 || chart.Series.Count == 0)
                return;

            // Material Design Background (Flat and Clean)
            chart.BackColor = Color.White;
            chart.ChartAreas[0].BackColor = Color.White;

            // Axis Font & Style (Flat Look)
            chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            chart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DimGray;
            chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DimGray;

            // Remove grid lines for a clean, flat appearance
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            // Customize the series for a Material Design feel
            foreach (var series in chart.Series)
            {
                series.ChartType = SeriesChartType.Column; // Use Column or Line for a clean look
                series.Color = Color.FromArgb(33, 150, 243); // Material Blue
                series.BorderWidth = 0; // Flat look
                series.IsValueShownAsLabel = true; // Show values on bars
                series.Font = new Font("Arial", 10, FontStyle.Bold);
                series.LabelForeColor = Color.Black;
                series.LabelBackColor = Color.Transparent;
            }

            // Smooth rendering
            chart.AntiAliasing = AntiAliasingStyles.All;
            chart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

            // Modern legend style
            chart.Legends.Clear();
            Legend legend = new Legend
            {
                Docking = Docking.Top,
                Font = new Font("Arial", 10, FontStyle.Bold),
                BackColor = Color.Transparent
            };
            chart.Legends.Add(legend);
        }

       


    }
}
