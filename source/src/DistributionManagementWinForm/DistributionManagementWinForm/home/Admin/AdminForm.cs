using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS.User;
using BUS.Inventory;

namespace DistributionManagementWinForm.home.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            BUS_Account BAccount = new BUS_Account(0, "", "", 0, DateTime.Now);
            BUS_Profile BProfile = new BUS_Profile(0, "", "", "", "", 0);
            BUS_Product BProduct = new BUS_Product(0, "", "", "", 0, 0);

            accountGridView.DataSource = BProfile.selectQuery("SELECT * FROM Profile");
            accountGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            productGridView.DataSource = BProduct.selectProducts("SELECT * FROM Product");
            productGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
