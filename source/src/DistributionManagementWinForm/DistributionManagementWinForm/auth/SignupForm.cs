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
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }


        #region Styling
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

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            signupBtn.BackColor = Color.DarkGreen;
            signupBtn.ForeColor = Color.White;
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            signupBtn.BackColor = Color.White;
            signupBtn.ForeColor = Color.DarkGreen;
        }

        private void resellerInfo(bool status)
        {
            resellerAddPanel.Visible = status;
            resellerAddPanel.Enabled = status;
            resellerNamePanel.Visible = status;
            resellerNamePanel.Enabled = status;
        }

        private void resellerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            resellerInfo(resellerRadioButton.Checked);
        }



        #endregion

        #region Function
        private void SignupForm_Load(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Form login = null;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "LoginForm")
                {
                    login = openForm;
                    break;
                }
            }
            login.Show();

            this.Close();
        }

        private void loginBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            closeBtn_Click(sender, e);
        }




        #endregion

        #region Mixed
        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(userTextBox);
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(passTextBox);
        }

        private void confirmPassTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(confirmPassTextBox);
        }

        private void fNameTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(fNameTextBox);
        }

        private void lNameTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(lNameTextBox);
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(emailTextBox);
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(phoneTextBox);
        }

        private void resellerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(resellerNameTextBox);
        }

        private void resellerAddTextBox_TextChanged(object sender, EventArgs e)
        {
            AuthShared.textChangedStyling(resellerAddTextBox);
        }

        #endregion

        

       
    }
}
