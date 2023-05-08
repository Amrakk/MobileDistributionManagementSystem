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
    public partial class StockReportForm : Form
    {
        DataTable dt;
        public StockReportForm()
        {
            InitializeComponent();
            dt = GetData();
        }

        private void StockReportForm_Load(object sender, EventArgs e)
        {
            dataGridView_stockReport.DataSource = dt;

            dataGridView_stockReport.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 154, 73);
            dataGridView_stockReport.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView_stockReport.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 154, 73);
            dataGridView_stockReport.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_stockReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_stockReport.EnableHeadersVisualStyles = false;
        }


        private DataTable GetData()
        {
            BUS_Product BProduct = new BUS_Product(0, "", "", "", 0, 0);
            DataTable products = BProduct.selectProducts();

            DataTable data = new DataTable();
            data.Columns.Add("Product ID");
            data.Columns.Add("Product Name");
            data.Columns.Add("Stock On Hand");
            data.Columns.Add("Quantity In");
            data.Columns.Add("Quantity Out");

            int totalOnHand = 0;
            int totalIn = 0;
            int totalOut = 0;

            foreach (DataRow row in products.Rows)
            {
                int id = Convert.ToInt32(row["product_id"]);

                DataTable receivedItemTable = Connection.selectQuery("SELECT SUM(quantity) FROM Received_Item WHERE product_id = " + id);

                int quantityIn = 0;
                string quantityInValue = receivedItemTable?.Rows[0][0]?.ToString();

                if (!string.IsNullOrEmpty(quantityInValue) && quantityInValue != DBNull.Value.ToString())
                    quantityIn = Convert.ToInt32(quantityInValue);


                DataTable orderItemTable = Connection.selectQuery("SELECT SUM(quantity) FROM Order_Item WHERE product_id = " + id);

                int quantityOut = 0;
                string quantityOutValue = orderItemTable?.Rows[0][0]?.ToString();

                if (!string.IsNullOrEmpty(quantityOutValue) && quantityOutValue != DBNull.Value.ToString())
                    quantityOut = Convert.ToInt32(quantityOutValue);


                data.Rows.Add(row["product_id"], 
                              row["product_name"], 
                              row["product_quantity"],
                              quantityIn,
                              quantityOut);
                              
                totalOnHand += Convert.ToInt32(row["product_quantity"]);
                totalIn += quantityIn;
                totalOut += quantityOut;
            }

            DataRow totalRow = data.NewRow();
            totalRow[0] = "";
            totalRow[1] = "Total";
            totalRow[2] = totalOnHand;
            totalRow[3] = totalIn;
            totalRow[4] = totalOut;

            data.Rows.InsertAt(totalRow, 0);

            return data;
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            dt = GetData();
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("[Product Name] like '%{0}%'", textBox_search.Text.Trim());
            dataGridView_stockReport.DataSource = dv.ToTable();
        }
    }
}
