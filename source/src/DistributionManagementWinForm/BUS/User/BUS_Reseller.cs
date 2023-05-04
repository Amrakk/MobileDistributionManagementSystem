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
        private readonly DAL_Reseller DReseller;

        public BUS_Reseller(int reseller_id, string reseller_name, string address)
        {
            DReseller = new DAL_Reseller(reseller_id, reseller_name, address);
        }

        public void AddReseller()
        {
            DReseller.addQuery();
        }

        public void UpdateReseller()
        {
            DReseller.updateQuery();
        }

        public void DeleteReseller()
        {
            DReseller.deleteQuery();
        }

        public DataTable SelectResellers()
        {
            string query = $"SELECT * FROM Reseller";
            return DReseller.selectQuery(query);
        }

        public DataTable SelectResellerById(int id)
        {
            string query = $"SELECT * FROM Reseller WHERE reseller_id = {id}";
            return DReseller.selectQuery(query);
        }
        public DataTable SelectResellerByName(string name)
        {
            string query = $"SELECT * FROM Reseller WHERE reseller_name LIKE '%{name}%'";
            return DReseller.selectQuery(query);
        }
    }
}
