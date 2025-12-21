
namespace SSPOS
{
    partial class AddUserForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.lblEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCompany = new MaterialSkin.Controls.MaterialLabel();
            this.txtCompany = new MaterialSkin.Controls.MaterialTextBox();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grdUsers = new System.Windows.Forms.DataGridView();
            this.swtShowPassword = new MaterialSkin.Controls.MaterialSwitch();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnPopulate = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.lblRole = new MaterialSkin.Controls.MaterialLabel();
            this.ddlRole = new MaterialSkin.Controls.MaterialComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblHeader);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1464, 54);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(147)))), ((int)(((byte)(202)))));
            this.lblHeader.Location = new System.Drawing.Point(5, 10);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(404, 34);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "System user management ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnPopulate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 746);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1464, 83);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1464, 692);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblUsername);
            this.flowLayoutPanel2.Controls.Add(this.txtUsername);
            this.flowLayoutPanel2.Controls.Add(this.lblEmail);
            this.flowLayoutPanel2.Controls.Add(this.txtEmail);
            this.flowLayoutPanel2.Controls.Add(this.lblCompany);
            this.flowLayoutPanel2.Controls.Add(this.txtCompany);
            this.flowLayoutPanel2.Controls.Add(this.lblPassword);
            this.flowLayoutPanel2.Controls.Add(this.txtPassword);
            this.flowLayoutPanel2.Controls.Add(this.swtShowPassword);
            this.flowLayoutPanel2.Controls.Add(this.lblRole);
            this.flowLayoutPanel2.Controls.Add(this.ddlRole);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(447, 692);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUsername.Location = new System.Drawing.Point(10, 10);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User name";
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(10, 39);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(413, 50);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Depth = 0;
            this.lblEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmail.Location = new System.Drawing.Point(10, 102);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(101, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email address";
            // 
            // txtEmail
            // 
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(10, 131);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(413, 50);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Depth = 0;
            this.lblCompany.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCompany.Location = new System.Drawing.Point(10, 194);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(69, 19);
            this.lblCompany.TabIndex = 4;
            this.lblCompany.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.AnimateReadOnly = false;
            this.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCompany.Depth = 0;
            this.txtCompany.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompany.LeadingIcon = null;
            this.txtCompany.Location = new System.Drawing.Point(10, 223);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.txtCompany.MaxLength = 50;
            this.txtCompany.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCompany.Multiline = false;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(413, 50);
            this.txtCompany.TabIndex = 5;
            this.txtCompany.Text = "";
            this.txtCompany.TrailingIcon = null;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.Location = new System.Drawing.Point(10, 286);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 19);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.AllowPromptAsInput = true;
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.AsciiOnly = false;
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPassword.BeepOnError = false;
            this.txtPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.HelperText = "Password";
            this.txtPassword.HidePromptOnLeave = true;
            this.txtPassword.HideSelection = true;
            this.txtPassword.Hint = "Please make sure to enter strong password";
            this.txtPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPassword.LeadingIcon = null;
            this.txtPassword.Location = new System.Drawing.Point(10, 315);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.txtPassword.Mask = "";
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PrefixSuffixText = null;
            this.txtPassword.PromptChar = '_';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.RejectInputOnFirstFailure = false;
            this.txtPassword.ResetOnPrompt = true;
            this.txtPassword.ResetOnSpace = true;
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(413, 48);
            this.txtPassword.SkipLiterals = true;
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TabStop = false;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPassword.TrailingIcon = null;
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.ValidatingType = null;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grdUsers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(817, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 692);
            this.panel3.TabIndex = 0;
            // 
            // grdUsers
            // 
            this.grdUsers.BackgroundColor = System.Drawing.Color.White;
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUsers.Location = new System.Drawing.Point(0, 0);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.RowHeadersWidth = 51;
            this.grdUsers.RowTemplate.Height = 24;
            this.grdUsers.Size = new System.Drawing.Size(647, 692);
            this.grdUsers.TabIndex = 0;
            // 
            // swtShowPassword
            // 
            this.swtShowPassword.AutoSize = true;
            this.swtShowPassword.Depth = 0;
            this.swtShowPassword.Location = new System.Drawing.Point(0, 371);
            this.swtShowPassword.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.swtShowPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swtShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.swtShowPassword.Name = "swtShowPassword";
            this.swtShowPassword.Ripple = true;
            this.swtShowPassword.Size = new System.Drawing.Size(169, 37);
            this.swtShowPassword.TabIndex = 8;
            this.swtShowPassword.Text = "show password";
            this.swtShowPassword.UseVisualStyleBackColor = true;
            this.swtShowPassword.CheckedChanged += new System.EventHandler(this.swtShowPassword_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(11, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnPopulate
            // 
            this.btnPopulate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPopulate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPopulate.Depth = 0;
            this.btnPopulate.HighEmphasis = true;
            this.btnPopulate.Icon = null;
            this.btnPopulate.Location = new System.Drawing.Point(83, 9);
            this.btnPopulate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPopulate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPopulate.Size = new System.Drawing.Size(95, 36);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "populate";
            this.btnPopulate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPopulate.UseAccentColor = false;
            this.btnPopulate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(186, 9);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(77, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(271, 9);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(84, 36);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(363, 9);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(84, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Depth = 0;
            this.lblRole.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRole.Location = new System.Drawing.Point(10, 418);
            this.lblRole.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblRole.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 19);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "Role";
            // 
            // ddlRole
            // 
            this.ddlRole.AutoResize = false;
            this.ddlRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ddlRole.Depth = 0;
            this.ddlRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ddlRole.DropDownHeight = 174;
            this.ddlRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRole.DropDownWidth = 121;
            this.ddlRole.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ddlRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ddlRole.FormattingEnabled = true;
            this.ddlRole.IntegralHeight = false;
            this.ddlRole.ItemHeight = 43;
            this.ddlRole.Location = new System.Drawing.Point(10, 447);
            this.ddlRole.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.ddlRole.MaxDropDownItems = 4;
            this.ddlRole.MouseState = MaterialSkin.MouseState.OUT;
            this.ddlRole.Name = "ddlRole";
            this.ddlRole.Size = new System.Drawing.Size(420, 49);
            this.ddlRole.StartIndex = 0;
            this.ddlRole.TabIndex = 10;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 829);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView grdUsers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialLabel lblEmail;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialLabel lblCompany;
        private MaterialSkin.Controls.MaterialTextBox txtCompany;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private MaterialSkin.Controls.MaterialSwitch swtShowPassword;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnPopulate;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private MaterialSkin.Controls.MaterialLabel lblRole;
        private MaterialSkin.Controls.MaterialComboBox ddlRole;
    }
}