using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistributionManagementWinForm.auth
{
    public class AuthShared
    {
        private static void changeTextColor(TextBox textBox, string message)
        {
            if (textBox.Text == "")
            {
                textBox.Text = message;
                textBox.ForeColor = Color.Gray;
            }

            textBox.ForeColor = Color.Black;
        }

        public static void textChangedStyling(TextBox textBox)
        {
            switch (textBox.Name)
            {
                case "userTextBox": changeTextColor(textBox, "Username"); break;
                case "passTextBox": changeTextColor(textBox, "Username"); break;
                case "confirmPassTextBox": changeTextColor(textBox, "Confirm Password"); break;
                case "fNameTextBox": changeTextColor(textBox, "First Name"); break;
                case "lNameTextBox": changeTextColor(textBox, "Last Name"); break;
                case "emailTextBox": changeTextColor(textBox, "Email"); break;
                case "phoneTextBox": changeTextColor(textBox, "Phone Number"); break;
                case "resellerNameTextBox": changeTextColor(textBox, "Reseller Name"); break;
                case "resellerAddTextBox": changeTextColor(textBox, "Reseller Address"); break;
                default: changeTextColor(textBox, "Unknown"); break;

            }
        }
    }
}
