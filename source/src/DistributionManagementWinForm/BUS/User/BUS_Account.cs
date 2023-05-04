using DAL.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.User
{
    public class BUS_Account
    {
        private readonly DAL_Account DAccount;

        public BUS_Account(int account_id, string username, string password, int is_activated, DateTime created_date)
        {
            DAccount = new DAL_Account(account_id, username, password, is_activated, created_date);
        }

        public void AddAccount()
        {
            DAccount.addQuery();
        }

        public void UpdateAccount()
        {
            DAccount.updateQuery();
        }

        public void DeleteAccount()
        {
            DAccount.deleteQuery();
        }

        public DataTable SelectAccounts()
        {
            string query = $"SELECT * FROM Account";
            return DAccount.selectQuery(query);
        }

        public DataTable SelectAccountById(int id)
        {
            string query = $"SELECT * FROM Account WHERE account_id = {id}";
            return DAccount.selectQuery(query);
        }
        public DataTable SelectAccountByUsername(string username)
        {
            string query = $"SELECT * FROM Account WHERE username = '{username}'";
            return DAccount.selectQuery(query);
        }
    }
}
