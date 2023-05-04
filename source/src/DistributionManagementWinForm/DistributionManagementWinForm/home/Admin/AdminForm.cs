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
            BUS_Profile BProfile = new BUS_Profile(0, "", "", "", "", 0);

            accountGridView.DataSource = BProfile.SelectProfiles();
            accountGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            int id = int.Parse(accountGridView.CurrentRow.Cells[0].Value.ToString());
            AccountDetailsForm accDetail = new AccountDetailsForm(id);
            accDetail.Show();
        }
    }
}
