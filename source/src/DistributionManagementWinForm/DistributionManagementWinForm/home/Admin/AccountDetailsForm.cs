using BUS.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Web.UI.WebControls;

namespace DistributionManagementWinForm.home.Admin
{
    public partial class AccountDetailsForm : Form
    {
        private BUS_Account BAccount;
        private BUS_Profile BProfile;
        private BUS_Reseller BReseller;
        public AccountDetailsForm(int id, string username, string password, string firstname, string lastname, string email, string phone, int role_id, string reseller_name, string reseller_address, bool status)
        {
            InitializeComponent();
            BAccount = new BUS_Account(id, "", "", 0, DateTime.Now);
            BProfile = new BUS_Profile(id, "", "", "", "", 0);

            BReseller = new BUS_Reseller(id, "", "");
            
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Phone = phone;
            this.Role_id = role_id;
            this.ResellerName = reseller_name;
            this.ResellerAddress = reseller_address;
            this.Status = status;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Role_id { get; set; }
        public string ResellerName { get; set; }
        public string ResellerAddress { get; set; }
        public bool Status { get; set; }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9]{3,20}@gmail.com(.vn|)$");
        }

        #region Style
        private void userTextBox_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (userTextBox.Text == "Username")
            {
                userTextBox.Text = "";
            }
        }

        private void userTextBox_Leave_1(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                userTextBox.Text = "Username";
            }
        }

        private void passTextBox_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (passTextBox.Text == "Password")
            {
                passTextBox.Text = "";
            }
        }

        private void passTextBox_Leave_1(object sender, EventArgs e)
        {
            if (passTextBox.Text == "")
            {
                passTextBox.Text = "Password";
            }
        }

        private void confirmPassTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (confirmPassTextBox.Text == "Confirm Password")
            {
                confirmPassTextBox.Text = "";
            }
        }

        private void confirmPassTextBox_Leave(object sender, EventArgs e)
        {
            if (confirmPassTextBox.Text == "")
            {
                confirmPassTextBox.Text = "Confirm Password";
            }
        }

        private void fNameTextBox_Leave(object sender, EventArgs e)
        {
            if (fNameTextBox.Text == "")
            {
                fNameTextBox.Text = "First Name";
            }
        }

        private void lNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (lNameTextBox.Text == "Last Name")
            {
                lNameTextBox.Text = "";
            }
        }

        private void lNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lNameTextBox.Text == "")
            {
                lNameTextBox.Text = "Last Name";
            }
        }

        private void emailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (emailTextBox.Text == "Email")
            {
                emailTextBox.Text = "";
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Email";
            }
        }

        private void phoneTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (phoneTextBox.Text == "Phone Number")
            {
                phoneTextBox.Text = "";
            }
        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            if (phoneTextBox.Text == "")
            {
                phoneTextBox.Text = "Phone Number";
            }
        }

        private void resellerNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (resellerNameTextBox.Text == "Reseller Name")
            {
                resellerNameTextBox.Text = "";
            }
        }

        private void resellerNameTextBox_Leave(object sender, EventArgs e)
        {
            if (resellerNameTextBox.Text == "")
            {
                resellerNameTextBox.Text = "Reseller Name";
            }
        }

        private void resellerAddTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (resellerAddTextBox.Text == "Reseller Address")
            {
                resellerAddTextBox.Text = "";
            }
        }

        private void resellerAddTextBox_Leave(object sender, EventArgs e)
        {
            if (resellerAddTextBox.Text == "")
            {
                resellerAddTextBox.Text = "Reseller Address";
            }
        }

        private void resellerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            resellerNamePanel.Visible = true;
            resellerAddPanel.Visible = true;
        }

        private void accountantRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            resellerNamePanel.Visible = false;
            resellerAddPanel.Visible = false;
        }
        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passTextBox.Text == "" || passTextBox.Text == "Password")
                passTextBox.PasswordChar = '\0';
            else
                passTextBox.PasswordChar = '•';
        }

        private void confirmPassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (confirmPassTextBox.Text == "" || confirmPassTextBox.Text == "Confirm Password")
                confirmPassTextBox.PasswordChar = '\0';
            else
                confirmPassTextBox.PasswordChar = '•';
        }

        private void fNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (fNameTextBox.Text == "First Name")
            {
                fNameTextBox.Text = "";
            }
        }

        #endregion

        private int Account_id()
        {
            return int.Parse(Connection.selectQuery("SELECT max(profile_id) FROM Profile").Rows[0][0].ToString());
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            int role_id;
            string username = userTextBox.Text;
            string password = passTextBox.Text;
            string confirmPassword = confirmPassTextBox.Text;
            string firstname = fNameTextBox.Text;
            string lastname = lNameTextBox.Text;
            string email = emailTextBox.Text;
            string phone = phoneTextBox.Text;
            string resellername = resellerNameTextBox.Text;
            string reselleraddress = resellerAddTextBox.Text;

            List<Form> form = Application.OpenForms.Cast<Form>().ToList();
            Home forms;

            // Creating
            if (Status == false)
            {
                // Check validation of Email
                if (checkEmail(email))
                {
                    // Check if Email has existed
                    if (BProfile.SelectAlreadyExistEmail(email) == false)
                    {
                        // Check input password == confirm password
                        if (password == confirmPassword)
                        {
                            // Check if Username has existed
                            if (BAccount.SelectAlreadyExistUsername(username) == false)
                            {
                                // Check if it is a Reseller
                                if (resellerRadioButton.Checked)
                                {
                                    role_id = 3;
                                    BUS_Profile BProfile = new BUS_Profile(0, firstname, lastname, email, phone, role_id);
                                    BProfile.AddProfile();

                                    BUS_Account BAccount = new BUS_Account(Account_id(), username, password, 0, DateTime.Now);
                                    BAccount.AddAccount();

                                    BUS_Reseller BReseller = new BUS_Reseller(Account_id(), resellername, reselleraddress);
                                    BReseller.AddReseller();
                                    this.Hide();
                                    foreach (Form formItem in form)
                                    {
                                        if (formItem.Name == "Home")
                                        {
                                            forms = (Home)formItem;
                                            forms.adminBtn_Click(sender, e);
                                            break;
                                        }
                                    }

                                }
                                // Check if it is an Accountant
                                else if (accountantRadioButton.Checked)
                                {
                                    role_id = 2;
                                    BUS_Profile BProfile = new BUS_Profile(0, firstname, lastname, email, phone, role_id);
                                    BProfile.AddProfile();

                                    BUS_Account BAccount = new BUS_Account(Account_id(), username, password, 0, DateTime.Now);
                                    BAccount.AddAccount();


                                    this.Hide();
                                    foreach (Form formItem in form)
                                    {
                                        if (formItem.Name == "Home")
                                        {
                                            forms = (Home)formItem;
                                            forms.adminBtn_Click(sender, e);
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please select role");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username already exists");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password & Confirm Password do not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email already exists");
                    }
                }
                else
                {
                    MessageBox.Show("Email is invalid");
                }
            }
            // Editing
            else
            {
                BProfile = new BUS_Profile(Id, "", "", "", "", 0);
                BReseller = new BUS_Reseller(Id, "", "");

                // Check validation of Email
                if (checkEmail(email))
                {
                    // Check if input Email == Email before changed
                    if (email == Email)
                    {
                        // Check if it is a Reseller
                        if (resellerRadioButton.Checked)
                        {
                            role_id = 3;
                            BUS_Profile BProfile = new BUS_Profile(Id, firstname, lastname, email, phone, role_id);
                            BProfile.UpdateProfile();

                            this.Hide();
                            foreach (Form formItem in form)
                            {
                                if (formItem.Name == "Home")
                                {
                                    forms = (Home)formItem;
                                    forms.adminBtn_Click(sender, e);
                                    break;
                                }
                            }
                        }
                        // Check if it is an Accountant
                        else if (accountantRadioButton.Checked)
                        {
                            role_id = 2;
                            BUS_Profile BProfile = new BUS_Profile(Id, firstname, lastname, email, phone, role_id);
                            BProfile.UpdateProfile();
                            this.Hide();
                            foreach (Form formItem in form)
                            {
                                if (formItem.Name == "Home")
                                {
                                    forms = (Home)formItem;
                                    forms.adminBtn_Click(sender, e);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select role");
                        }
                    }
                    // Check if Email has existed
                    else if (BProfile.SelectAlreadyExistEmail(email) == false)
                    {
                        // Check if it is a Reseller
                        if (resellerRadioButton.Checked)
                        {
                            role_id = 2;
                            BUS_Profile BProfile = new BUS_Profile(Id, firstname, lastname, email, phone, role_id);
                            BProfile.UpdateProfile();

                            this.Hide();
                            foreach (Form formItem in form)
                            {
                                if (formItem.Name == "Home")
                                {
                                    forms = (Home)formItem;
                                    forms.adminBtn_Click(sender, e);
                                    break;
                                }
                            }
                        }
                        // Check if it is an Accountant
                        else if (accountantRadioButton.Checked)
                        {
                            role_id = 2;
                            BUS_Profile BProfile = new BUS_Profile(Id, firstname, lastname, email, phone, role_id);
                            BProfile.UpdateProfile();


                            this.Hide();
                            foreach (Form formItem in form)
                            {
                                if (formItem.Name == "Home")
                                {
                                    forms = (Home)formItem;
                                    forms.adminBtn_Click(sender, e);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select role");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email already exists");
                    }
                }
                else
                {
                    MessageBox.Show("Email is invalid");
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void AccountDetailsForm_Load(object sender, EventArgs e)
        {
            userTextBox.Text = Username;
            passTextBox.Text = Password;
            fNameTextBox.Text = Firstname;
            lNameTextBox.Text = Lastname;
            emailTextBox.Text = Email;
            phoneTextBox.Text = Phone;
            confirmPassTextBox.Text = Password;

            if (Role_id == 3)
            {
                resellerRadioButton.Checked = true;
            }
            else if (Role_id == 2)
            {
                accountantRadioButton.Checked = true;
            }
            resellerNameTextBox.Text = ResellerName;
            resellerAddTextBox.Text = ResellerAddress;

            if (Status == true)
            {
                label_status.Text = "Editing...";
                userTextBox.ReadOnly = true;
                passTextBox.ReadOnly = true;
                confirmPassTextBox.ReadOnly = true;
                resellerRadioButton.Enabled = false;
                accountantRadioButton.Enabled = false;
                resellerNameTextBox.Enabled = false;
                resellerAddTextBox.Enabled = false;
            }

            resellerNamePanel.Visible = false;
            resellerAddPanel.Visible = false;

            resellerAddTextBox_Leave(sender, e);
            resellerNameTextBox_Leave(sender, e);
            phoneTextBox_Leave(sender, e);
            emailTextBox_Leave(sender, e);
            lNameTextBox_Leave(sender, e);
            fNameTextBox_Leave(sender, e);
            confirmPassTextBox_Leave(sender, e);
            passTextBox_Leave_1(sender, e);
            userTextBox_Leave_1(sender, e);

            if (resellerRadioButton.Checked)
            {
                resellerNamePanel.Visible = true;
                resellerAddPanel.Visible = true;
            }
        }
    }
}
