
namespace SSPOS
{
    partial class ReportForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ReportTabControl = new System.Windows.Forms.TabControl();
            this.DailyReportTab = new System.Windows.Forms.TabPage();
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.AnalysisTab = new System.Windows.Forms.TabPage();
            this.dgvAnalysisReport = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPrintAnalysisReport = new MaterialSkin.Controls.MaterialButton();
            this.btnPrintDailyReport = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCatogory = new System.Windows.Forms.Label();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.lblSubCatogory = new System.Windows.Forms.Label();
            this.ddlSubCatogory = new System.Windows.Forms.ComboBox();
            this.lblUOM = new System.Windows.Forms.Label();
            this.ddlUOMs = new System.Windows.Forms.ComboBox();
            this.chkAll = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ReportTabControl.SuspendLayout();
            this.DailyReportTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            this.AnalysisTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisReport)).BeginInit();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 748);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1472, 21);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblHeader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1472, 54);
            this.panel2.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(175, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 27);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label1";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(147)))), ((int)(((byte)(202)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(195, 34);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Daily report ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ReportTabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(584, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 694);
            this.panel3.TabIndex = 2;
            // 
            // ReportTabControl
            // 
            this.ReportTabControl.Controls.Add(this.DailyReportTab);
            this.ReportTabControl.Controls.Add(this.AnalysisTab);
            this.ReportTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportTabControl.Location = new System.Drawing.Point(0, 0);
            this.ReportTabControl.Name = "ReportTabControl";
            this.ReportTabControl.SelectedIndex = 0;
            this.ReportTabControl.Size = new System.Drawing.Size(888, 694);
            this.ReportTabControl.TabIndex = 0;
            // 
            // DailyReportTab
            // 
            this.DailyReportTab.Controls.Add(this.dgvDailyReport);
            this.DailyReportTab.Location = new System.Drawing.Point(4, 35);
            this.DailyReportTab.Name = "DailyReportTab";
            this.DailyReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.DailyReportTab.Size = new System.Drawing.Size(880, 655);
            this.DailyReportTab.TabIndex = 0;
            this.DailyReportTab.Text = "Daily report ";
            this.DailyReportTab.UseVisualStyleBackColor = true;
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDailyReport.Enabled = false;
            this.dgvDailyReport.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDailyReport.Location = new System.Drawing.Point(3, 3);
            this.dgvDailyReport.Name = "dgvDailyReport";
            this.dgvDailyReport.RowHeadersWidth = 51;
            this.dgvDailyReport.Size = new System.Drawing.Size(874, 649);
            this.dgvDailyReport.TabIndex = 0;
            // 
            // AnalysisTab
            // 
            this.AnalysisTab.Controls.Add(this.dgvAnalysisReport);
            this.AnalysisTab.Location = new System.Drawing.Point(4, 35);
            this.AnalysisTab.Name = "AnalysisTab";
            this.AnalysisTab.Padding = new System.Windows.Forms.Padding(3);
            this.AnalysisTab.Size = new System.Drawing.Size(880, 655);
            this.AnalysisTab.TabIndex = 1;
            this.AnalysisTab.Text = "Analysis report";
            this.AnalysisTab.UseVisualStyleBackColor = true;
            // 
            // dgvAnalysisReport
            // 
            this.dgvAnalysisReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAnalysisReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnalysisReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnalysisReport.Enabled = false;
            this.dgvAnalysisReport.Location = new System.Drawing.Point(3, 3);
            this.dgvAnalysisReport.Name = "dgvAnalysisReport";
            this.dgvAnalysisReport.RowHeadersWidth = 51;
            this.dgvAnalysisReport.Size = new System.Drawing.Size(874, 649);
            this.dgvAnalysisReport.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPrintAnalysisReport);
            this.panel4.Controls.Add(this.btnPrintDailyReport);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.btnApply);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 694);
            this.panel4.TabIndex = 3;
            // 
            // btnPrintAnalysisReport
            // 
            this.btnPrintAnalysisReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintAnalysisReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintAnalysisReport.Depth = 0;
            this.btnPrintAnalysisReport.HighEmphasis = true;
            this.btnPrintAnalysisReport.Icon = null;
            this.btnPrintAnalysisReport.Location = new System.Drawing.Point(190, 387);
            this.btnPrintAnalysisReport.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnPrintAnalysisReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintAnalysisReport.Name = "btnPrintAnalysisReport";
            this.btnPrintAnalysisReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintAnalysisReport.Size = new System.Drawing.Size(195, 36);
            this.btnPrintAnalysisReport.TabIndex = 2;
            this.btnPrintAnalysisReport.Text = "Print analysis report";
            this.btnPrintAnalysisReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintAnalysisReport.UseAccentColor = false;
            this.btnPrintAnalysisReport.UseVisualStyleBackColor = true;
            this.btnPrintAnalysisReport.Click += new System.EventHandler(this.btnPrintAnalysisReport_Click);
            // 
            // btnPrintDailyReport
            // 
            this.btnPrintDailyReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrintDailyReport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrintDailyReport.Depth = 0;
            this.btnPrintDailyReport.HighEmphasis = true;
            this.btnPrintDailyReport.Icon = null;
            this.btnPrintDailyReport.Location = new System.Drawing.Point(10, 387);
            this.btnPrintDailyReport.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnPrintDailyReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrintDailyReport.Name = "btnPrintDailyReport";
            this.btnPrintDailyReport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrintDailyReport.Size = new System.Drawing.Size(166, 36);
            this.btnPrintDailyReport.TabIndex = 1;
            this.btnPrintDailyReport.Text = "Print daily report";
            this.btnPrintDailyReport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrintDailyReport.UseAccentColor = false;
            this.btnPrintDailyReport.UseVisualStyleBackColor = true;
            this.btnPrintDailyReport.Click += new System.EventHandler(this.btnPrintDailyReport_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblCatogory);
            this.flowLayoutPanel1.Controls.Add(this.ddlCategory);
            this.flowLayoutPanel1.Controls.Add(this.lblSubCatogory);
            this.flowLayoutPanel1.Controls.Add(this.ddlSubCatogory);
            this.flowLayoutPanel1.Controls.Add(this.lblUOM);
            this.flowLayoutPanel1.Controls.Add(this.ddlUOMs);
            this.flowLayoutPanel1.Controls.Add(this.chkAll);
            this.flowLayoutPanel1.Controls.Add(this.lblInfo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(578, 282);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblCatogory
            // 
            this.lblCatogory.AutoSize = true;
            this.lblCatogory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatogory.Location = new System.Drawing.Point(10, 10);
            this.lblCatogory.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblCatogory.Name = "lblCatogory";
            this.lblCatogory.Size = new System.Drawing.Size(200, 27);
            this.lblCatogory.TabIndex = 26;
            this.lblCatogory.Text = "Product Catogory";
            // 
            // ddlCategory
            // 
            this.ddlCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddlCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategory.DropDownWidth = 200;
            this.ddlCategory.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(12, 47);
            this.ddlCategory.Margin = new System.Windows.Forms.Padding(10, 10, 3, 2);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(247, 39);
            this.ddlCategory.TabIndex = 27;
            this.ddlCategory.SelectedIndexChanged += new System.EventHandler(this.ddlCategory_SelectedIndexChanged);
            // 
            // lblSubCatogory
            // 
            this.lblSubCatogory.AutoSize = true;
            this.lblSubCatogory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCatogory.Location = new System.Drawing.Point(10, 98);
            this.lblSubCatogory.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblSubCatogory.Name = "lblSubCatogory";
            this.lblSubCatogory.Size = new System.Drawing.Size(251, 27);
            this.lblSubCatogory.TabIndex = 28;
            this.lblSubCatogory.Text = "Product Sub Catogory";
            // 
            // ddlSubCatogory
            // 
            this.ddlSubCatogory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSubCatogory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlSubCatogory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlSubCatogory.DropDownHeight = 200;
            this.ddlSubCatogory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSubCatogory.DropDownWidth = 190;
            this.ddlSubCatogory.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSubCatogory.FormattingEnabled = true;
            this.ddlSubCatogory.IntegralHeight = false;
            this.ddlSubCatogory.Location = new System.Drawing.Point(10, 135);
            this.ddlSubCatogory.Margin = new System.Windows.Forms.Padding(10, 10, 3, 2);
            this.ddlSubCatogory.Name = "ddlSubCatogory";
            this.ddlSubCatogory.Size = new System.Drawing.Size(251, 39);
            this.ddlSubCatogory.TabIndex = 29;
            this.ddlSubCatogory.SelectedIndexChanged += new System.EventHandler(this.ddlSubCatogory_SelectedIndexChanged);
            // 
            // lblUOM
            // 
            this.lblUOM.AutoSize = true;
            this.lblUOM.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUOM.Location = new System.Drawing.Point(10, 186);
            this.lblUOM.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(67, 27);
            this.lblUOM.TabIndex = 30;
            this.lblUOM.Text = "UOM";
            // 
            // ddlUOMs
            // 
            this.ddlUOMs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlUOMs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlUOMs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlUOMs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUOMs.DropDownWidth = 200;
            this.ddlUOMs.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlUOMs.FormattingEnabled = true;
            this.ddlUOMs.Location = new System.Drawing.Point(10, 223);
            this.ddlUOMs.Margin = new System.Windows.Forms.Padding(10, 10, 3, 2);
            this.ddlUOMs.Name = "ddlUOMs";
            this.ddlUOMs.Size = new System.Drawing.Size(251, 39);
            this.ddlUOMs.TabIndex = 31;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Depth = 0;
            this.chkAll.Location = new System.Drawing.Point(264, 0);
            this.chkAll.Margin = new System.Windows.Forms.Padding(0);
            this.chkAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAll.Name = "chkAll";
            this.chkAll.ReadOnly = false;
            this.chkAll.Ripple = true;
            this.chkAll.Size = new System.Drawing.Size(99, 37);
            this.chkAll.TabIndex = 3;
            this.chkAll.Text = "Select all";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(12, 307);
            this.btnApply.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnApply.Size = new System.Drawing.Size(104, 39);
            this.btnApply.TabIndex = 32;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInfo.Location = new System.Drawing.Point(274, 47);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(267, 44);
            this.lblInfo.TabIndex = 33;
            this.lblInfo.Text = "**Apply the filters to get the result or choose Select all to get all result";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(129, 307);
            this.btnClear.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(104, 39);
            this.btnClear.TabIndex = 34;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 769);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ReportTabControl.ResumeLayout(false);
            this.DailyReportTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            this.AnalysisTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysisReport)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHeader;
        private MaterialSkin.Controls.MaterialButton btnPrintDailyReport;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCatogory;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.Label lblSubCatogory;
        private System.Windows.Forms.ComboBox ddlSubCatogory;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.ComboBox ddlUOMs;
        private MaterialSkin.Controls.MaterialCheckbox chkAll;
        private MaterialSkin.Controls.MaterialButton btnPrintAnalysisReport;
        private System.Windows.Forms.TabControl ReportTabControl;
        private System.Windows.Forms.TabPage DailyReportTab;
        private System.Windows.Forms.TabPage AnalysisTab;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgvAnalysisReport;
        private System.Windows.Forms.DataGridView dgvDailyReport;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnClear;
    }
}