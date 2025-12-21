
namespace SSPOS.GUI
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblheaderQty = new System.Windows.Forms.Label();
            this.lblSelectedProductPrice = new System.Windows.Forms.Label();
            this.lblHeaderTotal = new System.Windows.Forms.Label();
            this.lblSelectedProductTotalPrice = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.txtProductcode = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSection = new System.Windows.Forms.Label();
            this.ddlSection = new System.Windows.Forms.ComboBox();
            this.lblAddPosition = new System.Windows.Forms.Label();
            this.btnRemovePosition = new MaterialSkin.Controls.MaterialButton();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnAddPosition = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTablenames = new System.Windows.Forms.Label();
            this.ddlTablename = new System.Windows.Forms.ComboBox();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.ddlWaiter = new System.Windows.Forms.ComboBox();
            this.grdTempOrder = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.grdOrder = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearchgrdProduct = new System.Windows.Forms.Button();
            this.txtSearchgrdProduct = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTempOrder)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1457, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(147)))), ((int)(((byte)(202)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(188, 34);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Order Entry";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 50);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1457, 749);
            this.splitContainer1.SplitterDistance = 767;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grdTempOrder);
            this.splitContainer2.Size = new System.Drawing.Size(767, 676);
            this.splitContainer2.SplitterDistance = 300;
            this.splitContainer2.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.lblheaderQty);
            this.flowLayoutPanel4.Controls.Add(this.lblSelectedProductPrice);
            this.flowLayoutPanel4.Controls.Add(this.lblHeaderTotal);
            this.flowLayoutPanel4.Controls.Add(this.lblSelectedProductTotalPrice);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 204);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(767, 64);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // lblheaderQty
            // 
            this.lblheaderQty.AutoSize = true;
            this.lblheaderQty.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheaderQty.Location = new System.Drawing.Point(3, 15);
            this.lblheaderQty.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblheaderQty.Name = "lblheaderQty";
            this.lblheaderQty.Size = new System.Drawing.Size(169, 27);
            this.lblheaderQty.TabIndex = 47;
            this.lblheaderQty.Text = "Product price :";
            // 
            // lblSelectedProductPrice
            // 
            this.lblSelectedProductPrice.AutoSize = true;
            this.lblSelectedProductPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProductPrice.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblSelectedProductPrice.Location = new System.Drawing.Point(178, 15);
            this.lblSelectedProductPrice.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblSelectedProductPrice.Name = "lblSelectedProductPrice";
            this.lblSelectedProductPrice.Size = new System.Drawing.Size(26, 29);
            this.lblSelectedProductPrice.TabIndex = 48;
            this.lblSelectedProductPrice.Text = "0";
            // 
            // lblHeaderTotal
            // 
            this.lblHeaderTotal.AutoSize = true;
            this.lblHeaderTotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTotal.Location = new System.Drawing.Point(210, 15);
            this.lblHeaderTotal.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblHeaderTotal.Name = "lblHeaderTotal";
            this.lblHeaderTotal.Size = new System.Drawing.Size(142, 27);
            this.lblHeaderTotal.TabIndex = 49;
            this.lblHeaderTotal.Text = "Total  price :";
            // 
            // lblSelectedProductTotalPrice
            // 
            this.lblSelectedProductTotalPrice.AutoSize = true;
            this.lblSelectedProductTotalPrice.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProductTotalPrice.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblSelectedProductTotalPrice.Location = new System.Drawing.Point(358, 15);
            this.lblSelectedProductTotalPrice.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.lblSelectedProductTotalPrice.Name = "lblSelectedProductTotalPrice";
            this.lblSelectedProductTotalPrice.Size = new System.Drawing.Size(26, 29);
            this.lblSelectedProductTotalPrice.TabIndex = 50;
            this.lblSelectedProductTotalPrice.Text = "0";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblProductCode);
            this.flowLayoutPanel3.Controls.Add(this.txtProductcode);
            this.flowLayoutPanel3.Controls.Add(this.lblQty);
            this.flowLayoutPanel3.Controls.Add(this.txtQty);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 131);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(767, 73);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(5, 10);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(155, 27);
            this.lblProductCode.TabIndex = 37;
            this.lblProductCode.Text = "Product code";
            this.lblProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductcode
            // 
            this.txtProductcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductcode.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductcode.Location = new System.Drawing.Point(170, 10);
            this.txtProductcode.Margin = new System.Windows.Forms.Padding(5, 10, 16, 5);
            this.txtProductcode.Name = "txtProductcode";
            this.txtProductcode.Size = new System.Drawing.Size(115, 39);
            this.txtProductcode.TabIndex = 38;
            this.txtProductcode.TextChanged += new System.EventHandler(this.txtProductcode_TextChanged);
            this.txtProductcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductcode_KeyDown);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(311, 10);
            this.lblQty.Margin = new System.Windows.Forms.Padding(10, 10, 5, 5);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(98, 27);
            this.lblQty.TabIndex = 39;
            this.lblQty.Text = "quantity";
            // 
            // txtQty
            // 
            this.txtQty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(419, 10);
            this.txtQty.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(124, 39);
            this.txtQty.TabIndex = 40;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblSection);
            this.flowLayoutPanel2.Controls.Add(this.ddlSection);
            this.flowLayoutPanel2.Controls.Add(this.lblAddPosition);
            this.flowLayoutPanel2.Controls.Add(this.btnRemovePosition);
            this.flowLayoutPanel2.Controls.Add(this.txtPosition);
            this.flowLayoutPanel2.Controls.Add(this.btnAddPosition);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 63);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(767, 68);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblSection
            // 
            this.lblSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.Black;
            this.lblSection.Location = new System.Drawing.Point(5, 10);
            this.lblSection.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(92, 27);
            this.lblSection.TabIndex = 25;
            this.lblSection.Text = "Section";
            this.lblSection.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ddlSection
            // 
            this.ddlSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlSection.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlSection.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSection.DropDownWidth = 200;
            this.ddlSection.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSection.FormattingEnabled = true;
            this.ddlSection.Location = new System.Drawing.Point(107, 10);
            this.ddlSection.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.ddlSection.Name = "ddlSection";
            this.ddlSection.Size = new System.Drawing.Size(262, 39);
            this.ddlSection.TabIndex = 26;
            this.ddlSection.SelectedIndexChanged += new System.EventHandler(this.ddlSection_SelectedIndexChanged);
            this.ddlSection.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlSection_KeyDown);
            // 
            // lblAddPosition
            // 
            this.lblAddPosition.AutoSize = true;
            this.lblAddPosition.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPosition.Location = new System.Drawing.Point(379, 10);
            this.lblAddPosition.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblAddPosition.Name = "lblAddPosition";
            this.lblAddPosition.Size = new System.Drawing.Size(159, 27);
            this.lblAddPosition.TabIndex = 41;
            this.lblAddPosition.Text = "Table position";
            this.lblAddPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemovePosition
            // 
            this.btnRemovePosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemovePosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePosition.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemovePosition.Depth = 0;
            this.btnRemovePosition.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemovePosition.HighEmphasis = true;
            this.btnRemovePosition.Icon = null;
            this.btnRemovePosition.Location = new System.Drawing.Point(547, 10);
            this.btnRemovePosition.Margin = new System.Windows.Forms.Padding(4, 10, 4, 6);
            this.btnRemovePosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemovePosition.Name = "btnRemovePosition";
            this.btnRemovePosition.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemovePosition.Size = new System.Drawing.Size(64, 36);
            this.btnRemovePosition.TabIndex = 43;
            this.btnRemovePosition.Text = "-";
            this.btnRemovePosition.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemovePosition.UseAccentColor = false;
            this.btnRemovePosition.UseVisualStyleBackColor = true;
            this.btnRemovePosition.Click += new System.EventHandler(this.btnRemovePosition_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPosition.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(620, 10);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(5, 10, 16, 5);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(48, 34);
            this.txtPosition.TabIndex = 44;
            this.txtPosition.Text = "A";
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            this.txtPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosition_KeyDown);
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPosition.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddPosition.Depth = 0;
            this.btnAddPosition.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddPosition.HighEmphasis = true;
            this.btnAddPosition.Icon = null;
            this.btnAddPosition.Location = new System.Drawing.Point(688, 10);
            this.btnAddPosition.Margin = new System.Windows.Forms.Padding(4, 10, 4, 6);
            this.btnAddPosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddPosition.Size = new System.Drawing.Size(64, 36);
            this.btnAddPosition.TabIndex = 45;
            this.btnAddPosition.Text = "+";
            this.btnAddPosition.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddPosition.UseAccentColor = false;
            this.btnAddPosition.UseVisualStyleBackColor = true;
            this.btnAddPosition.Click += new System.EventHandler(this.btnAddPosition_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTablenames);
            this.flowLayoutPanel1.Controls.Add(this.ddlTablename);
            this.flowLayoutPanel1.Controls.Add(this.lblWaiter);
            this.flowLayoutPanel1.Controls.Add(this.ddlWaiter);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(767, 63);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblTablenames
            // 
            this.lblTablenames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTablenames.AutoSize = true;
            this.lblTablenames.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablenames.ForeColor = System.Drawing.Color.Black;
            this.lblTablenames.Location = new System.Drawing.Point(5, 10);
            this.lblTablenames.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblTablenames.Name = "lblTablenames";
            this.lblTablenames.Size = new System.Drawing.Size(81, 27);
            this.lblTablenames.TabIndex = 21;
            this.lblTablenames.Text = "Tables";
            this.lblTablenames.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ddlTablename
            // 
            this.ddlTablename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlTablename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlTablename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlTablename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTablename.DropDownWidth = 200;
            this.ddlTablename.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTablename.FormattingEnabled = true;
            this.ddlTablename.Location = new System.Drawing.Point(96, 10);
            this.ddlTablename.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.ddlTablename.Name = "ddlTablename";
            this.ddlTablename.Size = new System.Drawing.Size(273, 39);
            this.ddlTablename.TabIndex = 22;
            this.ddlTablename.SelectedIndexChanged += new System.EventHandler(this.ddlTablename_SelectedIndexChanged);
            // 
            // lblWaiter
            // 
            this.lblWaiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiter.ForeColor = System.Drawing.Color.Black;
            this.lblWaiter.Location = new System.Drawing.Point(379, 10);
            this.lblWaiter.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(92, 27);
            this.lblWaiter.TabIndex = 23;
            this.lblWaiter.Text = "Waiters";
            // 
            // ddlWaiter
            // 
            this.ddlWaiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlWaiter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlWaiter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlWaiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlWaiter.DropDownWidth = 200;
            this.ddlWaiter.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlWaiter.FormattingEnabled = true;
            this.ddlWaiter.Location = new System.Drawing.Point(481, 10);
            this.ddlWaiter.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.ddlWaiter.Name = "ddlWaiter";
            this.ddlWaiter.Size = new System.Drawing.Size(268, 39);
            this.ddlWaiter.TabIndex = 24;
            this.ddlWaiter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlWaiter_KeyDown);
            // 
            // grdTempOrder
            // 
            this.grdTempOrder.BackgroundColor = System.Drawing.Color.LightGray;
            this.grdTempOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTempOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTempOrder.Location = new System.Drawing.Point(0, 0);
            this.grdTempOrder.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.grdTempOrder.Name = "grdTempOrder";
            this.grdTempOrder.ReadOnly = true;
            this.grdTempOrder.RowHeadersWidth = 51;
            this.grdTempOrder.RowTemplate.Height = 24;
            this.grdTempOrder.Size = new System.Drawing.Size(767, 372);
            this.grdTempOrder.TabIndex = 4;
            this.grdTempOrder.TabStop = false;
            this.grdTempOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTempOrder_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelOrder);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnPlaceOrder);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 676);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 73);
            this.panel2.TabIndex = 0;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelOrder.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnCancelOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnCancelOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Coral;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.Location = new System.Drawing.Point(512, 10);
            this.btnCancelOrder.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(164, 41);
            this.btnCancelOrder.TabIndex = 52;
            this.btnCancelOrder.Text = "&Cancel order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(363, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 41);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(9)))));
            this.btnPlaceOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(9)))));
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.btnPlaceOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(170, 10);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(178, 41);
            this.btnPlaceOrder.TabIndex = 48;
            this.btnPlaceOrder.Text = "&Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(11, 10);
            this.btnSave.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 41);
            this.btnSave.TabIndex = 47;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.grdOrder);
            this.splitContainer3.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.grdProduct);
            this.splitContainer3.Panel2.Controls.Add(this.panel5);
            this.splitContainer3.Panel2.Controls.Add(this.panel4);
            this.splitContainer3.Size = new System.Drawing.Size(686, 749);
            this.splitContainer3.SplitterDistance = 355;
            this.splitContainer3.TabIndex = 0;
            // 
            // grdOrder
            // 
            this.grdOrder.BackgroundColor = System.Drawing.Color.LightGray;
            this.grdOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrder.Location = new System.Drawing.Point(0, 24);
            this.grdOrder.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.grdOrder.Name = "grdOrder";
            this.grdOrder.ReadOnly = true;
            this.grdOrder.RowHeadersWidth = 51;
            this.grdOrder.RowTemplate.Height = 24;
            this.grdOrder.Size = new System.Drawing.Size(686, 331);
            this.grdOrder.TabIndex = 8;
            this.grdOrder.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(686, 24);
            this.panel3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(630, 39);
            this.textBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(151)))), ((int)(((byte)(243)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(151)))), ((int)(((byte)(243)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(630, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 24);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // grdProduct
            // 
            this.grdProduct.BackgroundColor = System.Drawing.Color.LightGray;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.Location = new System.Drawing.Point(0, 30);
            this.grdProduct.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.ReadOnly = true;
            this.grdProduct.RowHeadersWidth = 51;
            this.grdProduct.RowTemplate.Height = 24;
            this.grdProduct.Size = new System.Drawing.Size(686, 332);
            this.grdProduct.TabIndex = 6;
            this.grdProduct.TabStop = false;
            this.grdProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 362);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(686, 28);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearchgrdProduct);
            this.panel4.Controls.Add(this.txtSearchgrdProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(686, 30);
            this.panel4.TabIndex = 0;
            // 
            // btnSearchgrdProduct
            // 
            this.btnSearchgrdProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(151)))), ((int)(((byte)(243)))));
            this.btnSearchgrdProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchgrdProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchgrdProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(151)))), ((int)(((byte)(243)))));
            this.btnSearchgrdProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchgrdProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchgrdProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSearchgrdProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchgrdProduct.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchgrdProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchgrdProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchgrdProduct.Image")));
            this.btnSearchgrdProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchgrdProduct.Location = new System.Drawing.Point(630, 0);
            this.btnSearchgrdProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchgrdProduct.Name = "btnSearchgrdProduct";
            this.btnSearchgrdProduct.Size = new System.Drawing.Size(56, 30);
            this.btnSearchgrdProduct.TabIndex = 2;
            this.btnSearchgrdProduct.TabStop = false;
            this.btnSearchgrdProduct.UseVisualStyleBackColor = false;
            this.btnSearchgrdProduct.Click += new System.EventHandler(this.btnSearchgrdProduct_Click);
            // 
            // txtSearchgrdProduct
            // 
            this.txtSearchgrdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchgrdProduct.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchgrdProduct.Location = new System.Drawing.Point(0, 0);
            this.txtSearchgrdProduct.Name = "txtSearchgrdProduct";
            this.txtSearchgrdProduct.Size = new System.Drawing.Size(686, 39);
            this.txtSearchgrdProduct.TabIndex = 0;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 799);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OrderForm";
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTempOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView grdTempOrder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTablenames;
        private System.Windows.Forms.ComboBox ddlTablename;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.ComboBox ddlWaiter;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.ComboBox ddlSection;
        private System.Windows.Forms.Label lblAddPosition;
        private MaterialSkin.Controls.MaterialButton btnRemovePosition;
        private System.Windows.Forms.TextBox txtPosition;
        private MaterialSkin.Controls.MaterialButton btnAddPosition;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox txtProductcode;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblheaderQty;
        private System.Windows.Forms.Label lblSelectedProductPrice;
        private System.Windows.Forms.Label lblHeaderTotal;
        private System.Windows.Forms.Label lblSelectedProductTotalPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearchgrdProduct;
        private System.Windows.Forms.TextBox txtSearchgrdProduct;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView grdOrder;
        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelOrder;
    }
}