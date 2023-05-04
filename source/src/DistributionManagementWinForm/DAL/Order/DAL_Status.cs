using DTO.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Order
{
    public class DAL_Status
    {
        private Status status;

        public DAL_Status(int id, string name)
        {
            status = new Status(id, name);
        }

        public string getStatus(int id)
        {
            string sql = $"SELECT status_name FROM Status WHERE status_id = {id}";
            DataTable result = Connection.selectQuery(sql);
            if (result.Rows.Count > 0)
                return result.Rows[0]["status_name"].ToString();
            else
                return null;
        }
    }
}
