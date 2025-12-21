
namespace SSPOS.GUI
{
    partial class BillingForm
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
            this.PblHead = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nonTaxCharges = new System.Windows.Forms.Label();
            this.lblNonTaxCharges = new System.Windows.Forms.Label();
            this.Recipts = new System.Windows.Forms.Label();
            this.lblReceipts = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemTotal = new System.Windows.Forms.Label();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.TotalItem = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblBillHead = new System.Windows.Forms.Label();
            this.grdBillSetUp = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSettleOrder = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkPreviewPrint = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.lblTablePosition = new System.Windows.Forms.Label();
            this.TablePosition = new System.Windows.Forms.Label();
            this.rdbPercentage = new System.Windows.Forms.RadioButton();
            this.rdbAmount = new System.Windows.Forms.RadioButton();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.BillNumber = new System.Windows.Forms.Label();
            this.BillDate = new System.Windows.Forms.Label();
            this.dtpBillDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblTablenames = new System.Windows.Forms.Label();
            this.ddlTablename = new System.Windows.Forms.ComboBox();
            this.rdoStatusSettled = new System.Windows.Forms.RadioButton();
            this.rdoStatusBilled = new System.Windows.Forms.RadioButton();
            this.grdBilling = new System.Windows.Forms.DataGridView();
            this.grdPendingOrder = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblGridHead = new System.Windows.Forms.Label();
            this.lblRoundOffAmount = new System.Windows.Forms.Label();
            this.lblBillingTotal = new System.Windows.Forms.Label();
            this.BillTotal = new System.Windows.Forms.Label();
            this.RoundOff = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.PblHead.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillSetUp)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBilling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPendingOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // PblHead
            // 
            this.PblHead.Controls.Add(this.lblHeader);
            this.PblHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PblHead.Location = new System.Drawing.Point(0, 0);
            this.PblHead.Name = "PblHead";
            this.PblHead.Size = new System.Drawing.Size(1500, 51);
            this.PblHead.TabIndex = 0;
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
            this.lblHeader.Size = new System.Drawing.Size(247, 34);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Billing and Print";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.splitContainer1);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 51);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1500, 749);
            this.pnlBody.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rdoStatusSettled);
            this.splitContainer1.Panel2.Controls.Add(this.rdoStatusBilled);
            this.splitContainer1.Panel2.Controls.Add(this.grdBilling);
            this.splitContainer1.Panel2.Controls.Add(this.grdPendingOrder);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1500, 749);
            this.splitContainer1.SplitterDistance = 790;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.materialCard1);
            this.panel3.Controls.Add(this.grdBillSetUp);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 562);
            this.panel3.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tableLayoutPanel4);
            this.materialCard1.Controls.Add(this.tableLayoutPanel3);
            this.materialCard1.Controls.Add(this.tableLayoutPanel2);
            this.materialCard1.Controls.Add(this.panel5);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 281);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(790, 202);
            this.materialCard1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.nonTaxCharges, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblNonTaxCharges, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Recipts, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblReceipts, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(293, 65);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(172, 123);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // nonTaxCharges
            // 
            this.nonTaxCharges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nonTaxCharges.AutoSize = true;
            this.nonTaxCharges.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonTaxCharges.ForeColor = System.Drawing.Color.Black;
            this.nonTaxCharges.Location = new System.Drawing.Point(5, 10);
            this.nonTaxCharges.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.nonTaxCharges.Name = "nonTaxCharges";
            this.nonTaxCharges.Size = new System.Drawing.Size(76, 23);
            this.nonTaxCharges.TabIndex = 71;
            this.nonTaxCharges.Text = "Non tax charges";
            this.nonTaxCharges.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNonTaxCharges
            // 
            this.lblNonTaxCharges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNonTaxCharges.AutoSize = true;
            this.lblNonTaxCharges.BackColor = System.Drawing.Color.Transparent;
            this.lblNonTaxCharges.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonTaxCharges.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblNonTaxCharges.Location = new System.Drawing.Point(91, 10);
            this.lblNonTaxCharges.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblNonTaxCharges.Name = "lblNonTaxCharges";
            this.lblNonTaxCharges.Size = new System.Drawing.Size(76, 23);
            this.lblNonTaxCharges.TabIndex = 73;
            this.lblNonTaxCharges.Text = "0";
            this.lblNonTaxCharges.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Recipts
            // 
            this.Recipts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Recipts.AutoSize = true;
            this.Recipts.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipts.ForeColor = System.Drawing.Color.Black;
            this.Recipts.Location = new System.Drawing.Point(5, 48);
            this.Recipts.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.Recipts.Name = "Recipts";
            this.Recipts.Size = new System.Drawing.Size(76, 23);
            this.Recipts.TabIndex = 76;
            this.Recipts.Text = "Receipts";
            this.Recipts.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblReceipts
            // 
            this.lblReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReceipts.AutoSize = true;
            this.lblReceipts.BackColor = System.Drawing.Color.Transparent;
            this.lblReceipts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipts.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblReceipts.Location = new System.Drawing.Point(91, 48);
            this.lblReceipts.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblReceipts.Name = "lblReceipts";
            this.lblReceipts.Size = new System.Drawing.Size(76, 23);
            this.lblReceipts.TabIndex = 75;
            this.lblReceipts.Text = "0";
            this.lblReceipts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.64875F));
            this.tableLayoutPanel2.Controls.Add(this.ItemTotal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBillTotal, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TotalItem, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalItems, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.34146F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.08943F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.38211F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 123);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ItemTotal
            // 
            this.ItemTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemTotal.AutoSize = true;
            this.ItemTotal.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemTotal.ForeColor = System.Drawing.Color.Black;
            this.ItemTotal.Location = new System.Drawing.Point(5, 10);
            this.ItemTotal.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.ItemTotal.Name = "ItemTotal";
            this.ItemTotal.Size = new System.Drawing.Size(96, 41);
            this.ItemTotal.TabIndex = 70;
            this.ItemTotal.Text = "Item Total amount";
            this.ItemTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillTotal.AutoSize = true;
            this.lblBillTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblBillTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblBillTotal.Location = new System.Drawing.Point(111, 10);
            this.lblBillTotal.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(163, 28);
            this.lblBillTotal.TabIndex = 72;
            this.lblBillTotal.Text = "0";
            this.lblBillTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalItem
            // 
            this.TotalItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalItem.AutoSize = true;
            this.TotalItem.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItem.ForeColor = System.Drawing.Color.Black;
            this.TotalItem.Location = new System.Drawing.Point(5, 66);
            this.TotalItem.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.TotalItem.Name = "TotalItem";
            this.TotalItem.Size = new System.Drawing.Size(96, 37);
            this.TotalItem.TabIndex = 73;
            this.TotalItem.Text = "Total item count";
            this.TotalItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTotalItems.Location = new System.Drawing.Point(111, 66);
            this.lblTotalItems.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(163, 28);
            this.lblTotalItems.TabIndex = 74;
            this.lblTotalItems.Text = "0";
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblBillHead);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(14, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(762, 51);
            this.panel5.TabIndex = 0;
            // 
            // lblBillHead
            // 
            this.lblBillHead.AutoSize = true;
            this.lblBillHead.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillHead.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblBillHead.Location = new System.Drawing.Point(8, 8);
            this.lblBillHead.Name = "lblBillHead";
            this.lblBillHead.Size = new System.Drawing.Size(195, 33);
            this.lblBillHead.TabIndex = 0;
            this.lblBillHead.Text = "Bill informations";
            // 
            // grdBillSetUp
            // 
            this.grdBillSetUp.AllowUserToAddRows = false;
            this.grdBillSetUp.AllowUserToDeleteRows = false;
            this.grdBillSetUp.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdBillSetUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBillSetUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdBillSetUp.Location = new System.Drawing.Point(0, 0);
            this.grdBillSetUp.Name = "grdBillSetUp";
            this.grdBillSetUp.RowHeadersWidth = 51;
            this.grdBillSetUp.RowTemplate.Height = 24;
            this.grdBillSetUp.Size = new System.Drawing.Size(790, 281);
            this.grdBillSetUp.TabIndex = 1;
            this.grdBillSetUp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBillSetUp_CellDoubleClick);
            this.grdBillSetUp.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBillSetUp_CellEndEdit);
            this.grdBillSetUp.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdBillSetUp_CellFormatting);
            this.grdBillSetUp.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.grdBillSetUp_DataError);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSettleOrder);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(790, 79);
            this.panel4.TabIndex = 0;
            // 
            // btnSettleOrder
            // 
            this.btnSettleOrder.BackColor = System.Drawing.Color.Orange;
            this.btnSettleOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettleOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSettleOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSettleOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSettleOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettleOrder.ForeColor = System.Drawing.Color.White;
            this.btnSettleOrder.Location = new System.Drawing.Point(163, 17);
            this.btnSettleOrder.Name = "btnSettleOrder";
            this.btnSettleOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSettleOrder.Size = new System.Drawing.Size(170, 39);
            this.btnSettleOrder.TabIndex = 2;
            this.btnSettleOrder.Text = "Settle order";
            this.btnSettleOrder.UseVisualStyleBackColor = false;
            this.btnSettleOrder.Click += new System.EventHandler(this.btnSettleOrder_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(44, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrint.Size = new System.Drawing.Size(104, 39);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkPreviewPrint);
            this.panel2.Controls.Add(this.txtBillNumber);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.status);
            this.panel2.Controls.Add(this.lblTablePosition);
            this.panel2.Controls.Add(this.TablePosition);
            this.panel2.Controls.Add(this.rdbPercentage);
            this.panel2.Controls.Add(this.rdbAmount);
            this.panel2.Controls.Add(this.txtDiscount);
            this.panel2.Controls.Add(this.lblDiscount);
            this.panel2.Controls.Add(this.BillNumber);
            this.panel2.Controls.Add(this.BillDate);
            this.panel2.Controls.Add(this.dtpBillDateTime);
            this.panel2.Controls.Add(this.lblTablenames);
            this.panel2.Controls.Add(this.ddlTablename);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 187);
            this.panel2.TabIndex = 0;
            // 
            // chkPreviewPrint
            // 
            this.chkPreviewPrint.AutoSize = true;
            this.chkPreviewPrint.Depth = 0;
            this.chkPreviewPrint.Location = new System.Drawing.Point(630, 118);
            this.chkPreviewPrint.Margin = new System.Windows.Forms.Padding(0);
            this.chkPreviewPrint.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPreviewPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPreviewPrint.Name = "chkPreviewPrint";
            this.chkPreviewPrint.ReadOnly = false;
            this.chkPreviewPrint.Ripple = true;
            this.chkPreviewPrint.Size = new System.Drawing.Size(139, 37);
            this.chkPreviewPrint.TabIndex = 46;
            this.chkPreviewPrint.Text = "Preview Print ?";
            this.chkPreviewPrint.UseVisualStyleBackColor = true;
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBillNumber.Enabled = false;
            this.txtBillNumber.Location = new System.Drawing.Point(142, 15);
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(178, 34);
            this.txtBillNumber.TabIndex = 45;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStatus.Location = new System.Drawing.Point(683, 72);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(93, 28);
            this.lblStatus.TabIndex = 44;
            this.lblStatus.Text = "Not set";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // status
            // 
            this.status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.Location = new System.Drawing.Point(601, 72);
            this.status.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(81, 27);
            this.status.TabIndex = 43;
            this.status.Text = "Status";
            this.status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTablePosition
            // 
            this.lblTablePosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTablePosition.AutoSize = true;
            this.lblTablePosition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablePosition.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTablePosition.Location = new System.Drawing.Point(498, 71);
            this.lblTablePosition.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblTablePosition.Name = "lblTablePosition";
            this.lblTablePosition.Size = new System.Drawing.Size(93, 28);
            this.lblTablePosition.TabIndex = 42;
            this.lblTablePosition.Text = "Not set";
            this.lblTablePosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TablePosition
            // 
            this.TablePosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablePosition.AutoSize = true;
            this.TablePosition.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablePosition.ForeColor = System.Drawing.Color.Black;
            this.TablePosition.Location = new System.Drawing.Point(404, 72);
            this.TablePosition.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.TablePosition.Name = "TablePosition";
            this.TablePosition.Size = new System.Drawing.Size(97, 27);
            this.TablePosition.TabIndex = 41;
            this.TablePosition.Text = "Position";
            this.TablePosition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdbPercentage
            // 
            this.rdbPercentage.AutoSize = true;
            this.rdbPercentage.Location = new System.Drawing.Point(434, 122);
            this.rdbPercentage.Name = "rdbPercentage";
            this.rdbPercentage.Size = new System.Drawing.Size(193, 31);
            this.rdbPercentage.TabIndex = 40;
            this.rdbPercentage.Text = "Percentage(%)";
            this.rdbPercentage.UseVisualStyleBackColor = true;
            this.rdbPercentage.CheckedChanged += new System.EventHandler(this.rdbPercentage_CheckedChanged);
            // 
            // rdbAmount
            // 
            this.rdbAmount.AutoSize = true;
            this.rdbAmount.Checked = true;
            this.rdbAmount.Location = new System.Drawing.Point(297, 122);
            this.rdbAmount.Name = "rdbAmount";
            this.rdbAmount.Size = new System.Drawing.Size(116, 31);
            this.rdbAmount.TabIndex = 39;
            this.rdbAmount.TabStop = true;
            this.rdbAmount.Text = "Amount";
            this.rdbAmount.UseVisualStyleBackColor = true;
            this.rdbAmount.CheckedChanged += new System.EventHandler(this.rdbAmount_CheckedChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(133, 119);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(142, 34);
            this.txtDiscount.TabIndex = 38;
            this.txtDiscount.Text = "0.00";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.Black;
            this.lblDiscount.Location = new System.Drawing.Point(4, 119);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(106, 27);
            this.lblDiscount.TabIndex = 37;
            this.lblDiscount.Text = "Discount";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BillNumber
            // 
            this.BillNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillNumber.AutoSize = true;
            this.BillNumber.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumber.ForeColor = System.Drawing.Color.Black;
            this.BillNumber.Location = new System.Drawing.Point(4, 13);
            this.BillNumber.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.Size = new System.Drawing.Size(135, 27);
            this.BillNumber.TabIndex = 31;
            this.BillNumber.Text = "Bill number";
            this.BillNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BillDate
            // 
            this.BillDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillDate.AutoSize = true;
            this.BillDate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDate.ForeColor = System.Drawing.Color.Black;
            this.BillDate.Location = new System.Drawing.Point(328, 15);
            this.BillDate.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.BillDate.Name = "BillDate";
            this.BillDate.Size = new System.Drawing.Size(106, 27);
            this.BillDate.TabIndex = 33;
            this.BillDate.Text = "Bill date ";
            this.BillDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpBillDateTime
            // 
            this.dtpBillDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBillDateTime.CalendarFont = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDateTime.Location = new System.Drawing.Point(434, 13);
            this.dtpBillDateTime.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.dtpBillDateTime.Name = "dtpBillDateTime";
            this.dtpBillDateTime.ShowUpDown = true;
            this.dtpBillDateTime.Size = new System.Drawing.Size(351, 34);
            this.dtpBillDateTime.TabIndex = 34;
            // 
            // lblTablenames
            // 
            this.lblTablenames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTablenames.AutoSize = true;
            this.lblTablenames.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTablenames.ForeColor = System.Drawing.Color.Black;
            this.lblTablenames.Location = new System.Drawing.Point(4, 71);
            this.lblTablenames.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblTablenames.Name = "lblTablenames";
            this.lblTablenames.Size = new System.Drawing.Size(81, 27);
            this.lblTablenames.TabIndex = 35;
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
            this.ddlTablename.Location = new System.Drawing.Point(104, 65);
            this.ddlTablename.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.ddlTablename.Name = "ddlTablename";
            this.ddlTablename.Size = new System.Drawing.Size(290, 39);
            this.ddlTablename.TabIndex = 36;
            this.ddlTablename.SelectedIndexChanged += new System.EventHandler(this.ddlTablename_SelectedIndexChanged);
            // 
            // rdoStatusSettled
            // 
            this.rdoStatusSettled.AutoSize = true;
            this.rdoStatusSettled.Location = new System.Drawing.Point(180, 411);
            this.rdoStatusSettled.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.rdoStatusSettled.Name = "rdoStatusSettled";
            this.rdoStatusSettled.Size = new System.Drawing.Size(146, 31);
            this.rdoStatusSettled.TabIndex = 0;
            this.rdoStatusSettled.Text = "Settled list";
            this.rdoStatusSettled.UseVisualStyleBackColor = true;
            this.rdoStatusSettled.CheckedChanged += new System.EventHandler(this.rdoStatusSettled_CheckedChanged);
            // 
            // rdoStatusBilled
            // 
            this.rdoStatusBilled.AutoSize = true;
            this.rdoStatusBilled.Checked = true;
            this.rdoStatusBilled.Location = new System.Drawing.Point(20, 411);
            this.rdoStatusBilled.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.rdoStatusBilled.Name = "rdoStatusBilled";
            this.rdoStatusBilled.Size = new System.Drawing.Size(130, 31);
            this.rdoStatusBilled.TabIndex = 0;
            this.rdoStatusBilled.TabStop = true;
            this.rdoStatusBilled.Text = "Billed list";
            this.rdoStatusBilled.UseVisualStyleBackColor = true;
            this.rdoStatusBilled.CheckedChanged += new System.EventHandler(this.rdoStatusBilled_CheckedChanged);
            // 
            // grdBilling
            // 
            this.grdBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBilling.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdBilling.Location = new System.Drawing.Point(0, 448);
            this.grdBilling.Name = "grdBilling";
            this.grdBilling.RowHeadersWidth = 51;
            this.grdBilling.RowTemplate.Height = 24;
            this.grdBilling.Size = new System.Drawing.Size(706, 301);
            this.grdBilling.TabIndex = 5;
            // 
            // grdPendingOrder
            // 
            this.grdPendingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPendingOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdPendingOrder.Location = new System.Drawing.Point(0, 42);
            this.grdPendingOrder.Name = "grdPendingOrder";
            this.grdPendingOrder.RowHeadersWidth = 51;
            this.grdPendingOrder.RowTemplate.Height = 24;
            this.grdPendingOrder.Size = new System.Drawing.Size(706, 357);
            this.grdPendingOrder.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 42);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblGridHead);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(706, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblGridHead
            // 
            this.lblGridHead.AutoSize = true;
            this.lblGridHead.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridHead.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGridHead.Location = new System.Drawing.Point(3, 0);
            this.lblGridHead.Name = "lblGridHead";
            this.lblGridHead.Size = new System.Drawing.Size(225, 33);
            this.lblGridHead.TabIndex = 5;
            this.lblGridHead.Text = "Running orders list";
            // 
            // lblRoundOffAmount
            // 
            this.lblRoundOffAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoundOffAmount.AutoSize = true;
            this.lblRoundOffAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundOffAmount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundOffAmount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRoundOffAmount.Location = new System.Drawing.Point(111, 71);
            this.lblRoundOffAmount.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblRoundOffAmount.Name = "lblRoundOffAmount";
            this.lblRoundOffAmount.Size = new System.Drawing.Size(195, 28);
            this.lblRoundOffAmount.TabIndex = 79;
            this.lblRoundOffAmount.Text = "0";
            this.lblRoundOffAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBillingTotal
            // 
            this.lblBillingTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBillingTotal.AutoSize = true;
            this.lblBillingTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblBillingTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillingTotal.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblBillingTotal.Location = new System.Drawing.Point(111, 10);
            this.lblBillingTotal.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblBillingTotal.Name = "lblBillingTotal";
            this.lblBillingTotal.Size = new System.Drawing.Size(195, 28);
            this.lblBillingTotal.TabIndex = 77;
            this.lblBillingTotal.Text = "0";
            this.lblBillingTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BillTotal
            // 
            this.BillTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BillTotal.AutoSize = true;
            this.BillTotal.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillTotal.ForeColor = System.Drawing.Color.Black;
            this.BillTotal.Location = new System.Drawing.Point(5, 10);
            this.BillTotal.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.BillTotal.Name = "BillTotal";
            this.BillTotal.Size = new System.Drawing.Size(96, 22);
            this.BillTotal.TabIndex = 76;
            this.BillTotal.Text = "Bill total";
            this.BillTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RoundOff
            // 
            this.RoundOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoundOff.AutoSize = true;
            this.RoundOff.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundOff.ForeColor = System.Drawing.Color.Black;
            this.RoundOff.Location = new System.Drawing.Point(5, 71);
            this.RoundOff.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.RoundOff.Name = "RoundOff";
            this.RoundOff.Size = new System.Drawing.Size(96, 47);
            this.RoundOff.TabIndex = 78;
            this.RoundOff.Text = "Total Bill receivable";
            this.RoundOff.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0836F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.9164F));
            this.tableLayoutPanel4.Controls.Add(this.RoundOff, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.BillTotal, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblBillingTotal, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblRoundOffAmount, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(465, 65);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(311, 123);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.PblHead);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "BillingForm";
            this.Text = "BillingForm";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.PblHead.ResumeLayout(false);
            this.PblHead.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBillSetUp)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBilling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPendingOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PblHead;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BillNumber;
        private System.Windows.Forms.Label BillDate;
        private System.Windows.Forms.DateTimePicker dtpBillDateTime;
        private System.Windows.Forms.Label lblTablenames;
        private System.Windows.Forms.ComboBox ddlTablename;
        private System.Windows.Forms.RadioButton rdbPercentage;
        private System.Windows.Forms.RadioButton rdbAmount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTablePosition;
        private System.Windows.Forms.Label TablePosition;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grdBillSetUp;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblBillHead;
        private System.Windows.Forms.Button btnSettleOrder;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ItemTotal;
        private System.Windows.Forms.Label lblBillTotal;
        private System.Windows.Forms.Label TotalItem;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Recipts;
        private System.Windows.Forms.Label nonTaxCharges;
        private System.Windows.Forms.Label lblNonTaxCharges;
        private System.Windows.Forms.Label lblReceipts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rdoStatusBilled;
        private System.Windows.Forms.RadioButton rdoStatusSettled;
        private MaterialSkin.Controls.MaterialCheckbox chkPreviewPrint;
        private System.Windows.Forms.DataGridView grdPendingOrder;
        private System.Windows.Forms.DataGridView grdBilling;
        private System.Windows.Forms.Label lblGridHead;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label RoundOff;
        private System.Windows.Forms.Label BillTotal;
        private System.Windows.Forms.Label lblBillingTotal;
        private System.Windows.Forms.Label lblRoundOffAmount;
    }
}