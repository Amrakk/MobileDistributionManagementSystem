using DTO.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.User
{
    public class DAL_Account
    {
        private Account account;

        public DAL_Account(int account_id, string username, string password, int is_activated, DateTime created_date)
        {
            account = new Account(account_id, username, password, is_activated, created_date);
        }

        public void addQuery()
        {
            string query = $"INSERT INTO Account (account_id, username, password, created_date) VALUES " +
                                               $"('{account.Account_id}', " +
                                               $"'{account.Username}', " +
                                               $"'{account.Password}'," +
                                               $"'{account.Created_date}')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = $"UPDATE Account SET username = '{account.Username}', " +
                                              $"password = '{account.Password}'," +
                                              $"is_activated = {account.Is_Activated}," +
                                              $"created_date = '{account.Created_date}' " +
                                              $"WHERE account_id = {account.Account_id}";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = $"DELETE FROM Account WHERE account_id = {account.Account_id}";
            Connection.actionQuery(query);
        }


        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }

        
    }
}
