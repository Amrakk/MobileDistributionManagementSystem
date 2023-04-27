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

        public DAL_Account(int account_id, string username, string password, int isActivated, DateTime created_date)
        {
            account = new Account(account_id, username, password, isActivated, created_date);
        }

        public void addQuery()
        {
            string query = "insert into Account (account_id, username, password, created_date) values ('"
                                + account.Account_id + "', '"
                                + account.Username + "', '"
                                + account.Password + "', '"
                                + account.Created_date + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "update Account set "
                                + "username = " + account.Username + "', '"
                                + "password = " + account.Password + "', '"
                                + "isActivated = " + account.IsActivated + "', '"
                                + "created_date = " + account.Created_date + "', '"
                                + "where account_id = " + account.Account_id;
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from Account where account_id = " + account.Account_id;
            Connection.actionQuery(query);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }

        
    }
}
