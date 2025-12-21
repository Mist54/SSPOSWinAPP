
namespace SSPOS.GUI
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.pnlheader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.txtOutsidePrice = new System.Windows.Forms.TextBox();
            this.lblOutsidePrice = new System.Windows.Forms.Label();
            this.txtDirectPrice = new System.Windows.Forms.TextBox();
            this.lblDirectPrice = new System.Windows.Forms.Label();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.txtRegularPrice = new System.Windows.Forms.TextBox();
            this.lblMRP = new System.Windows.Forms.Label();
            this.lblRegularPrice = new System.Windows.Forms.Label();
            this.ddlUOMs = new System.Windows.Forms.ComboBox();
            this.ddlSubCatogory = new System.Windows.Forms.ComboBox();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.lblUOM = new System.Windows.Forms.Label();
            this.lblSubCatogory = new System.Windows.Forms.Label();
            this.lblCatogory = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCodePopulate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.lblProductnname = new System.Windows.Forms.Label();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlheader
            // 
            this.pnlheader.Controls.Add(this.lblHeader);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1167, 46);
            this.pnlheader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(147)))), ((int)(((byte)(202)))));
            this.lblHeader.Location = new System.Drawing.Point(9, 7);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(265, 28);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Product management ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTotalTax);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalTax);
            this.splitContainer1.Panel1.Controls.Add(this.txtOutsidePrice);
            this.splitContainer1.Panel1.Controls.Add(this.lblOutsidePrice);
            this.splitContainer1.Panel1.Controls.Add(this.txtDirectPrice);
            this.splitContainer1.Panel1.Controls.Add(this.lblDirectPrice);
            this.splitContainer1.Panel1.Controls.Add(this.txtMRP);
            this.splitContainer1.Panel1.Controls.Add(this.txtRegularPrice);
            this.splitContainer1.Panel1.Controls.Add(this.lblMRP);
            this.splitContainer1.Panel1.Controls.Add(this.lblRegularPrice);
            this.splitContainer1.Panel1.Controls.Add(this.ddlUOMs);
            this.splitContainer1.Panel1.Controls.Add(this.ddlSubCatogory);
            this.splitContainer1.Panel1.Controls.Add(this.ddlCategory);
            this.splitContainer1.Panel1.Controls.Add(this.lblUOM);
            this.splitContainer1.Panel1.Controls.Add(this.lblSubCatogory);
            this.splitContainer1.Panel1.Controls.Add(this.lblCatogory);
            this.splitContainer1.Panel1.Controls.Add(this.txtProductCode);
            this.splitContainer1.Panel1.Controls.Add(this.lblProductCode);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.txtProductname);
            this.splitContainer1.Panel1.Controls.Add(this.lblProductnname);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdProduct);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1167, 672);
            this.splitContainer1.SplitterDistance = 494;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalTax.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotalTax.Enabled = false;
            this.txtTotalTax.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTax.Location = new System.Drawing.Point(13, 639);
            this.txtTotalTax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.Size = new System.Drawing.Size(83, 32);
            this.txtTotalTax.TabIndex = 10;
            this.txtTotalTax.TabStop = false;
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTax.Location = new System.Drawing.Point(10, 614);
            this.lblTotalTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(84, 22);
            this.lblTotalTax.TabIndex = 0;
            this.lblTotalTax.Text = "Total Tax";
            // 
            // txtOutsidePrice
            // 
            this.txtOutsidePrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutsidePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutsidePrice.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutsidePrice.Location = new System.Drawing.Point(13, 570);
            this.txtOutsidePrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutsidePrice.Name = "txtOutsidePrice";
            this.txtOutsidePrice.Size = new System.Drawing.Size(83, 32);
            this.txtOutsidePrice.TabIndex = 9;
            // 
            // lblOutsidePrice
            // 
            this.lblOutsidePrice.AutoSize = true;
            this.lblOutsidePrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutsidePrice.Location = new System.Drawing.Point(9, 545);
            this.lblOutsidePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutsidePrice.Name = "lblOutsidePrice";
            this.lblOutsidePrice.Size = new System.Drawing.Size(125, 22);
            this.lblOutsidePrice.TabIndex = 0;
            this.lblOutsidePrice.Text = "Outside Price";
            // 
            // txtDirectPrice
            // 
            this.txtDirectPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectPrice.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirectPrice.Location = new System.Drawing.Point(14, 500);
            this.txtDirectPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDirectPrice.Name = "txtDirectPrice";
            this.txtDirectPrice.Size = new System.Drawing.Size(83, 32);
            this.txtDirectPrice.TabIndex = 8;
            this.txtDirectPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDirectPrice_KeyDown);
            // 
            // lblDirectPrice
            // 
            this.lblDirectPrice.AutoSize = true;
            this.lblDirectPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectPrice.Location = new System.Drawing.Point(10, 476);
            this.lblDirectPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirectPrice.Name = "lblDirectPrice";
            this.lblDirectPrice.Size = new System.Drawing.Size(109, 22);
            this.lblDirectPrice.TabIndex = 0;
            this.lblDirectPrice.Text = "Direct Price";
            // 
            // txtMRP
            // 
            this.txtMRP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMRP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMRP.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRP.Location = new System.Drawing.Point(14, 360);
            this.txtMRP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(83, 32);
            this.txtMRP.TabIndex = 6;
            this.txtMRP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMRP_KeyDown);
            // 
            // txtRegularPrice
            // 
            this.txtRegularPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegularPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegularPrice.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegularPrice.Location = new System.Drawing.Point(14, 432);
            this.txtRegularPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRegularPrice.Name = "txtRegularPrice";
            this.txtRegularPrice.Size = new System.Drawing.Size(83, 32);
            this.txtRegularPrice.TabIndex = 7;
            this.txtRegularPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegularPrice_KeyDown);
            // 
            // lblMRP
            // 
            this.lblMRP.AutoSize = true;
            this.lblMRP.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.Location = new System.Drawing.Point(10, 336);
            this.lblMRP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(101, 22);
            this.lblMRP.TabIndex = 0;
            this.lblMRP.Text = "MRP Price";
            // 
            // lblRegularPrice
            // 
            this.lblRegularPrice.AutoSize = true;
            this.lblRegularPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegularPrice.Location = new System.Drawing.Point(10, 408);
            this.lblRegularPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegularPrice.Name = "lblRegularPrice";
            this.lblRegularPrice.Size = new System.Drawing.Size(125, 22);
            this.lblRegularPrice.TabIndex = 0;
            this.lblRegularPrice.Text = "Regular Price";
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
            this.ddlUOMs.Location = new System.Drawing.Point(14, 167);
            this.ddlUOMs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddlUOMs.Name = "ddlUOMs";
            this.ddlUOMs.Size = new System.Drawing.Size(84, 34);
            this.ddlUOMs.TabIndex = 3;
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
            this.ddlSubCatogory.Location = new System.Drawing.Point(14, 99);
            this.ddlSubCatogory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddlSubCatogory.Name = "ddlSubCatogory";
            this.ddlSubCatogory.Size = new System.Drawing.Size(84, 34);
            this.ddlSubCatogory.TabIndex = 2;
            this.ddlSubCatogory.SelectedIndexChanged += new System.EventHandler(this.ddlSubCatogory_SelectedIndexChanged);
            // 
            // ddlCategory
            // 
            this.ddlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategory.DropDownWidth = 200;
            this.ddlCategory.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(14, 37);
            this.ddlCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(84, 34);
            this.ddlCategory.TabIndex = 1;
            this.ddlCategory.SelectedIndexChanged += new System.EventHandler(this.ddlCatogory_SelectedIndexChanged);
            // 
            // lblUOM
            // 
            this.lblUOM.AutoSize = true;
            this.lblUOM.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUOM.Location = new System.Drawing.Point(10, 143);
            this.lblUOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(53, 22);
            this.lblUOM.TabIndex = 0;
            this.lblUOM.Text = "UOM";
            // 
            // lblSubCatogory
            // 
            this.lblSubCatogory.AutoSize = true;
            this.lblSubCatogory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCatogory.Location = new System.Drawing.Point(10, 75);
            this.lblSubCatogory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubCatogory.Name = "lblSubCatogory";
            this.lblSubCatogory.Size = new System.Drawing.Size(197, 22);
            this.lblSubCatogory.TabIndex = 0;
            this.lblSubCatogory.Text = "Product Sub Catogory";
            // 
            // lblCatogory
            // 
            this.lblCatogory.AutoSize = true;
            this.lblCatogory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatogory.Location = new System.Drawing.Point(10, 9);
            this.lblCatogory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatogory.Name = "lblCatogory";
            this.lblCatogory.Size = new System.Drawing.Size(158, 22);
            this.lblCatogory.TabIndex = 0;
            this.lblCatogory.Text = "Product Catogory";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductCode.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(14, 292);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(83, 32);
            this.txtProductCode.TabIndex = 5;
            this.txtProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductCode_KeyDown);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(10, 267);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(124, 22);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product code";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 630);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 42);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.83333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.btnCodePopulate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUpdate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 42);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnCodePopulate
            // 
            this.btnCodePopulate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCodePopulate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCodePopulate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCodePopulate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCodePopulate.FlatAppearance.BorderSize = 0;
            this.btnCodePopulate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Salmon;
            this.btnCodePopulate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnCodePopulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodePopulate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodePopulate.ForeColor = System.Drawing.Color.White;
            this.btnCodePopulate.Location = new System.Drawing.Point(104, 2);
            this.btnCodePopulate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCodePopulate.Name = "btnCodePopulate";
            this.btnCodePopulate.Size = new System.Drawing.Size(98, 32);
            this.btnCodePopulate.TabIndex = 11;
            this.btnCodePopulate.Text = "&Populate";
            this.btnCodePopulate.UseVisualStyleBackColor = false;
            this.btnCodePopulate.Click += new System.EventHandler(this.btnCodePopulate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(416, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 33);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(314, 0);
            this.btnClear.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 33);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "&Refresh";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(9)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(9)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(212, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 33);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(8, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProductname
            // 
            this.txtProductname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductname.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductname.Location = new System.Drawing.Point(14, 225);
            this.txtProductname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(83, 32);
            this.txtProductname.TabIndex = 4;
            this.txtProductname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductname_KeyDown);
            // 
            // lblProductnname
            // 
            this.lblProductnname.AutoSize = true;
            this.lblProductnname.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductnname.Location = new System.Drawing.Point(10, 201);
            this.lblProductnname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductnname.Name = "lblProductnname";
            this.lblProductnname.Size = new System.Drawing.Size(128, 22);
            this.lblProductnname.TabIndex = 0;
            this.lblProductnname.Text = "Product name";
            // 
            // grdProduct
            // 
            this.grdProduct.BackgroundColor = System.Drawing.Color.LightGray;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.Location = new System.Drawing.Point(0, 37);
            this.grdProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.ReadOnly = true;
            this.grdProduct.RowHeadersWidth = 51;
            this.grdProduct.RowTemplate.Height = 24;
            this.grdProduct.Size = new System.Drawing.Size(670, 573);
            this.grdProduct.TabIndex = 2;
            this.grdProduct.TabStop = false;
            this.grdProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellClick);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 610);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 62);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 37);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(2, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(620, 32);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(151)))), ((int)(((byte)(243)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(151)))), ((int)(((byte)(243)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(626, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.TabStop = false;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddProductForm_KeyDown);
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblProductnname;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.Label lblCatogory;
        private System.Windows.Forms.TextBox txtOutsidePrice;
        private System.Windows.Forms.Label lblOutsidePrice;
        private System.Windows.Forms.TextBox txtDirectPrice;
        private System.Windows.Forms.Label lblDirectPrice;
        private System.Windows.Forms.TextBox txtRegularPrice;
        private System.Windows.Forms.Label lblRegularPrice;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox ddlSubCatogory;
        private System.Windows.Forms.Label lblSubCatogory;
        private System.Windows.Forms.ComboBox ddlUOMs;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.Button btnCodePopulate;
        private System.Windows.Forms.DataGridView grdProduct;
    }
}