using DTO.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.User
{
    public class DAL_Reseller
    {
        private Reseller reseller;

        public DAL_Reseller(int reseller_id, string reseller_name, string address)
        {
            reseller = new Reseller(reseller_id, reseller_name, address);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Reseller (reseller_id, reseller_name, address) VALUES ('"
                                + reseller.Reseller_id + "', '"
                                + reseller.Reseller_name + "', '"
                                + reseller.Address + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Reseller SET "
                                + "reseller_name = '" + reseller.Reseller_name + "', "
                                + "address = '" + reseller.Address + "' "
                                + "WHERE reseller_id = " + reseller.Reseller_id;
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Reseller WHERE reseller_id = " + reseller.Reseller_id;
            Connection.actionQuery(query);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }
    }
}
