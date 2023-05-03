using DTO.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Inventory
{
    public class DAL_GoodsReceivedNote
    {
        private GoodsReceivedNote GRN;

        public DAL_GoodsReceivedNote(int receivedId, DateTime receivedDate, string receivedFrom, int totalQuantity, int totalCost)
        {
            GRN = new GoodsReceivedNote(receivedId, receivedDate, receivedFrom, totalQuantity, totalCost);
        }

        public void addQuery()
        {
            string sql = $"INSERT INTO Goods_Received_Note (received_date, received_from, total_quantity, total_cost) VALUES ('{GRN.ReceivedDate}', '{GRN.ReceivedFrom}', {GRN.TotalQuantity}, {GRN.TotalCost})";
            Connection.actionQuery(sql);
        }

        public void updateQuery()
        {
            string sql = $"UPDATE Goods_Received_Note SET received_date = '{GRN.ReceivedDate}', received_from = '{GRN.ReceivedFrom}', total_quantity = {GRN.TotalQuantity}, total_cost = {GRN.TotalCost} WHERE received_id = {GRN.ReceivedId}";
            Connection.actionQuery(sql);
        }

        public void deleteQuery()
        {
            string sql = $"DELETE FROM Goods_Received_Note WHERE received_id = {GRN.ReceivedId}";
            Connection.actionQuery(sql);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }
    }
}

