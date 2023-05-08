using BUS.User;
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
using BCryptNet = BCrypt.Net.BCrypt;
using DAL;
namespace DistributionManagementWinForm.auth
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        #region Styling

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            //AuthShared.textChangedStyling(userTextBox);
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passTextBox.Text == "" || passTextBox.Text == "Password")
                passTextBox.PasswordChar = '\0';
            else
                passTextBox.PasswordChar = '•';
            //AuthShared.textChangedStyling(passTextBox);

        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.DarkGreen;
            loginBtn.ForeColor = Color.White;
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.White;
            loginBtn.ForeColor = Color.DarkGreen;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        // Drag from title bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Function
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string user = userTextBox.Text;
            string pass = passTextBox.Text;

            BUS_Account BAccount = new BUS_Account(0, "", "", 0, DateTime.Now);
            DataTable data = Connection.selectQuery($"select * from Account where username = '{user}'");

            if (data.Rows.Count == 1)
            {
                if (pass == data.Rows[0].ItemArray[2].ToString())
                {
                    BUS_Profile BProfile = new BUS_Profile(0, "", "", "", "", 0);
                    DataTable profile = BProfile.SelectProfileById(Convert.ToInt32(data.Rows[0][0].ToString()));
                    string name = profile.Rows[0][1].ToString() + " " + profile.Rows[0][2].ToString();
                    bool isAdmin = (Convert.ToInt32(profile.Rows[0][5].ToString()) == 1);

                    Form home = new home.Home(name, isAdmin);
                    home.Show();

                    this.Enabled = false;
                    this.Hide();
                }
                else
                    MessageBox.Show("Wrong username or password!");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void userTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (userTextBox.Text == "Username")
            {
                userTextBox.Text = "";
            }
        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                userTextBox.Text = "Username";
            }
        }

        private void passTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (passTextBox.Text == "Password")
            {
                passTextBox.Text = "";
            }
        }

        private void passTextBox_Leave(object sender, EventArgs e)
        {
            if (passTextBox.Text == "")
            {
                passTextBox.Text = "Password";
            }
        }

        private void passTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
