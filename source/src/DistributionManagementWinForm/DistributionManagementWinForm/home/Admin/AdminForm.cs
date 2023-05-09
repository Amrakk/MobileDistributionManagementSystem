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
using DAL;

namespace DistributionManagementWinForm.home.Admin
{
    public partial class AdminForm : Form
    {
        DataTable dt;


        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            BUS_Account BAccount = new BUS_Account(0, "", "", 0, DateTime.Now);
            accountGridView.DataSource = BAccount.SelectAccounts();
            accountGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            accountGridView.Columns[0].HeaderCell.Value = "Account ID";
            accountGridView.Columns[1].HeaderCell.Value = "Username";
            accountGridView.Columns[2].HeaderCell.Value = "Password";
            accountGridView.Columns[3].HeaderCell.Value = "Activated";
            accountGridView.Columns[4].HeaderCell.Value = "Created Date";

            accountGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 154, 73);
            accountGridView.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            accountGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 154, 73);
            accountGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            accountGridView.EnableHeadersVisualStyles = false;
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            BUS_Account BAccount = new BUS_Account(0, "", "", 0, DateTime.Now);
            dt = BAccount.SelectAccounts();
            DataView dv = dt.DefaultView;
            dv.RowFilter = String.Format("username like '%{0}%'", textBox_search.Text);
            accountGridView.DataSource = dv.ToTable();
        }

        private void button_create_Click(object sender, EventArgs e)
        {

            AccountDetailsForm accountDetailsForm = new AccountDetailsForm(0, "", "", "", "", "", "", 0, "", "", false);
            accountDetailsForm.Show();
        }


        int Id;
        string Username;
        string Password;
        string Firstname;
        string Lastname;
        string Email;
        string Phone;
        int Role_id;
        string Resellername;
        string Reselleraddress;

        public DataTable Profile(int account_id)
        {
            return Connection.selectQuery("SELECT first_name, last_name, email, phone, role_id FROM Profile WHERE profile_id = '" + account_id + "'");
        }

        public DataTable Reseller(int account_id)
        {
            return Connection.selectQuery("SELECT reseller_name, address FROM Reseller WHERE reseller_id = '" + account_id + "'");
        }

        private void accountGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = int.Parse(accountGridView.Rows[e.RowIndex].Cells["account_id"].FormattedValue.ToString());
            Username = accountGridView.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
            Password = accountGridView.Rows[e.RowIndex].Cells["password"].FormattedValue.ToString();
            Firstname = Profile(Id).Rows[0][0].ToString();
            Lastname = Profile(Id).Rows[0][1].ToString();
            Email = Profile(Id).Rows[0][2].ToString();
            Phone = Profile(Id).Rows[0][3].ToString();
            Role_id = int.Parse(Profile(Id).Rows[0][4].ToString());

            if (Role_id == 3)
            {
                Resellername = Reseller(Id).Rows[0][0].ToString();
                Reselleraddress = Reseller(Id).Rows[0][1].ToString();
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            AccountDetailsForm accountDetailsForm = new AccountDetailsForm(Id, Username, Password, Firstname, Lastname, Email, Phone, Role_id, Resellername, Reselleraddress, true);
            accountDetailsForm.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string account_id = getSelectedId();
            BUS_Reseller BReseller = new BUS_Reseller(Id, "", "");
            BUS_Profile BProfile = new BUS_Profile(Id, "", "", "", "", 0);
            BUS_Account BAccount = new BUS_Account(Id, "", "", 0, DateTime.Now);
            DialogResult result = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (account_id != "-1")
                {
                    if (Role_id == 3)
                    {
                        int id = int.Parse(account_id);
                        BReseller.DeleteReseller(id);
                        BAccount.DeleteAccount(id);
                        BProfile.DeleteProfile(id);
                    }
                    else if (Role_id == 2)
                    {
                        int id = int.Parse(account_id);
                        BAccount.DeleteAccount(id);
                        BProfile.DeleteProfile(id);
                    }

                    this.AdminForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Please select an account to delete.");
                }
            }
        }

        private string getSelectedId()
        {
            if (accountGridView.SelectedRows.Count > 0)
            {
                string id = accountGridView.SelectedRows[0].Cells[0].Value.ToString();
                return id;
            }
            else
            {
                return "-1";
            }
        }
    }
}
