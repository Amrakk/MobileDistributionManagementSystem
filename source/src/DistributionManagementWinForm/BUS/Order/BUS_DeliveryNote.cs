using DAL.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Order
{
    public class BUS_DeliveryNote
    {
        private readonly DAL_DeliveryNote DDeliveryNote;

        public BUS_DeliveryNote(int id, DateTime date, string method)
        {
            DDeliveryNote = new DAL_DeliveryNote(id, date, method);
        }

        public void AddDeliveryNote()
        {
            DDeliveryNote.addQuery();
        }

        public void UpdateDeliveryNote()
        {
            DDeliveryNote.updateQuery();
        }

        public void DeleteDeliveryNote()
        {
            DDeliveryNote.deleteQuery();
        }

        public DataTable SelectDeliveryNotes()
        {
            string query = "SELECT * FROM Delivery_Note";
            return DDeliveryNote.selectQuery(query);
        }

        public DataTable SearchDeliveryNoteById(int delivery_id)
        {
            string query = $"SELECT * FROM Delivery_Note WHERE delivery_id = {delivery_id}";
            return DDeliveryNote.selectQuery(query);
        }

        public DataTable SearchDeliveryNoteByMethod(string delivery_method)
        {
            string query = $"SELECT * FROM Delivery_Note WHERE delivery_method LIKE '%{delivery_method}%'";
            return DDeliveryNote.selectQuery(query);
        }
    }

}


