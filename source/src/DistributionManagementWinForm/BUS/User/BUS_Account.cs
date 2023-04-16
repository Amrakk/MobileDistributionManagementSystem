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
        private DAL_Account DAccount;

        public BUS_Account(int account_id, string username, string password, int isActivated, DateTime created_date)
        {
            DAccount = new DAL_Account(account_id, username, password, isActivated, created_date);
        }

        public void addQuery()
        {
            DAccount.addQuery();
        }

        public void updateQuere()
        {
            DAccount.updateQuery();
        }

        public void deleteQuery()
        {
            DAccount.deleteQuery();
        }

        public DataTable selectQuery(string query)
        {
            return DAccount.selectQuery(query);
        }

        
    }
}
