using BUS.Inventory;
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
    public partial class ReceiptForm : Form
    {
        DataTable dt;
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void panelAccount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {

            BUS_GoodsReceivedNote BGoodsReceivedNote = new BUS_GoodsReceivedNote(0, DateTime.Now, "", 0, 0);
            receiptGridView.DataSource = BGoodsReceivedNote.SelectGRNs();
            receiptGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            receiptGridView.Columns[0].HeaderCell.Value = "Received ID";
            receiptGridView.Columns[1].HeaderCell.Value = "Received Date";
            receiptGridView.Columns[2].HeaderCell.Value = "Received From";
            receiptGridView.Columns[3].HeaderCell.Value = "Quantity";
            receiptGridView.Columns[4].HeaderCell.Value = "Total Cost";


            receiptGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 154, 73);
            receiptGridView.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            receiptGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 154, 73);
            receiptGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            receiptGridView.EnableHeadersVisualStyles = false;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            ReceiptDetailsForm receiptDetailsForm = new ReceiptDetailsForm();
            receiptDetailsForm.ShowDialog();
        }
    }
}
