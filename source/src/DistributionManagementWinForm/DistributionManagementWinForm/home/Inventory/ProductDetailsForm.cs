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
using BUS;
using BUS.Inventory;
using DistributionManagementWinForm.home.Admin;

namespace DistributionManagementWinForm.home.Inventory
{
    public partial class ProductDetailsForm : Form
    {
        public ProductDetailsForm(int product_id, string product_name, string model, string product_description, int product_price, int product_quantity, bool status)
        {
            InitializeComponent();
            this.Product_id = product_id;
            this.Product_name = product_name;
            this.Model = model;
            this.Product_description = product_description;
            this.Product_price = product_price;
            this.Product_quantity = product_quantity;
            this.Status = status;
        }

        public int Product_id { get; set; }
        public string Product_name { get; set; }
        public string Model { get; set; }
        public string Product_description { get; set; }
        public int Product_price { get; set; }
        public int Product_quantity { get; set; }
        public bool Status { get; set; }


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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Status == false)
            {
                string product_name = textBox_productName.Text;
                string model = textBox_model.Text;
                int product_price = int.Parse(textBox_productPrice.Text);
                int product_quantity = int.Parse(textBox_productQuantity.Text);
                string product_description = richTextBox_productDescription.Text;

                BUS_Product productController = new BUS_Product(0, product_name, model, product_description, product_price, product_quantity);
                productController.addProduct();

                this.Hide();
                List<Form> form = Application.OpenForms.Cast<Form>().ToList();
                Home forms;

                foreach (Form formItem in form)
                {
                    if (formItem.Name == "Home")
                    {
                        forms = (Home)formItem;
                        forms.productBtn_Click(sender, e);
                        break;
                    }
                }
            }
            else
            {
                string product_name = textBox_productName.Text;
                string model = textBox_model.Text;
                int product_price = int.Parse(textBox_productPrice.Text);
                int product_quantity = int.Parse(textBox_productQuantity.Text);
                string product_description = richTextBox_productDescription.Text;

                BUS_Product productController = new BUS_Product(Product_id, product_name, model, product_description, product_price, product_quantity);
                productController.updateProduct();

                this.Hide();
                List<Form> form = Application.OpenForms.Cast<Form>().ToList();
                Home forms;

                foreach (Form formItem in form)
                {
                    if (formItem.Name == "Home")
                    {
                        forms = (Home)formItem;
                        forms.productBtn_Click(sender, e);
                        break;
                    }
                }

            }
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            textBox_productName.Text = Product_name;
            textBox_model.Text = Model;
            textBox_productPrice.Text = Product_price.ToString();
            textBox_productQuantity.Text = Product_quantity.ToString();
            richTextBox_productDescription.Text = Product_description.ToString();

            if (Status == true)
            {
                label_status.Text = "Editing...";
            }
            else
            {
                textBox_productPrice.Text = "";
                textBox_productQuantity.Text = "";
            }
        }
    }
}
