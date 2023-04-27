using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.User
{
    public class Account
    {
        private int account_id;
        private string username;
        private string password;
        private int isActivated;
        private DateTime created_date;

        public Account(int account_id, string username, string password, int isActivated, DateTime created_date)
        {
            this.account_id = account_id;
            this.username = username;
            this.password = password;
            this.isActivated = isActivated;
            this.created_date = created_date;
        }

        public int Account_id { get => account_id; set => account_id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int IsActivated { get => isActivated; set => isActivated = value; }
        public DateTime Created_date { get => created_date; set => created_date = value; }
    }
}
