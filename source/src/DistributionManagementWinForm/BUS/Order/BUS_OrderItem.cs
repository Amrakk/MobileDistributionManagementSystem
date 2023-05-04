using DAL.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Order
{
    public class BUS_OrderItem
    {
        private readonly DAL_OrderItem DOrderItem;

        public BUS_OrderItem(int order_id, int product_id, int quantity)
        {
            DOrderItem = new DAL_OrderItem(order_id, product_id, quantity);
        }

        public void AddOrderItem()
        {
            DOrderItem.addQuery();
        }

        public void UpdateOrderItem()
        {
            DOrderItem.updateQuery();
        }

        public void DeleteOrderItem()
        {
            DOrderItem.deleteQuery();
        }

        public DataTable SelectOrderItems(int order_id)
        {
            string query = $"SELECT * FROM Order_Item WHERE order_id = {order_id}";
            return DOrderItem.selectQuery(query);
        }
    }

}
