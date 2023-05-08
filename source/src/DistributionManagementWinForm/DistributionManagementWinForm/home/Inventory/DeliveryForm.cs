using BUS.Inventory;
using BUS.Order;
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

namespace DistributionManagementWinForm.home.Inventory
{
    public partial class DeliveryForm : Form
    {
        DataTable dt;
        public DeliveryForm()
        {
            InitializeComponent();
            dt = GetData();
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            dataGridView_deliveryList.DataSource = dt;

            dataGridView_deliveryList.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 154, 73);
            dataGridView_deliveryList.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView_deliveryList.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 154, 73);
            dataGridView_deliveryList.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView_deliveryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_deliveryList.EnableHeadersVisualStyles = false;
        }

        private DataTable GetData()
        {
            BUS_DeliveryNote BDelivery = new BUS_DeliveryNote(0, DateTime.Now, "");
            DataTable deliverys = BDelivery.SelectDeliveryNotes();

            DataTable data = new DataTable();
            data.Columns.Add("Delivery ID");
            data.Columns.Add("Delivery Date");
            data.Columns.Add("Reseller ID");
            data.Columns.Add("Total Quantity");
            data.Columns.Add("Delivery Method");

            foreach (DataRow row in deliverys.Rows)
            {
                int id = Convert.ToInt32(row["delivery_id"]);
                
                // Get reseller id
                BUS_OrderNote BOrderNote = new BUS_OrderNote(0, DateTime.Now, 0, 0, 0, "");
                DataTable orderNoteTable = BOrderNote.SearchOrderNoteById(id);

                int resellerId = Convert.ToInt32(orderNoteTable.Rows[0][2].ToString());

                // Get total quantity
                DataTable orderItemTable = Connection.selectQuery("SELECT SUM(quantity) FROM Order_Item WHERE order_id = " + id);

                int totalQuantity = 0;
                string totalQuantityValue = orderItemTable?.Rows[0][0]?.ToString();

                if (!string.IsNullOrEmpty(totalQuantityValue) && totalQuantityValue != DBNull.Value.ToString())
                    totalQuantity = Convert.ToInt32(totalQuantityValue);

                data.Rows.Add(row["delivery_id"],
                              row["delivery_date"],
                              resellerId,
                              totalQuantity,
                              row["delivery_method"]);

            }

            return data;
        }

        private void dataGridView_deliveryList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView_deliveryList.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Value);

            DeliveryDetailsForm DDF = new DeliveryDetailsForm(id);
            DDF.Show();
        }
    }
}
