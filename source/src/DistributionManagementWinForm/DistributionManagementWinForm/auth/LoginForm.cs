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
            AuthShared.textChangedStyling(userTextBox);
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(passTextBox);
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
            errorLabel.Visible = false;
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
            // TODO - Validate
            string user = userTextBox.Text;
            string pass = passTextBox.Text;

            // BUS_Account 
            
            Form home = new home.Home();
            home.Show();
            this.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form signup = new SignupForm();
            signup.Show();
            this.Hide();
        }

        #endregion
    }
}
