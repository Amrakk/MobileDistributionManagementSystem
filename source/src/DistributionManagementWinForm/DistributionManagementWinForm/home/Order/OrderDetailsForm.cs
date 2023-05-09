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

namespace DistributionManagementWinForm.home.Order
{
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm(int order_id, DateTime order_date, string reseller_name, string status_name, decimal total_price, string payment_method, string first_name, string last_name, string email, string phone, string address, string delivery_method)
        {
            InitializeComponent();
            this.Order_id = order_id;
            this.Order_date = order_date;
            this.Reseller_name = reseller_name;
            this.Status_name = status_name;
            this.Total_price = total_price;
            this.Payment_method = payment_method;
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.Delivery_method = delivery_method;
        }

        public int Order_id { get; set; }
        public DateTime Order_date { get; set; }
        public string Reseller_name { get; set; }
        public string Status_name { get; set; }
        public decimal Total_price { get; set; }
        public string Payment_method { get; set; }

        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Delivery_method { get; set; }
        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            label_orderId.Text = Order_id.ToString();
            label_orderDate.Text = Order_date.ToString();
            label_resellerName.Text = Reseller_name.ToString();
            label_statusName.Text = Status_name.ToString();
            label_paymentMethod.Text = Payment_method.ToString();
            label_totalPrice.Text = Total_price.ToString();

            label_firstName.Text = First_name.ToString();
            label_lastName.Text = Last_name.ToString();
            label_email.Text = Email.ToString();
            label_phoneNumber.Text = Phone.ToString();

            label_address.Text = Address.ToString();
            label_deliveryMethod.Text = Delivery_method.ToString();

            dataGridView_productList.DataSource = LoadProductList(Order_id);
            AdjustStudentGridView();


            dataGridView_productList.Columns[0].HeaderCell.Value = "Product Name";
            dataGridView_productList.Columns[1].HeaderCell.Value = "Quantity";
            dataGridView_productList.Columns[2].HeaderCell.Value = "Product Price";
            dataGridView_productList.Columns[3].HeaderCell.Value = "Sub Total";

            dataGridView_productList.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 154, 73);
            dataGridView_productList.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView_productList.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 154, 73);
            dataGridView_productList.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView_productList.EnableHeadersVisualStyles = false;
        }

        private void AdjustStudentGridView()
        {
            dataGridView_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public DataTable LoadProductList(int order_id)
        {
            return Connection.selectQuery("SELECT product_name, quantity, product_price, (quantity * product_price) as subTotal FROM Order_Item " +
                                          "LEFT JOIN Product ON Product.product_id = Order_Item.product_id " +
                                          "WHERE order_id = " + order_id);

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
            this.Hide();
        }
    }
}
