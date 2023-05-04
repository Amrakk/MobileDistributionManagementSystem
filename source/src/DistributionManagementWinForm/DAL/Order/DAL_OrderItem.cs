using DTO.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Order
{
    public class DAL_OrderItem
    {
        private readonly OrderItem orderItem;

        public DAL_OrderItem(int order_id, int product_id, int quantity)
        {
            orderItem = new OrderItem(order_id, product_id, quantity);
        }

        public void addQuery()
        {
            string query = $"INSERT INTO Order_Item (order_id, product_id, quantity) VALUES " +
                                                  $"({orderItem.Order_id}, " +
                                                  $"{orderItem.Product_id}, " +
                                                  $"{orderItem.Quantity})";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = $"UPDATE Order_Item SET quantity = {orderItem.Quantity} WHERE order_id = {orderItem.Order_id} " +
                                                                                 $"AND product_id = {orderItem.Product_id}";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = $"DELETE FROM Order_Item WHERE order_id = {orderItem.Order_id} " +
                                                    $"AND product_id = {orderItem.Product_id}";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }
    }

}
