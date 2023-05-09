using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using DAL;
namespace DistributionManagementWinForm.home.Order
{
    public partial class OrderListForm : Form
    {
        DataTable dt;

        public OrderListForm()
        {
            InitializeComponent();
        }


        private void OrderListForm_Load(object sender, EventArgs e)
        {

            label_allOrder_Click_1(sender, e);

            dataGridView_orderList.DataSource = Connection.selectQuery("SELECT order_id, order_date, reseller_name, status_name, total_price FROM Order_Note LEFT JOIN Reseller on Reseller.reseller_id = Order_Note.reseller_id LEFT JOIN Status on Status.status_id = Order_Note.status_id");

            dataGridView_orderList.Columns[0].HeaderCell.Value = "Order ID";
            dataGridView_orderList.Columns[1].HeaderCell.Value = "Order Date";
            dataGridView_orderList.Columns[2].HeaderCell.Value = "Reseller Name";
            dataGridView_orderList.Columns[3].HeaderCell.Value = "Status";
            dataGridView_orderList.Columns[4].HeaderCell.Value = "Total Price";


            dataGridView_orderList.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 154, 73);
            dataGridView_orderList.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView_orderList.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 154, 73);
            dataGridView_orderList.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_orderList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_orderList.EnableHeadersVisualStyles = false;


            dataGridView_orderList.ClearSelection();
        }

        private void label_allOrder_Leave_1(object sender, EventArgs e)
        {
            label_allOrder.ForeColor = Color.Black;
            label_allOrder.Font = new Font(label_allOrder.Font, FontStyle.Regular);
        }

        private void label_pending_Leave_1(object sender, EventArgs e)
        {
            label_pending.ForeColor = Color.Black;
            label_pending.Font = new Font(label_pending.Font, FontStyle.Regular);
        }

        private void label_allOrder_Click_1(object sender, EventArgs e)
        {
            label_allOrder.ForeColor = Color.FromArgb(24, 154, 73);
            label_pending_Leave_1(sender, e);
            label_allOrder.Font = new Font(label_allOrder.Font, FontStyle.Underline | FontStyle.Bold);
            dataGridView_orderList.DataSource = Connection.selectQuery("SELECT order_id, order_date, reseller_name, status_name, total_price FROM Order_Note LEFT JOIN Reseller on Reseller.reseller_id = Order_Note.reseller_id LEFT JOIN Status on Status.status_id = Order_Note.status_id");
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                dt = Connection.selectQuery("SELECT order_id, order_date, reseller_name, status_name, total_price FROM Order_Note LEFT JOIN Reseller on Reseller.reseller_id = Order_Note.reseller_id LEFT JOIN Status on Status.status_id = Order_Note.status_id");
                DataView dv = dt.DefaultView;
                dv.RowFilter = String.Format("reseller_name like '%{0}%'", textBox_search.Text);
                dataGridView_orderList.DataSource = dv.ToTable();
        }

        private void label_pending_Click(object sender, EventArgs e)
        {
            label_allOrder_Leave_1(sender, e);
            label_pending.ForeColor = Color.FromArgb(24, 154, 73);
            label_pending.Font = new Font(label_pending.Font, FontStyle.Underline | FontStyle.Bold);
            dataGridView_orderList.DataSource = Connection.selectQuery("SELECT order_id, order_date, reseller_name, status_name, total_price FROM Order_Note LEFT JOIN Reseller on Reseller.reseller_id = Order_Note.reseller_id LEFT JOIN Status on Status.status_id = Order_Note.status_id WHERE Status.status_id != 7");

        }

        public string Payment_method(int order_id)
        {
            return Connection.selectQuery("SELECT payment_method FROM Order_Note WHERE order_id = '" + order_id + "'").Rows[0][0].ToString();
        }

        public int Reseller_id(string reseller_name)
        {
            return int.Parse(Connection.selectQuery("SELECT reseller_id FROM Reseller WHERE reseller_name = '" + reseller_name + "'").Rows[0][0].ToString());
        }

        public DataTable Profile(int reseller_id)
        {
            return Connection.selectQuery("SELECT first_name, last_name, email, phone FROM Profile JOIN Reseller ON profile_id = '" + reseller_id + "'");
        }

        public string Address(int reseller_id)
        {
            return Connection.selectQuery("SELECT address FROM Reseller WHERE reseller_id = '" + reseller_id + "'").Rows[0][0].ToString();
        }

        public string Delivery_method(int order_id)
        {
            return Connection.selectQuery("SELECT delivery_method FROM Delivery_Note WHERE delivery_id = '" + order_id + "'").Rows[0][0].ToString();
        }

        private void dataGridView_orderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int order_id = int.Parse(dataGridView_orderList.Rows[e.RowIndex].Cells["order_id"].FormattedValue.ToString());
            DateTime order_date = DateTime.Parse(dataGridView_orderList.Rows[e.RowIndex].Cells["order_date"].FormattedValue.ToString());
            string reseller_name = dataGridView_orderList.Rows[e.RowIndex].Cells["reseller_name"].FormattedValue.ToString();
            string status_name = dataGridView_orderList.Rows[e.RowIndex].Cells["status_name"].FormattedValue.ToString();
            decimal total_price = decimal.Parse(dataGridView_orderList.Rows[e.RowIndex].Cells["total_price"].FormattedValue.ToString());

            string first_name = Profile(Reseller_id(reseller_name)).Rows[0][0].ToString();
            string last_name = Profile(Reseller_id(reseller_name)).Rows[0][1].ToString();
            string email = Profile(Reseller_id(reseller_name)).Rows[0][2].ToString();
            string phone = Profile(Reseller_id(reseller_name)).Rows[0][3].ToString();

            string address = Address(Reseller_id(reseller_name));
            string delivery_method = Delivery_method(order_id);

            OrderDetailsForm orderDetailsForm = new OrderDetailsForm(order_id, order_date, reseller_name, status_name, total_price, Payment_method(order_id), first_name, last_name, email, phone, address, delivery_method);
            orderDetailsForm.ShowDialog();
        }
    }
}
