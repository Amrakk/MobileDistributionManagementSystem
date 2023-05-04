using DTO.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Order
{
    public class DAL_OrderNote
    {
        private OrderNote orderNote;

        public DAL_OrderNote(int order_id, DateTime date, int reseller_id, int status_id, decimal total_price, string payment_method)
        {
            orderNote = new OrderNote(order_id, date, reseller_id, status_id, total_price, payment_method);
        }

        public void addQuery()
        {
            string query = $"INSERT INTO Order_Note (order_date, reseller_id, status_id, total_price, payment_method) VALUES " +
                                                  $"('{orderNote.OrderDate}', " +
                                                  $"'{orderNote.ResellerId}', " +
                                                  $"'{orderNote.StatusId}', " +
                                                  $"'{orderNote.TotalPrice}', " +
                                                  $"'{orderNote.PaymentMethod}')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = $"UPDATE Order_Note SET order_date = '{orderNote.OrderDate}', " +
                                                 $"reseller_id = '{orderNote.ResellerId}'," +
                                                 $" status_id = '{orderNote.StatusId}', " +
                                                 $"total_price = '{orderNote.TotalPrice}', " +
                                                 $"payment_method = '{orderNote.PaymentMethod}'" +
                                                 $" WHERE order_id = {orderNote.OrderId}";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = $"DELETE FROM Order_Note WHERE order_id = {orderNote.OrderId}";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }
    }

}
