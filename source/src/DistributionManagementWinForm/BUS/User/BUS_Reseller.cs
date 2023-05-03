using DAL.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.User
{
    public class BUS_Reseller
    {
        private DAL_Reseller DReseller;

        public BUS_Reseller(int reseller_id, string reseller_name, string address)
        {
            DReseller = new DAL_Reseller(reseller_id, reseller_name, address);
        }

        public void addQuery()
        {
            DReseller.addQuery();
        }

        public void updateQuere()
        {
            DReseller.updateQuery();
        }

        public void deleteQuery()
        {
            DReseller.deleteQuery();
        }

        public DataTable selectQuery(string query)
        {
            return DReseller.selectQuery(query);
        }
    }
}
