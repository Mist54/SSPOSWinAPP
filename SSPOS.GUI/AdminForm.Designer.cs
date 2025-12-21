
namespace SSPOS.GUI
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.AdminTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.BillingPage = new System.Windows.Forms.TabPage();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.StockManagementPage = new System.Windows.Forms.TabPage();
            this.ProductManagementPage = new System.Windows.Forms.TabPage();
            this.ReportPage = new System.Windows.Forms.TabPage();
            this.LogoutPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.addUserPage = new System.Windows.Forms.TabPage();
            this.AdminTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTabControl
            // 
            this.AdminTabControl.Controls.Add(this.HomePage);
            this.AdminTabControl.Controls.Add(this.BillingPage);
            this.AdminTabControl.Controls.Add(this.SettingPage);
            this.AdminTabControl.Controls.Add(this.StockManagementPage);
            this.AdminTabControl.Controls.Add(this.ProductManagementPage);
            this.AdminTabControl.Controls.Add(this.ReportPage);
            this.AdminTabControl.Controls.Add(this.addUserPage);
            this.AdminTabControl.Controls.Add(this.LogoutPage);
            this.AdminTabControl.Depth = 0;
            this.AdminTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminTabControl.ImageList = this.imageList1;
            this.AdminTabControl.ItemSize = new System.Drawing.Size(85, 27);
            this.AdminTabControl.Location = new System.Drawing.Point(3, 64);
            this.AdminTabControl.Margin = new System.Windows.Forms.Padding(5);
            this.AdminTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminTabControl.Multiline = true;
            this.AdminTabControl.Name = "AdminTabControl";
            this.AdminTabControl.SelectedIndex = 0;
            this.AdminTabControl.Size = new System.Drawing.Size(1353, 1035);
            this.AdminTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.AdminTabControl.TabIndex = 0;
            this.AdminTabControl.SelectedIndexChanged += new System.EventHandler(this.AdminTabControl_SelectedIndexChanged);
            // 
            // HomePage
            // 
            this.HomePage.ImageKey = "icons8-home-24.png";
            this.HomePage.Location = new System.Drawing.Point(4, 31);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(1345, 1000);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Home";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // BillingPage
            // 
            this.BillingPage.ImageKey = "icons8-bill-24.png";
            this.BillingPage.Location = new System.Drawing.Point(4, 31);
            this.BillingPage.Name = "BillingPage";
            this.BillingPage.Padding = new System.Windows.Forms.Padding(3);
            this.BillingPage.Size = new System.Drawing.Size(1345, 1000);
            this.BillingPage.TabIndex = 1;
            this.BillingPage.Text = "Bill management";
            this.BillingPage.UseVisualStyleBackColor = true;
            // 
            // SettingPage
            // 
            this.SettingPage.ImageKey = "icons8-setting-24.png";
            this.SettingPage.Location = new System.Drawing.Point(4, 31);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Size = new System.Drawing.Size(1345, 1000);
            this.SettingPage.TabIndex = 2;
            this.SettingPage.Text = "Setting";
            this.SettingPage.UseVisualStyleBackColor = true;
            // 
            // StockManagementPage
            // 
            this.StockManagementPage.ForeColor = System.Drawing.Color.SteelBlue;
            this.StockManagementPage.ImageKey = "icons8-stack-32.png";
            this.StockManagementPage.Location = new System.Drawing.Point(4, 31);
            this.StockManagementPage.Name = "StockManagementPage";
            this.StockManagementPage.Size = new System.Drawing.Size(1345, 1000);
            this.StockManagementPage.TabIndex = 3;
            this.StockManagementPage.Text = "Stock management";
            this.StockManagementPage.UseVisualStyleBackColor = true;
            // 
            // ProductManagementPage
            // 
            this.ProductManagementPage.ImageKey = "icons8-add-properties-24.png";
            this.ProductManagementPage.Location = new System.Drawing.Point(4, 31);
            this.ProductManagementPage.Name = "ProductManagementPage";
            this.ProductManagementPage.Size = new System.Drawing.Size(1345, 1000);
            this.ProductManagementPage.TabIndex = 5;
            this.ProductManagementPage.Text = "Add product";
            this.ProductManagementPage.UseVisualStyleBackColor = true;
            // 
            // ReportPage
            // 
            this.ReportPage.ImageKey = "Report.png";
            this.ReportPage.Location = new System.Drawing.Point(4, 31);
            this.ReportPage.Name = "ReportPage";
            this.ReportPage.Size = new System.Drawing.Size(1345, 1000);
            this.ReportPage.TabIndex = 6;
            this.ReportPage.Text = "Report";
            this.ReportPage.UseVisualStyleBackColor = true;
            // 
            // LogoutPage
            // 
            this.LogoutPage.ImageKey = "icons8-logout-26.png";
            this.LogoutPage.Location = new System.Drawing.Point(4, 31);
            this.LogoutPage.Name = "LogoutPage";
            this.LogoutPage.Size = new System.Drawing.Size(1345, 1000);
            this.LogoutPage.TabIndex = 4;
            this.LogoutPage.Text = "Logout";
            this.LogoutPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-home-24.png");
            this.imageList1.Images.SetKeyName(1, "icons8-bill-24.png");
            this.imageList1.Images.SetKeyName(2, "icons8-setting-24.png");
            this.imageList1.Images.SetKeyName(3, "icons8-admin-25.png");
            this.imageList1.Images.SetKeyName(4, "icons8-logout-26.png");
            this.imageList1.Images.SetKeyName(5, "icons8-stack-32.png");
            this.imageList1.Images.SetKeyName(6, "icons8-add-product-26.png");
            this.imageList1.Images.SetKeyName(7, "icons8-add-properties-24.png");
            this.imageList1.Images.SetKeyName(8, "Report.png");
            this.imageList1.Images.SetKeyName(9, "icons8-add-user-50.png");
            // 
            // addUserPage
            // 
            this.addUserPage.ImageKey = "icons8-add-user-50.png";
            this.addUserPage.Location = new System.Drawing.Point(4, 31);
            this.addUserPage.Name = "addUserPage";
            this.addUserPage.Size = new System.Drawing.Size(1345, 1000);
            this.addUserPage.TabIndex = 7;
            this.addUserPage.Text = "Add user";
            this.addUserPage.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1359, 1102);
            this.Controls.Add(this.AdminTabControl);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.AdminTabControl;
            this.Name = "AdminForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSPOS - Admin page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.AdminTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage BillingPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage SettingPage;
        private System.Windows.Forms.TabPage StockManagementPage;
        private System.Windows.Forms.TabPage LogoutPage;
        private System.Windows.Forms.TabPage ProductManagementPage;
        public MaterialSkin.Controls.MaterialTabControl AdminTabControl;
        private System.Windows.Forms.TabPage ReportPage;
        private System.Windows.Forms.TabPage addUserPage;
    }
}