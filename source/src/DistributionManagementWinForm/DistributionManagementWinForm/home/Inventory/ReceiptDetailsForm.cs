using BUS.Inventory;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistributionManagementWinForm.home.Inventory
{
    public partial class ReceiptDetailsForm : Form
    {
        public ReceiptDetailsForm()
        {
            InitializeComponent();
        }

        bool isLoad = true;
        private void ReceiptDetailsForm_Load(object sender, EventArgs e)
        {
            BUS_ReceivedItem BReceivedItem = new BUS_ReceivedItem(0, 0, 0, 0);
            dataGridView_receivedItemList.ReadOnly = false;

            dataGridView_receivedItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox_productName.DataSource = Connection.listProductName();
            isLoad = false;
        }

        private void comboBox_productName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!isLoad && comboBox_productName.Text != "None")
            {
                dataGridView_receivedItemList.Rows.Add(comboBox_productName.Text, "", "", "");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_receivedItemList_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int quantity = Convert.ToInt32(dataGridView_receivedItemList.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value);
                int cost = Convert.ToInt32(dataGridView_receivedItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int total_cost = quantity * cost;
                dataGridView_receivedItemList.Rows[e.RowIndex].Cells[3].Value = total_cost;

                int total = 0;
                foreach (DataGridViewRow row in dataGridView_receivedItemList.Rows)
                {
                    // Check if the cell value is numeric and add it to the sum
                    if (row.Cells[3].Value != null && int.TryParse(row.Cells[3].Value.ToString(), out int value))
                    {
                        total += value;
                    }
                }
                textBox_totalCost.Text = total.ToString();
            }
            else if (e.ColumnIndex == 1)
            {
                int sum = 0;
                int quantity = Convert.ToInt32(dataGridView_receivedItemList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                foreach (DataGridViewRow row in dataGridView_receivedItemList.Rows)
                {
                    // Check if the cell value is numeric and add it to the sum
                    if (row.Cells[1].Value != null && int.TryParse(row.Cells[1].Value.ToString(), out int value))
                    {
                        sum += value;
                    }
                }
                textBox_quantity.Text = sum.ToString();
            }
        }

        public int Product_id(string product_name)
        {
            DataTable result = Connection.selectQuery("SELECT product_id FROM Product WHERE product_name = '" + product_name + "'");

            if (result != null && result.Rows.Count > 0)
                return int.Parse(result.Rows[0][0].ToString());
            return 0;
        }


        public int Received_id()
        {
            return int.Parse(Connection.selectQuery("select max(received_id) from Goods_Received_Note").Rows[0][0].ToString());
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            string received_date = dateTimePicker_receivedDate.Value.ToString("yyyy/MM/dd");
            string received_from = textBox_receivedFrom.Text;
            int quantity = int.Parse(textBox_quantity.Text);
            int total_cost = int.Parse(textBox_totalCost.Text);

            DateTime received_date_value = DateTime.ParseExact(received_date, "yyyy/MM/dd", null);

            BUS_GoodsReceivedNote BGoodsReceivedNote = new BUS_GoodsReceivedNote(0, received_date_value, received_from, quantity, total_cost);
            BGoodsReceivedNote.AddGRN();

            int rowCount = dataGridView_receivedItemList.Rows.Count;
            for (int i = 0; i < rowCount - 1; i++)
            {
                DataGridViewRow row = dataGridView_receivedItemList.Rows[i];
                string product_name = row.Cells[0].Value.ToString();
                int quantities = int.Parse(row.Cells[1].Value.ToString());
                int cost = int.Parse(row.Cells[2].Value.ToString());
                int product_id = Product_id(product_name);

                BUS_ReceivedItem BReceivedItem = new BUS_ReceivedItem(Received_id(), product_id, quantities, cost);
                BReceivedItem.AddReceivedItem();
                
                BUS_Product BProduct = new BUS_Product(0, "", "", "", 0, 0);
                DataTable product = BProduct.selectProductByName(product_name);
                BProduct = new BUS_Product(
                    int.Parse(product.Rows[0][0].ToString()),
                    product_name,
                    product.Rows[0][2].ToString(),
                    product.Rows[0][3].ToString(),
                    int.Parse(product.Rows[0][4].ToString()),
                    quantities + int.Parse(product.Rows[0][5].ToString())
                );
                BProduct.updateProduct();
            }

            List<Form> form = Application.OpenForms.Cast<Form>().ToList();
            Home forms;

            foreach (Form formItem in form)
            {
                if (formItem.Name == "Home")
                {
                    forms = (Home)formItem;
                    forms.receiptsBtn_Click(sender, e);
                    break;
                }
            }
            this.Close();
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
    }
}

