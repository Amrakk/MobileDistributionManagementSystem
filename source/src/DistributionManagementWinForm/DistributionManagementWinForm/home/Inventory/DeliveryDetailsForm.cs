using BUS.Inventory;
using BUS.Order;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistributionManagementWinForm.home.Inventory
{
    public partial class DeliveryDetailsForm : Form
    {
        DataTable dt;
        public DeliveryDetailsForm(int id)
        {
            InitializeComponent();
            dt = GetData(id);
        }


        private void DeliveryDetailsForm_Load(object sender, EventArgs e)
        {

            // Load delivery item
            dataGridView_deliveriedItems.DataSource = dt;

            dataGridView_deliveriedItems.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 154, 73);
            dataGridView_deliveriedItems.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView_deliveriedItems.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 154, 73);
            dataGridView_deliveriedItems.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_deliveriedItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_deliveriedItems.EnableHeadersVisualStyles = false;
        }

        private DataTable GetData(int id)
        {
            DataTable items = Connection.selectQuery("SELECT * FROM Order_Item WHERE order_id = " + id);

            DataTable data = new DataTable();
            data.Columns.Add("Product ID");
            data.Columns.Add("Product Name");
            data.Columns.Add("Quantity");

            foreach (DataRow row in items.Rows)
            {
                int product_id = Convert.ToInt32(row["product_id"]);
                string name = Connection.selectQuery("SELECT product_name FROM Product " +
                                                     "WHERE product_id = '" + product_id + "'")
                                                     .Rows[0][0].ToString();

                data.Rows.Add(row["product_id"],
                              name,
                              row["quantity"]);
            }

            return data;
        }







        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
