using SSPOS.BLL;
using SSPOS.GUI.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSPOS
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            pageSetup();
        }

        protected void pageSetup()
        {
            PopulateCategories();
            List<Report> lstReport = getAnalysisReport();
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy : hh:mm");
        }

        private void PopulateCategories()
        {
            var categories = Category.RetrieveAll(true);
            SetupDropdown(ddlCategory, categories, "CategoryName", "Id");
        }

        private void PopulateSubCategories(string category)
        {
            var subCategories = Category.RetrieveByCategory(category, true);
            SetupDropdown(ddlSubCatogory, subCategories, "Subcategory", "Id");
            ddlSubCatogory.Enabled = true;
        }

        private void PopulateUOMs(string subCategory, string category)
        {
            var uoms = Category.RetrieveBySubcategory(subCategory, category, true);
            SetupDropdown(ddlUOMs, uoms, "UOM", "Id");
            ddlUOMs.Enabled = true;
        }

        private void SetupDropdown<T>(ComboBox dropdown, List<T> dataSource, string displayMember, string valueMember)
        {
            dropdown.DataSource = dataSource;
            dropdown.DisplayMember = displayMember;
            dropdown.ValueMember = valueMember;
            dropdown.SelectedIndex = -1;
            dropdown.Refresh();
        }

        private void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCategory.SelectedItem is Category selectedCategory)
            {
                PopulateSubCategories(selectedCategory.CategoryName);
            }
        }

        private void ddlSubCatogory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSubCatogory.SelectedItem is Category selectedSubCategory &&
               ddlCategory.SelectedItem is Category selectedCategory)
            {
                PopulateUOMs(selectedSubCategory.Subcategory, selectedCategory.CategoryName);
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            SetDropdownStates(!chkAll.Checked);
        }

        private void SetDropdownStates(bool enabled)
        {
            ddlCategory.Enabled = enabled;
            ddlSubCatogory.Enabled = enabled;
            ddlUOMs.Enabled = enabled;

            if (!enabled)
            {
                ResetDropdowns();
            }
            else
            {
                InitializeDropdowns();
            }
        }

        private void ResetDropdowns()
        {
            ddlCategory.SelectedIndex = -1;
            ddlSubCatogory.SelectedIndex = -1;
            ddlUOMs.SelectedIndex = -1;
        }

        private void InitializeDropdowns()
        {
            ddlCategory.SelectedIndex = 0;
            ddlSubCatogory.SelectedIndex = 0;
            ddlUOMs.SelectedIndex = 0;
        }


        private List<Report> getAnalysisReport()
        {
            List<Report> lstAnalysisReport = new List<Report>();

            try
            {
                var selectedCategory = ddlCategory.SelectedItem as Category;
                var selectedSubcategory = ddlSubCatogory.SelectedItem as Category;
                var selectedUOM = ddlUOMs.SelectedItem as Category;

                // Ensure safe null handling
                string selectedCategoryName = selectedCategory != null ? selectedCategory.CategoryName : null;
                string selectedSubcategoryName = selectedSubcategory != null ? selectedSubcategory.Subcategory : null;
                string selectedUOMName = selectedUOM != null ? selectedUOM.UOM : null;

                // Pass string values instead of objects
                lstAnalysisReport = Report.GetSalesReport(selectedCategoryName, selectedSubcategoryName, selectedUOMName);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in search results:" + ex);
              
            }
            return lstAnalysisReport;

        }
        private void PopulateAnalysisReport(List<Report> reportData)
        {
            dgvAnalysisReport.Rows.Clear();
            dgvAnalysisReport.Columns.Clear();

            // Define Columns
            dgvAnalysisReport.ColumnCount = 3;
            dgvAnalysisReport.Columns[0].Name = "Item";
            dgvAnalysisReport.Columns[1].Name = "Qty";
            dgvAnalysisReport.Columns[2].Name = "Amount";

            decimal grandTotalAmount = 0;
            int grandTotalQty = 0;
            string currentCategory = string.Empty;
            string currentSubCategory = string.Empty;

            int subcategoryTotalQty = 0;
            decimal subcategoryTotalAmount = 0;

            foreach (var report in reportData)
            {
                // Check for new Category
                if (currentCategory != report.CategoryName)
                {
                    dgvAnalysisReport.Rows.Add(new object[] { $"Category: {report.CategoryName}", "", "" });
                    currentCategory = report.CategoryName;
                    currentSubCategory = string.Empty; // Reset subcategory
                }

                // Check for new SubCategory
                if (currentSubCategory != report.SubCategoryName)
                {
                    // If it's not the first subcategory, reset totals
                    if (!string.IsNullOrEmpty(currentSubCategory))
                    {
                        dgvAnalysisReport.Rows.Add(new object[] { "", "", "" }); // Empty row for spacing
                    }

                    // Calculate new subcategory totals
                    subcategoryTotalQty = reportData
                        .Where(r => r.SubCategoryName == report.SubCategoryName)
                        .Sum(r => r.Qty);

                    subcategoryTotalAmount = reportData
                        .Where(r => r.SubCategoryName == report.SubCategoryName)
                        .Sum(r => r.TotalAmount);

                    // Add Subcategory Header with its total Qty and Amount
                    dgvAnalysisReport.Rows.Add(new object[] { $"   Subcategory: {report.SubCategoryName}", subcategoryTotalQty, subcategoryTotalAmount.ToString("C2") });

                    currentSubCategory = report.SubCategoryName;
                }

                // Add Product Row
                dgvAnalysisReport.Rows.Add(new object[] { report.ProductName, report.Qty, report.TotalAmount });

                // Update Grand Totals
                grandTotalQty += report.Qty;
                grandTotalAmount += report.TotalAmount;
            }

            // Add Grand Total Row
            dgvAnalysisReport.Rows.Add(new object[] { "", "", "" }); // Empty row for spacing
            dgvAnalysisReport.Rows.Add(new object[] { "Grand Total", grandTotalQty, grandTotalAmount.ToString("C2") });

            // Apply Formatting
            FormatDataGridView();
        }



        private void FormatDataGridView()
        {
            dgvAnalysisReport.EnableHeadersVisualStyles = false;
            dgvAnalysisReport.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dgvAnalysisReport.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            dgvAnalysisReport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAnalysisReport.DefaultCellStyle.Font = new Font("Arial", 9);
            dgvAnalysisReport.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAnalysisReport.RowHeadersVisible = false;
            dgvAnalysisReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnalysisReport.AllowUserToAddRows = false;
            dgvAnalysisReport.ReadOnly = true;

            // Styling for Category & Subcategory Rows
            foreach (DataGridViewRow row in dgvAnalysisReport.Rows)
            {
                string firstCellText = row.Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(firstCellText))
                {
                    if (firstCellText.StartsWith("Category:"))
                    {
                        row.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else if (firstCellText.StartsWith("   Subcategory:"))
                    {
                        row.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Italic);
                        row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                    else if (firstCellText == "Grand Total")
                    {
                        row.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                        row.DefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }

            dgvAnalysisReport.ClearSelection();
            dgvAnalysisReport.CurrentCell = null;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            List<Report> lstReport = getAnalysisReport();
            PopulateAnalysisReport(lstReport);
            PopulateSummarizedReport(lstReport);
        }


        private void PopulateSummarizedReport(List<Report> reportData)
        {
            dgvDailyReport.Rows.Clear();
            dgvDailyReport.Columns.Clear();

            // Define Columns
            dgvDailyReport.ColumnCount = 3;
            dgvDailyReport.Columns[0].Name = "Category";
            dgvDailyReport.Columns[1].Name = "Total Qty";
            dgvDailyReport.Columns[2].Name = "Total Amount";

            decimal grandTotalAmount = 0;
            int grandTotalQty = 0;

            // Group data by Category
            var categorySummary = reportData
                .GroupBy(r => r.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    TotalQty = g.Sum(r => r.Qty),
                    TotalAmount = g.Sum(r => r.TotalAmount)
                })
                .ToList();

            // Add each summarized row
            foreach (var summary in categorySummary)
            {
                dgvDailyReport.Rows.Add(new object[] { summary.CategoryName, summary.TotalQty, summary.TotalAmount.ToString("C2") });

                // Update Grand Totals
                grandTotalQty += summary.TotalQty;
                grandTotalAmount += summary.TotalAmount;
            }

            // Add Grand Total Row
            dgvDailyReport.Rows.Add(new object[] { "Grand Total", grandTotalQty, grandTotalAmount.ToString("C2") });

            // Apply Formatting
            FormatDataGridView(dgvDailyReport);
        }

        private void FormatDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Light Gray
            dgv.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Rows[dgv.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Blue;
            dgv.ClearSelection();
            dgv.CurrentCell = null;
        }

        private void PrintAnalysisReport(List<Report> lstReport)
        {
            string restaurantName = ConfigManager.Settings.RestaurantName;
            string dateTimeStr = DateTime.Now.ToString("dd-MM-yyyy : hh:mm");
            string headerText = "ANALYSIS REPORT";

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 315, 600);
            pd.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);

            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                int startX = e.MarginBounds.Left;
                int startY = e.MarginBounds.Top;
                int offsetY = 0;

                Font headerFont = new Font("Courier New", 12, FontStyle.Bold);
                Font regularFont = new Font("Courier New", 10, FontStyle.Regular);
                Font smallFont = new Font("Courier New", 8, FontStyle.Regular);

                void DrawCenteredString(string text, Font font, int yPos)
                {
                    SizeF textSize = g.MeasureString(text, font);
                    float xPos = startX + ((e.MarginBounds.Width - textSize.Width) / 2);
                    g.DrawString(text, font, Brushes.Black, xPos, yPos);
                }

                // Draw report header
                DrawCenteredString(restaurantName.ToUpper(), headerFont, startY + offsetY);
                offsetY += 20;
                DrawCenteredString(headerText, headerFont, startY + offsetY);
                offsetY += 20;
                DrawCenteredString($"DATE: {dateTimeStr}", smallFont, startY + offsetY);
                offsetY += 15;

                g.DrawLine(Pens.Black, startX, startY + offsetY, e.MarginBounds.Right, startY + offsetY);
                offsetY += 5;

                // Define column positions
                int col1X = startX;          // For Item name
                int col2X = startX + 180;    // For Quantity
                int col3X = startX + 260;    // For Amount

                // Draw column headers with right alignment for QTY and AMT
                g.DrawString("ITEM", regularFont, Brushes.Black, col1X, startY + offsetY);
                g.DrawString("QTY", regularFont, Brushes.Black, col2X, startY + offsetY);
                g.DrawString("AMT", regularFont, Brushes.Black, col3X, startY + offsetY);
                offsetY += 15;

                g.DrawLine(Pens.Black, startX, startY + offsetY, e.MarginBounds.Right, startY + offsetY);
                offsetY += 5;

                decimal subTotal = 0;
                int subQty = 0;

                // Group reports by Category then by SubCategory
                foreach (var catGroup in lstReport.GroupBy(r => r.CategoryName))
                {
                    g.DrawString(catGroup.Key.ToUpper(), regularFont, Brushes.Black, col1X, startY + offsetY);
                    offsetY += 15;

                    foreach (var subGroup in catGroup.GroupBy(r => r.SubCategoryName))
                    {
                        g.DrawString($"  {subGroup.Key}:", smallFont, Brushes.Black, col1X, startY + offsetY);
                        offsetY += 12;

                        foreach (var rep in subGroup)
                        {
                            string itemText = rep.ProductName.Length > 35 ?
                                rep.ProductName.Substring(0, 32) + "..." :
                                rep.ProductName;

                            // Item name aligned left
                            g.DrawString($"{itemText}", smallFont, Brushes.Black, col1X, startY + offsetY);

                            // Quantity right aligned
                            string qtyStr = rep.Qty.ToString();
                            float qtyWidth = g.MeasureString(qtyStr, smallFont).Width;
                            g.DrawString(qtyStr, smallFont, Brushes.Black, col2X + 20 - qtyWidth, startY + offsetY);

                            // Amount right aligned
                            string amtStr = rep.TotalAmount.ToString();
                            float amtWidth = g.MeasureString(amtStr, smallFont).Width;
                            g.DrawString(amtStr, smallFont, Brushes.Black, col3X + 40 - amtWidth, startY + offsetY);

                            offsetY += 12;

                            // Add to running totals
                            subTotal += rep.TotalAmount;
                            subQty += rep.Qty;
                        }
                        offsetY += 5;
                    }
                }

                offsetY += 5;
                g.DrawLine(Pens.Black, startX, startY + offsetY, e.MarginBounds.Right, startY + offsetY);
                offsetY += 5;

                // Draw grand totals with right alignment
                g.DrawString("GRAND TOTAL:", headerFont, Brushes.Black, col1X, startY + offsetY);

                string totalQtyStr = subQty.ToString();
                float totalQtyWidth = g.MeasureString(totalQtyStr, headerFont).Width;
                g.DrawString(totalQtyStr, headerFont, Brushes.Black, col2X + 20 - totalQtyWidth, startY + offsetY);

                string totalAmtStr = subTotal.ToString("");
                float totalAmtWidth = g.MeasureString(totalAmtStr, headerFont).Width;
                g.DrawString(totalAmtStr, headerFont, Brushes.Black, col3X + 40 - totalAmtWidth, startY + offsetY);

                offsetY += 20;

                e.HasMorePages = false;
            };

            pd.Print();
        }

        private void PrintSummarizedReport(List<Report> lstReport)
        {
            string restaurantName = ConfigManager.Settings.RestaurantName;
            string dateTimeStr = DateTime.Now.ToString("dd-MM-yyyy : hh:mm");
            string headerText = "SUMMARIZED REPORT";

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 315, 600);
            pd.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);

            pd.PrintPage += (sender, e) =>
            {
                Graphics g = e.Graphics;
                int startX = e.MarginBounds.Left;
                int startY = e.MarginBounds.Top;
                int offsetY = 0;

                Font headerFont = new Font("Courier New", 11, FontStyle.Bold);
                Font regularFont = new Font("Courier New", 9, FontStyle.Regular);
                Font smallFont = new Font("Courier New", 8, FontStyle.Regular);

                void DrawCenteredString(string text, Font font, int yPos)
                {
                    SizeF textSize = g.MeasureString(text, font);
                    float xPos = startX + ((e.MarginBounds.Width - textSize.Width) / 2);
                    g.DrawString(text, font, Brushes.Black, xPos, yPos);
                }

                // Print Header
                DrawCenteredString(restaurantName.ToUpper(), headerFont, startY + offsetY);
                offsetY += 20;
                DrawCenteredString(headerText, headerFont, startY + offsetY);
                offsetY += 20;
                DrawCenteredString($"DATE: {dateTimeStr}", smallFont, startY + offsetY);
                offsetY += 15;

                g.DrawLine(Pens.Black, startX, startY + offsetY, e.MarginBounds.Right, startY + offsetY);
                offsetY += 5;

                // Define column widths
                int categoryWidth = 20;
                int qtyWidth = 6;
                int amtWidth = 12;

                // Header with fixed-width columns
                string headerFormat = "{0,-" + categoryWidth + "}{1," + qtyWidth + "}{2," + amtWidth + "}";
                g.DrawString(string.Format(headerFormat, "CATEGORY", "QTY", "AMT"),
                    regularFont, Brushes.Black, startX, startY + offsetY);
                offsetY += 15;

                g.DrawLine(Pens.Black, startX, startY + offsetY, e.MarginBounds.Right, startY + offsetY);
                offsetY += 5;

                int grandTotalQty = 0;
                decimal grandTotalAmount = 0;

                // Print categories with fixed-width columns
                foreach (var category in lstReport.GroupBy(r => r.CategoryName))
                {
                    int categoryQty = category.Sum(r => r.Qty);
                    decimal categoryAmt = category.Sum(r => r.TotalAmount);

                    string line = string.Format(headerFormat,
                        category.Key.Length > categoryWidth ? category.Key.Substring(0, categoryWidth - 3) + "..." : category.Key,
                        categoryQty,
                        categoryAmt.ToString());
                    g.DrawString(line, regularFont, Brushes.Black, startX, startY + offsetY);
                    offsetY += 15;

                    grandTotalQty += categoryQty;
                    grandTotalAmount += categoryAmt;
                }

                offsetY += 10;
                g.DrawLine(Pens.Black, startX, startY + offsetY, e.MarginBounds.Right, startY + offsetY);
                offsetY += 5;

                // Grand total with same format
                string totalFormat = "GRAND TOTAL:" + new string(' ', categoryWidth - 17) +
                                   string.Format("{0," + qtyWidth + "}{1," + amtWidth + "}",
                                   grandTotalQty, grandTotalAmount.ToString());
                g.DrawString(totalFormat, headerFont, Brushes.Black, startX, startY + offsetY);
                offsetY += 20;

                e.HasMorePages = false;
            };

            pd.Print();
        }





        private void btnPrintDailyReport_Click(object sender, EventArgs e)
        {
            List<Report> lstDailyReport = new List<Report>();

            var selectedCategory = ddlCategory.SelectedItem as Category;
            var selectedSubcategory = ddlSubCatogory.SelectedItem as Category;
            var selectedUOM = ddlUOMs.SelectedItem as Category;


            string selectedCategoryName = selectedCategory != null ? selectedCategory.CategoryName : null;
            string selectedSubcategoryName = selectedSubcategory != null ? selectedSubcategory.Subcategory : null;
            string selectedUOMName = selectedUOM != null ? selectedUOM.UOM : null;
           
            lstDailyReport = Report.GetSalesReport(selectedCategoryName, selectedSubcategoryName, selectedUOMName);

            PrintSummarizedReport(lstDailyReport);
        }

        private void btnPrintAnalysisReport_Click(object sender, EventArgs e)
        {
            List<Report> lstAnalysisReport = new List<Report>();

            var selectedCategory = ddlCategory.SelectedItem as Category;
            var selectedSubcategory = ddlSubCatogory.SelectedItem as Category;
            var selectedUOM = ddlUOMs.SelectedItem as Category;


            string selectedCategoryName = selectedCategory != null ? selectedCategory.CategoryName : null;
            string selectedSubcategoryName = selectedSubcategory != null ? selectedSubcategory.Subcategory : null;
            string selectedUOMName = selectedUOM != null ? selectedUOM.UOM : null;

            lstAnalysisReport = Report.GetSalesReport(selectedCategoryName, selectedSubcategoryName, selectedUOMName);

            PrintAnalysisReport(lstAnalysisReport);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDropdown();
        }
        private void ClearDropdown()
        {
            ddlCategory.SelectedIndex = -1;
            ddlSubCatogory.SelectedIndex = -1;
            ddlUOMs.SelectedIndex = -1;
        }
    }
}
