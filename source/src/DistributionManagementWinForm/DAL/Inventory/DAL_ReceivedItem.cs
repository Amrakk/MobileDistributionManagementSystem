using DTO.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Inventory
{
    public class DAL_ReceivedItem
    {
        private ReceivedItem receivedItem;

        public DAL_ReceivedItem(int receivedId, int productId, int quantity, int costPerUnit)
        {
            receivedItem = new ReceivedItem(receivedId, productId, quantity, costPerUnit);
        }

        public void addQuery()
        {
            string sql = $"INSERT INTO Received_Item (received_id, product_id, quantity, cost_per_unit) VALUES " +
                                                   $"({receivedItem.ReceivedId}, " +
                                                   $"{receivedItem.ProductId}, " +
                                                   $"{receivedItem.Quantity}, " +
                                                   $"{receivedItem.CostPerUnit})";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = $"UPDATE Received_Item SET quantity = {receivedItem.Quantity}, " +
                                                  $"cost_per_unit = {receivedItem.CostPerUnit} " +
                                                  $"WHERE received_id = {receivedItem.ReceivedId} " +
                                                  $"AND product_id = {receivedItem.ProductId}";
            Connection.actionQuery(sql);
        }

        public void deleteQuery()
        {
            string sql = $"DELETE FROM Received_Item WHERE received_id = {receivedItem.ReceivedId} AND " +
                                                         $"product_id = {receivedItem.ProductId}";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }
    }
}
