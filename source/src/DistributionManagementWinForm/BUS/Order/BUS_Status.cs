using DAL.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Order
{
    public class BUS_Status
    {
        private DAL_Status DStatus;

        public BUS_Status(int id, string name)
        {
            DStatus = new DAL_Status(id, name);
        }

        public string GetStatus(int id)
        {
            return DStatus.getStatus(id);
        }
    }
}
