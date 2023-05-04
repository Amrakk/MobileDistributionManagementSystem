using DAL.Inventory;
using DTO.Inventory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Inventory
{
    public class BUS_GoodsReceivedNote
    {
        private readonly DAL_GoodsReceivedNote DGoodsReceivedNote;

        public BUS_GoodsReceivedNote(int received_id, DateTime received_date, string received_from, int total_quantity, int total_cost)
        {
            DGoodsReceivedNote = new DAL_GoodsReceivedNote(received_id, received_date, received_from, total_quantity, total_cost);
        }

        public void AddGRN()
        {
            DGoodsReceivedNote.addQuery();
        }

        public void UpdateGRN()
        {
            DGoodsReceivedNote.updateQuery();
        }

        public void DeleteGRN()
        {
            DGoodsReceivedNote.deleteQuery();
        }

        public DataTable SelectGRNs()
        {
            string query = "SELECT * FROM Goods_Received_Note";
            return DGoodsReceivedNote.selectQuery(query);
        }

        public DataTable SelectGRNsById(int id)
        {
            string query = $"SELECT * FROM Goods_Received_Note WHERE received_id = {id}";
            return DGoodsReceivedNote.selectQuery(query);
        }
    }
}
