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

namespace DistributionManagementWinForm.home.Inventory
{
    public partial class ProductListForm : Form
    {
        DataTable dt;
        int Product_id;
        string Product_name;
        string Model;
        string Product_description;
        int Product_price;
        int Product_quantity;
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            BUS_Product BProduct = new BUS_Product(0, "", "", "", 0, 0);

            productGridView.DataSource = BProduct.selectProducts();
            productGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            productGridView.Columns[0].HeaderCell.Value = "Product ID";
            productGridView.Columns[1].HeaderCell.Value = "Product Name";
            productGridView.Columns[2].HeaderCell.Value = "Model";
            productGridView.Columns[3].HeaderCell.Value = "Product Description";
            productGridView.Columns[4].HeaderCell.Value = "Product Price";
            productGridView.Columns[5].HeaderCell.Value = "Product Quantity";

            productGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 154, 73);
            productGridView.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            productGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 154, 73);
            productGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            productGridView.EnableHeadersVisualStyles = false;
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            BUS_Product BProduct = new BUS_Product(0, "", "", "", 0, 0);
            dt = BProduct.selectProducts();
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("product_name like '%{0}%'", textBox_search.Text);
            productGridView.DataSource = dv.ToTable();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProductDetailsForm productDetailsForm = new ProductDetailsForm(0, "", "", "", 0, 0, false);
            productDetailsForm.ShowDialog();
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Product_id = int.Parse(productGridView.Rows[e.RowIndex].Cells["product_id"].FormattedValue.ToString());
            Product_name = productGridView.Rows[e.RowIndex].Cells["product_name"].FormattedValue.ToString();
            Model = productGridView.Rows[e.RowIndex].Cells["model"].FormattedValue.ToString();
            Product_description = productGridView.Rows[e.RowIndex].Cells["product_description"].FormattedValue.ToString();
            Product_price = int.Parse(productGridView.Rows[e.RowIndex].Cells["product_price"].FormattedValue.ToString());
            Product_quantity = int.Parse(productGridView.Rows[e.RowIndex].Cells["product_quantity"].FormattedValue.ToString());
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            ProductDetailsForm productDetailsForm = new ProductDetailsForm(Product_id, Product_name, Model, Product_description, Product_price, Product_quantity, true);
            productDetailsForm.ShowDialog();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string product_id = getSelectedId();
            BUS_Product BProduct = new BUS_Product(Product_id, "", "", "", 0, 0);

            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (product_id != "-1")
                {
                    BProduct.deleteProduct();
                    this.ProductListForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Please select an account to delete.");
                }
            }
        }

        private string getSelectedId()
        {
            if (productGridView.SelectedRows.Count > 0)
            {
                string id = productGridView.SelectedRows[0].Cells[0].Value.ToString();
                return id;
            }
            else
            {
                return "-1";
            }
        }
    }
}
