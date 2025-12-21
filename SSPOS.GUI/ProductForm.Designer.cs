
namespace SSPOS.GUI
{
    partial class ProductForm
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.ddlProductnames = new System.Windows.Forms.ComboBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pnlSplit = new System.Windows.Forms.Panel();
            this.lblCardMessage = new System.Windows.Forms.Label();
            this.lblCardProductCode = new System.Windows.Forms.Label();
            this.lblCardProductName = new System.Windows.Forms.Label();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.grdProduct = new System.Windows.Forms.DataGridView();
            this.pnlFooter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.tableLayoutPanel1);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 451);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(971, 100);
            this.pnlFooter.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.89589F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.24935F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.71619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.13857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCheckCode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(186, 2);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(219, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "&Refresh";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(411, 2);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(321, 42);
            this.txtCode.TabIndex = 3;
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckCode.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnCheckCode.FlatAppearance.BorderSize = 0;
            this.btnCheckCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCheckCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCheckCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckCode.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCode.ForeColor = System.Drawing.Color.White;
            this.btnCheckCode.Location = new System.Drawing.Point(738, 2);
            this.btnCheckCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(230, 46);
            this.btnCheckCode.TabIndex = 3;
            this.btnCheckCode.Text = "&Check code";
            this.btnCheckCode.UseVisualStyleBackColor = false;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.splitContainer1);
            this.pnlHeader.Controls.Add(this.pnlHead);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(971, 190);
            this.pnlHeader.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 60);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.materialCard1);
            this.splitContainer1.Size = new System.Drawing.Size(971, 130);
            this.splitContainer1.SplitterDistance = 413;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.7485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.2515F));
            this.tableLayoutPanel2.Controls.Add(this.lblProduct, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ddlProductnames, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 130);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProduct.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(0, 0);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(103, 54);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Choose product";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ddlProductnames
            // 
            this.ddlProductnames.AllowDrop = true;
            this.ddlProductnames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ddlProductnames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ddlProductnames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlProductnames.DropDownHeight = 200;
            this.ddlProductnames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlProductnames.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlProductnames.FormattingEnabled = true;
            this.ddlProductnames.IntegralHeight = false;
            this.ddlProductnames.Location = new System.Drawing.Point(109, 2);
            this.ddlProductnames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlProductnames.Name = "ddlProductnames";
            this.ddlProductnames.Size = new System.Drawing.Size(301, 34);
            this.ddlProductnames.TabIndex = 0;
            this.ddlProductnames.SelectedIndexChanged += new System.EventHandler(this.ddlProductnames_SelectedIndexChanged);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pnlSplit);
            this.materialCard1.Controls.Add(this.lblCardMessage);
            this.materialCard1.Controls.Add(this.lblCardProductCode);
            this.materialCard1.Controls.Add(this.lblCardProductName);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(13, 14, 13, 14);
            this.materialCard1.Size = new System.Drawing.Size(554, 130);
            this.materialCard1.TabIndex = 0;
            // 
            // pnlSplit
            // 
            this.pnlSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSplit.BackColor = System.Drawing.Color.Navy;
            this.pnlSplit.Location = new System.Drawing.Point(5, 74);
            this.pnlSplit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.pnlSplit.Name = "pnlSplit";
            this.pnlSplit.Size = new System.Drawing.Size(549, 1);
            this.pnlSplit.TabIndex = 0;
            this.pnlSplit.Visible = false;
            // 
            // lblCardMessage
            // 
            this.lblCardMessage.AutoSize = true;
            this.lblCardMessage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardMessage.Location = new System.Drawing.Point(19, 91);
            this.lblCardMessage.Name = "lblCardMessage";
            this.lblCardMessage.Size = new System.Drawing.Size(55, 24);
            this.lblCardMessage.TabIndex = 2;
            this.lblCardMessage.Text = "label2";
            this.lblCardMessage.Visible = false;
            // 
            // lblCardProductCode
            // 
            this.lblCardProductCode.AutoSize = true;
            this.lblCardProductCode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardProductCode.Location = new System.Drawing.Point(19, 46);
            this.lblCardProductCode.Name = "lblCardProductCode";
            this.lblCardProductCode.Size = new System.Drawing.Size(55, 24);
            this.lblCardProductCode.TabIndex = 1;
            this.lblCardProductCode.Text = "label2";
            this.lblCardProductCode.Visible = false;
            // 
            // lblCardProductName
            // 
            this.lblCardProductName.AutoSize = true;
            this.lblCardProductName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardProductName.Location = new System.Drawing.Point(19, 7);
            this.lblCardProductName.Name = "lblCardProductName";
            this.lblCardProductName.Size = new System.Drawing.Size(55, 24);
            this.lblCardProductName.TabIndex = 0;
            this.lblCardProductName.Text = "label2";
            this.lblCardProductName.Visible = false;
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.label1);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(971, 60);
            this.pnlHead.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product management";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.splitter1);
            this.pnlBody.Controls.Add(this.grdProduct);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 190);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(971, 261);
            this.pnlBody.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 261);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // grdProduct
            // 
            this.grdProduct.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduct.Location = new System.Drawing.Point(0, 0);
            this.grdProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdProduct.Name = "grdProduct";
            this.grdProduct.RowHeadersWidth = 51;
            this.grdProduct.RowTemplate.Height = 24;
            this.grdProduct.Size = new System.Drawing.Size(971, 261);
            this.grdProduct.TabIndex = 0;
            this.grdProduct.TabStop = false;
            this.grdProduct.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.grdProduct_CellBeginEdit);
            this.grdProduct.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellEndEdit);
            this.grdProduct.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdProduct_CellValidating);
            this.grdProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduct_CellValueChanged);
            this.grdProduct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdProduct_DataBindingComplete);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 551);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductForm";
            this.Text = "1";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductForm_KeyDown);
            this.pnlFooter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnCheckCode;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox ddlProductnames;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView grdProduct;
        private System.Windows.Forms.Panel pnlSplit;
        private System.Windows.Forms.Label lblCardMessage;
        private System.Windows.Forms.Label lblCardProductCode;
        private System.Windows.Forms.Label lblCardProductName;
    }
}