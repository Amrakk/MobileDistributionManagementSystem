using DTO.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Order
{
    public class DAL_DeliveryNote
    {
        private DTO_DeliveryNote deliveryNote;

        public DAL_DeliveryNote(int id, DateTime date, string method)
        {
            deliveryNote = new DTO_DeliveryNote(id, date, method);
        }

        public void addQuery()
        {
            string query = $"INSERT INTO Delivery_Note (delivery_id, delivery_date, delivery_method) VALUES " +
                                                     $"('{deliveryNote.Id}', " +
                                                     $"'{deliveryNote.Date}', " +
                                                     $"'{deliveryNote.Method}')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = $"UPDATE Delivery_Note SET delivery_date = '{deliveryNote.Date}', " +
                                                    $"delivery_method = '{deliveryNote.Method}' " +
                                                    $"WHERE delivery_id = {deliveryNote.Id}";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = $"DELETE FROM Delivery_Note WHERE delivery_id = {deliveryNote.Id}";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery(string query)
        {
            return Connection.selectQuery(query);
        }

    }

}
