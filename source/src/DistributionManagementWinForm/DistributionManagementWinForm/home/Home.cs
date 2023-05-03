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

namespace DistributionManagementWinForm.home
{
    public partial class Home : Form
    {
        private string userName;
        private Form currentChildForm;
        public Home(string userName = "Admin")
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childFormTitleLabel.Text = childForm.Text;
        }

        #region ToolSubPanel


        private void hideSubPanel()
        {
            if(orderSubPanel.Visible == true)
                orderSubPanel.Visible = false;
            if (inventorySubPanel.Visible == true)
                inventorySubPanel.Visible = false;
            if (reportSubPanel.Visible == true)
                reportSubPanel.Visible = false;
            if (userSubPanel.Visible == true)
                userSubPanel.Visible = false;
        }

        private void showSubPanel(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hideSubPanel();
                subPanel.Visible = true;
            }
            else
                subPanel.Visible = false;
        }

        #endregion

        #region User
        private void userLabel_Click(object sender, EventArgs e)
        {
            showSubPanel(userSubPanel);
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile());
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            Form login = null;
            List<Form> openForms = Application.OpenForms.Cast<Form>().ToList();

            foreach (Form openForm in openForms)
            {
                if (openForm.Name == "LoginForm")
                    login = openForm;
                else if (openForm.Name == "Home")
                    continue;
                else
                    openForm.Close();
            }
            login.Show();
            login.Enabled = true;

            this.Hide();
        }

        #endregion

        #region Order
        private void orderBtn_Click(object sender, EventArgs e)
        {
            showSubPanel(orderSubPanel);
        }

        private void orderListBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Order.OrderListForm());
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Order.PlaceOrderForm());
        }

        

        #endregion

        #region Inventory
        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            showSubPanel(inventorySubPanel);
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory.ProductListForm());
        }
        private void receiptsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory.ReceiptForm());
        }

        private void deliveriesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory.DeliveryForm());
        }

        #endregion

        #region Report
        private void reportBtn_Click(object sender, EventArgs e)
        {
            showSubPanel(reportSubPanel);
        }

        private void stockReportBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Report.StockReportForm());
        }

        private void saleReportBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Report.SaleReportForm());
        }

        #endregion

        #region Admin

        private void adminBtn_Click(object sender, EventArgs e)
        {
            // check if user is an admin
            OpenChildForm(new Admin.AdminForm());

        }

        #endregion

        #region Setting
        private void settingBtn_Click(object sender, EventArgs e)
        {
            childFormTitleLabel.Text = "Setting";
        }

        #endregion

        #region Dashboard
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            hideSubPanel();
            OpenChildForm(new Dashboard());
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dashboardBtn_Click(sender, e);
            userLabel.Text = userName; 
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            dashboardBtn_Click(sender, e);
        }

        private void childFormTitleLabel_Click(object sender, EventArgs e)
        {
            dashboardBtn_Click(sender, e);
        }

        #endregion


        // Drag from title bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<Form> openForms = Application.OpenForms.Cast<Form>().ToList();

            foreach (Form openForm in openForms)
            {
                openForm.Close();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
