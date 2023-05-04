using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Order
{
    public class OrderItem
    {
        private int order_id;
        private int product_id;
        private int quantity;

        public OrderItem(int order_id, int product_id, int quantity)
        {
            this.order_id = order_id;
            this.product_id = product_id;
            this.quantity = quantity;
        }

        public int Order_id { get => order_id; set => order_id = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }

}
