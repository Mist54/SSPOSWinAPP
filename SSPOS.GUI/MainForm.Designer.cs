
namespace SSPOS.GUI
{
    partial class MainForm
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
            System.Windows.Forms.ImageList imageList1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.OrderPage = new System.Windows.Forms.TabPage();
            this.BillingPage = new System.Windows.Forms.TabPage();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.StockManagementPage = new System.Windows.Forms.TabPage();
            this.LogoutPage = new System.Windows.Forms.TabPage();
            imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "icons8-home-24.png");
            imageList1.Images.SetKeyName(1, "icons8-bill-24.png");
            imageList1.Images.SetKeyName(2, "icons8-setting-24.png");
            imageList1.Images.SetKeyName(3, "icons8-admin-25.png");
            imageList1.Images.SetKeyName(4, "icons8-logout-26.png");
            imageList1.Images.SetKeyName(5, "icons8-stack-32.png");
            imageList1.Images.SetKeyName(6, "icons8-billing-48.png");
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.HomePage);
            this.MainTabControl.Controls.Add(this.OrderPage);
            this.MainTabControl.Controls.Add(this.BillingPage);
            this.MainTabControl.Controls.Add(this.SettingPage);
            this.MainTabControl.Controls.Add(this.StockManagementPage);
            this.MainTabControl.Controls.Add(this.LogoutPage);
            this.MainTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainTabControl.Depth = 0;
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.HotTrack = true;
            this.MainTabControl.ImageList = imageList1;
            this.MainTabControl.Location = new System.Drawing.Point(3, 64);
            this.MainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1353, 1035);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 1;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // HomePage
            // 
            this.HomePage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePage.ImageKey = "icons8-home-24.png";
            this.HomePage.Location = new System.Drawing.Point(4, 31);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(1345, 1000);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "Home";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // OrderPage
            // 
            this.OrderPage.ImageKey = "icons8-bill-24.png";
            this.OrderPage.Location = new System.Drawing.Point(4, 31);
            this.OrderPage.Name = "OrderPage";
            this.OrderPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrderPage.Size = new System.Drawing.Size(1345, 1000);
            this.OrderPage.TabIndex = 1;
            this.OrderPage.Text = "Order";
            this.OrderPage.UseVisualStyleBackColor = true;
            // 
            // BillingPage
            // 
            this.BillingPage.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillingPage.ImageKey = "icons8-billing-48.png";
            this.BillingPage.Location = new System.Drawing.Point(4, 31);
            this.BillingPage.Name = "BillingPage";
            this.BillingPage.Size = new System.Drawing.Size(1345, 1000);
            this.BillingPage.TabIndex = 5;
            this.BillingPage.Text = "Billing";
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
            this.StockManagementPage.ImageKey = "icons8-admin-25.png";
            this.StockManagementPage.Location = new System.Drawing.Point(4, 31);
            this.StockManagementPage.Name = "StockManagementPage";
            this.StockManagementPage.Size = new System.Drawing.Size(1345, 1000);
            this.StockManagementPage.TabIndex = 3;
            this.StockManagementPage.Text = "Admin";
            this.StockManagementPage.ToolTipText = "Redirects to admin page";
            this.StockManagementPage.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 1102);
            this.Controls.Add(this.MainTabControl);
            this.DrawerIsOpen = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.MainTabControl;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSPOS - Billing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainTabControl;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage OrderPage;
        private System.Windows.Forms.TabPage SettingPage;
        private System.Windows.Forms.TabPage StockManagementPage;
        private System.Windows.Forms.TabPage LogoutPage;
        private System.Windows.Forms.TabPage BillingPage;
    }
}