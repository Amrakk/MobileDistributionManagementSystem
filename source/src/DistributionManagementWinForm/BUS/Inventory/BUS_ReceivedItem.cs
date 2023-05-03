using DAL.Inventory;
using DTO.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Inventory
{
    public class BUS_ReceivedItem
    {
        private DAL_ReceivedItem DReceivedItem;

        public BUS_ReceivedItem(int received_id, int product_id, int quantity, int cost_per_unit)
        {
            DReceivedItem = new DAL_ReceivedItem(received_id, product_id, quantity, cost_per_unit);
        }

        public void addQuery()
        {
            DReceivedItem.addQuery();
        }

        public void updateQuery()
        {
            DReceivedItem.updateQuery();
        }

        public void deleteQuery()
        {
            DReceivedItem.deleteQuery();
        }

        public DataTable selectQuery(string query)
        {
            return DReceivedItem.selectQuery(query);
        }
    }
}
