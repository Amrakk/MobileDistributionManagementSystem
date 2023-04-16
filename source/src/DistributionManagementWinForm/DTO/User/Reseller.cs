using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.User
{
    public class Reseller
    {
        private int reseller_id;
        private string reseller_name;
        private string address;

        public Reseller(int reseller_id, string reseller_name, string address)
        {
            this.reseller_id = reseller_id;
            this.reseller_name = reseller_name;
            this.address = address;
        }

        public int Reseller_id { get => reseller_id; set => reseller_id = value; }
        public string Reseller_name { get => reseller_name; set => reseller_name = value; }
        public string Address { get => address; set => address = value; }
    }
}
