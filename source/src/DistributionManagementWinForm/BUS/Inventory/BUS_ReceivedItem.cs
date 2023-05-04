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
        private readonly DAL_ReceivedItem DReceivedItem;

        public BUS_ReceivedItem(int received_id, int product_id, int quantity, int cost_per_unit)
        {
            DReceivedItem = new DAL_ReceivedItem(received_id, product_id, quantity, cost_per_unit);
        }

        public void AddReceivedItem()
        {
            DReceivedItem.addQuery();
        }

        public void UpdateReceivedItem()
        {
            DReceivedItem.updateQuery();
        }

        public void DeleteReceivedItem()
        {
            DReceivedItem.deleteQuery();
        }

        public DataTable SelectReceivedItem(int received_id)
        {
            string query = $"SELECT * FROM Received_Item WHERE received_id = {received_id}";
            return DReceivedItem.selectQuery(query);
        }
        
    }
}
