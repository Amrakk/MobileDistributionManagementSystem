using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Order
{
    public class DTO_DeliveryNote
    {
        private int id;
        private DateTime date;
        private string method;

        public DTO_DeliveryNote(int id, DateTime date, string method)
        {
            this.id = id;
            this.date = date;
            this.method = method;
        }

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Method { get => method; set => method = value; }
    }

}
