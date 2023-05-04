using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Inventory
{
    public class ReceivedItem
    {
        private int received_id;
        private int product_id;
        private int quantity;
        private int cost_per_unit;


        public ReceivedItem(int received_id, int product_id, int quantity, int cost_per_unit)
        {
            this.received_id = received_id;
            this.product_id = product_id;
            this.quantity = quantity;
            this.cost_per_unit = cost_per_unit;
        }

        public int ReceivedId { get => received_id; set => received_id = value; }
        public int ProductId { get => product_id; set => product_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int CostPerUnit { get => cost_per_unit; set => cost_per_unit = value; }
    }
}
