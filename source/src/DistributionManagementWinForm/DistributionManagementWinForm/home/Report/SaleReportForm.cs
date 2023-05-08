using BUS.Inventory;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistributionManagementWinForm.home.Report
{
    public partial class SaleReportForm : Form
    {
        DataTable dt;
        public SaleReportForm()
        {
            InitializeComponent();
            dt = GetData();
        }

        private void SaleReportForm_Load(object sender, EventArgs e)
        {
            dataGridView_saleReport.DataSource = dt;

            dataGridView_saleReport.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 154, 73);
            dataGridView_saleReport.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView_saleReport.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 154, 73);
            dataGridView_saleReport.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_saleReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_saleReport.EnableHeadersVisualStyles = false;
        }

        private DataTable GetData()
        {
            BUS_Product BProduct = new BUS_Product(0, "", "", "", 0, 0);
            DataTable products = BProduct.selectProducts();

            DataTable data = new DataTable();
            data.Columns.Add("Product ID");
            data.Columns.Add("Product Name");
            data.Columns.Add("AVG Cost");
            data.Columns.Add("Total Sold");
            data.Columns.Add("Price per item");
            data.Columns.Add("Total Revenue");
            data.Columns.Add("Total Profit");

            foreach (DataRow row in products.Rows)
            {
                int id = Convert.ToInt32(row["product_id"]);

                // Get avg cost
                DataTable receivedItemTable = Connection.selectQuery("SELECT AVG(cost_per_unit) FROM Received_Item WHERE product_id = " + id);

                float avgCost = 0;
                object avgCostValue = receivedItemTable?.Rows[0][0];

                if (avgCostValue != null && avgCostValue != DBNull.Value)
                    if (float.TryParse(avgCostValue.ToString(), out float result))
                        avgCost = result;


                // Get total sold
                DataTable orderItemTable = Connection.selectQuery("SELECT SUM(quantity) FROM Order_Item WHERE product_id = " + id);

                int totalSold = 0;
                string totalSoldValue = orderItemTable?.Rows[0][0]?.ToString();

                if (!string.IsNullOrEmpty(totalSoldValue) && totalSoldValue != DBNull.Value.ToString())
                    totalSold = Convert.ToInt32(totalSoldValue);

                int totalRevenue = Convert.ToInt32(row["product_price"]) * totalSold;
                float totalProfit = (float)totalRevenue - (avgCost * totalSold);

                data.Rows.Add(row["product_id"],
                              row["product_name"],
                              avgCost,
                              totalSold, 
                              row["product_price"],
                              totalRevenue,
                              totalProfit);
            }

            return data;
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            dt = GetData();
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("[Product Name] like '%{0}%'", textBox_search.Text.Trim());
            dataGridView_saleReport.DataSource = dv.ToTable();
        }

    }
}
