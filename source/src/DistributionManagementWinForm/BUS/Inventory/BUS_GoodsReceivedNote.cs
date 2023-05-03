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
        private DAL_GoodsReceivedNote DGoodsReceivedNote;

        public BUS_GoodsReceivedNote(int received_id, DateTime received_date, string received_from, int total_quantity, int total_cost)
        {
            DGoodsReceivedNote = new DAL_GoodsReceivedNote(received_id, received_date, received_from, total_quantity, total_cost);
        }

        public void addQuery()
        {
            DGoodsReceivedNote.addQuery();
        }

        public void updateQuery()
        {
            DGoodsReceivedNote.updateQuery();
        }

        public void deleteQuery()
        {
            DGoodsReceivedNote.deleteQuery();
        }

        public DataTable selectQuery(string query)
        {
            return DGoodsReceivedNote.selectQuery(query);
        }

    }
}
