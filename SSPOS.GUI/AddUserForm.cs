using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SSPOS.BLL;
using SSPOS.GUI.Shared;
using MaterialSkin.Controls;
using System.Linq;

namespace SSPOS
{
    public partial class AddUserForm : Form
    {
        private bool isPasswordVisible = false;

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

            pageSetUp();
            LoaderManager.Hide();


        }

        private void pageSetUp()
        {
            string searchTerm = string.Empty;
            SetUpGridUser(searchTerm);
            PopulateRoleDropdown();
        }

        private void SetUpGridUser(string searchTerm)
        {
            // Retrieve the users
            List<SystemUser> systemUsers = SystemUser.RetrieveAll(searchTerm);

            // First, transform your data to include the Designation
            var usersWithDesignation = systemUsers.Select(user => new {
                user.Id,
                user.Name,
                user.Email,
                user.CreatedDate,
                Designation = RoleStatus.getRole(user.Role)  // This creates the Designation property
            }).ToList();

            // Now bind the transformed data
            grdUsers.DataSource = new BindingSource(usersWithDesignation, null);

            // Hide unnecessary columns
            grdUsers.Columns["Id"].Visible = false;

            // Rename column headers
            grdUsers.Columns["Name"].HeaderText = "User Name";
            grdUsers.Columns["Email"].HeaderText = "Email Address";
            grdUsers.Columns["CreatedDate"].HeaderText = "Date Created";

            // Apply custom styling
            StyleUserGrid();
        }



        private void StyleUserGrid()
        {
            // General Grid Styling
            grdUsers.EnableHeadersVisualStyles = false;
            grdUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243); // Material Blue
            grdUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grdUsers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            grdUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdUsers.ColumnHeadersHeight = 40; // Increased header height for better readability

            // Row Styling
            grdUsers.DefaultCellStyle.BackColor = Color.White;
            grdUsers.DefaultCellStyle.ForeColor = Color.Black;
            grdUsers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(76, 175, 80); // Material Green for selection
            grdUsers.DefaultCellStyle.SelectionForeColor = Color.White;
            grdUsers.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            grdUsers.RowTemplate.Height = 35; // Adjust row height for better spacing

            // Alternating Row Colors
            grdUsers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // Soft light blue for alternate rows

            // Grid Border & Cell Appearance
            grdUsers.BorderStyle = BorderStyle.None;
            grdUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grdUsers.GridColor = Color.FromArgb(224, 224, 224); // Light gray grid lines for a modern look

            // Add subtle shadow effect around the grid
            grdUsers.Margin = new Padding(10); // Add space around the grid for a clean, modern look

            // Hide Row Headers
            grdUsers.RowHeadersVisible = false;

            // Auto Resize Columns
            grdUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Smooth Cell Borders
            foreach (DataGridViewColumn column in grdUsers.Columns)
            {
                column.DefaultCellStyle.Padding = new Padding(10); // Padding for better text spacing inside cells
            }

            // Row Hover Effect (optional for interactivity)
            grdUsers.CellMouseEnter += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    grdUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(233, 233, 233); // Light gray on hover
                }
            };
            grdUsers.CellMouseLeave += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    grdUsers.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White; // Reset to default on leave
                }
            };
        }

        private void swtShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '\0' : '*';
           
            
        }

        private void PopulateRoleDropdown()
        {
            // Create a list of roles with Key-Value pairs (Value = int, Display = string)
            var roles = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(0, "SuperUser"),
                new KeyValuePair<int, string>(1, "Admin"),
                new KeyValuePair<int, string>(2, "Manager"),
                new KeyValuePair<int, string>(3, "Waiter"),
                new KeyValuePair<int, string>(2, "Cook"),
                new KeyValuePair<int, string>(4, "Cleaner")
            };

            // Bind the ComboBox
            ddlRole.DataSource = new BindingSource(roles, null);
            ddlRole.DisplayMember = "Value";  // What the user sees (String)
            ddlRole.ValueMember = "Key";  // The actual value (Number)

            // Optional: Set a default selection (e.g., "Manager")
            ddlRole.SelectedValue = 2; // Default selection is Manager
        }

    }
}
