using BUS.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistributionManagementWinForm.home.Admin
{
    public partial class AccountDetailsForm : Form
    {
        private BUS_Account BAccount;
        private BUS_Profile BProfile;
        private BUS_Reseller BReseller;
        public AccountDetailsForm(int id)
        {
            InitializeComponent();
            BAccount = new BUS_Account(id, "", "", 0, DateTime.Now);
            BProfile = new BUS_Profile(id, "", "", "", "", 0);
            BReseller = new BUS_Reseller(id, "", "");
            // TODO - need to check the role if it is reseller
        }
    }
}
