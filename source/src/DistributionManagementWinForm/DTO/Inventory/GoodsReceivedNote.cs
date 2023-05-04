using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Inventory
{
    public class GoodsReceivedNote
    {
        private int received_id;
        private DateTime received_date;
        private string received_from;
        private int total_quantity;
        private int total_cost;
       
        public GoodsReceivedNote(int received_id, DateTime received_date, string received_from, int total_quantity, int total_cost)
        {
            this.received_id = received_id;
            this.received_date = received_date;
            this.received_from = received_from;
            this.total_quantity = total_quantity;
            this.total_cost = total_cost;
        }

        public int ReceivedId { get => received_id; set => received_id = value; }
        public DateTime ReceivedDate { get => received_date; set => received_date = value; }
        public string ReceivedFrom { get => received_from; set => received_from = value; }
        public int TotalQuantity { get => total_quantity; set => total_quantity = value; }
        public int TotalCost { get => total_cost; set => total_cost = value; }

    }
}
