
namespace SSPOS.GUI
{
    partial class TestForm
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
            this.ddlUOMs = new System.Windows.Forms.ComboBox();
            this.ddlSubCatogory = new System.Windows.Forms.ComboBox();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.lblUOM = new System.Windows.Forms.Label();
            this.lblSubCatogory = new System.Windows.Forms.Label();
            this.lblCatogory = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.ddlUOMs.Location = new System.Drawing.Point(887, 225);
            this.ddlUOMs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlUOMs.Name = "ddlUOMs";
            this.ddlUOMs.Size = new System.Drawing.Size(251, 39);
            this.ddlUOMs.TabIndex = 21;
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
            this.ddlSubCatogory.Location = new System.Drawing.Point(220, 232);
            this.ddlSubCatogory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlSubCatogory.Name = "ddlSubCatogory";
            this.ddlSubCatogory.Size = new System.Drawing.Size(251, 39);
            this.ddlSubCatogory.TabIndex = 20;
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
            this.ddlCategory.Location = new System.Drawing.Point(854, 434);
            this.ddlCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(181, 39);
            this.ddlCategory.TabIndex = 19;
            // 
            // lblUOM
            // 
            this.lblUOM.AutoSize = true;
            this.lblUOM.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUOM.Location = new System.Drawing.Point(768, 232);
            this.lblUOM.Name = "lblUOM";
            this.lblUOM.Size = new System.Drawing.Size(67, 27);
            this.lblUOM.TabIndex = 16;
            this.lblUOM.Text = "UOM";
            // 
            // lblSubCatogory
            // 
            this.lblSubCatogory.AutoSize = true;
            this.lblSubCatogory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCatogory.Location = new System.Drawing.Point(-37, 239);
            this.lblSubCatogory.Name = "lblSubCatogory";
            this.lblSubCatogory.Size = new System.Drawing.Size(251, 27);
            this.lblSubCatogory.TabIndex = 17;
            this.lblSubCatogory.Text = "Product Sub Catogory";
            // 
            // lblCatogory
            // 
            this.lblCatogory.AutoSize = true;
            this.lblCatogory.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatogory.Location = new System.Drawing.Point(635, 446);
            this.lblCatogory.Name = "lblCatogory";
            this.lblCatogory.Size = new System.Drawing.Size(200, 27);
            this.lblCatogory.TabIndex = 18;
            this.lblCatogory.Text = "Product Catogory";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 694);
            this.Controls.Add(this.ddlUOMs);
            this.Controls.Add(this.ddlSubCatogory);
            this.Controls.Add(this.ddlCategory);
            this.Controls.Add(this.lblUOM);
            this.Controls.Add(this.lblSubCatogory);
            this.Controls.Add(this.lblCatogory);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlUOMs;
        private System.Windows.Forms.ComboBox ddlSubCatogory;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.Label lblUOM;
        private System.Windows.Forms.Label lblSubCatogory;
        private System.Windows.Forms.Label lblCatogory;
    }
}