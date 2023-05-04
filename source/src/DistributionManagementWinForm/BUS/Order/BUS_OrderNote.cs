using DAL.Order;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Order
{
    public class BUS_OrderNote
    {
        private readonly DAL_OrderNote DOrderNote;

        public BUS_OrderNote(int orderId, DateTime orderDate, int resellerId, int statusId, decimal totalPrice, string paymentMethod)
        {
            DOrderNote = new DAL_OrderNote(orderId, orderDate, resellerId, statusId, totalPrice, paymentMethod);
        }

        public void AddOrderNote()
        {
            DOrderNote.addQuery();
        }

        public void UpdateOrderNote()
        {
            DOrderNote.updateQuery();
        }

        public void DeleteOrderNote()
        {
            DOrderNote.deleteQuery();
        }

        public DataTable SelectOrderNotes()
        {
            string query = "SELECT * FROM Order_Note";
            return DOrderNote.selectQuery(query);
        }

        public DataTable SearchOrderNoteById(int orderId)
        {
            string query = $"SELECT * FROM Order_Note WHERE order_id = {orderId}";
            return DOrderNote.selectQuery(query);
        }

        public DataTable SearchOrderNoteByResellerId(int resellerId)
        {
            string query = $"SELECT * FROM Order_Note WHERE reseller_id = {resellerId}";
            return DOrderNote.selectQuery(query);
        }

        public DataTable SearchOrderNoteByStatusId(int statusId)
        {
            string query = $"SELECT * FROM Order_Note WHERE status_id = {statusId}";
            return DOrderNote.selectQuery(query);
        }
    }

}
