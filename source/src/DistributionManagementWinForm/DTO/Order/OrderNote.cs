using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Order
{
    public class OrderNote
    {
        private int order_id;
        private DateTime order_date;
        private int reseller_id;
        private int status_id;
        private decimal total_price;
        private string payment_method;

        public OrderNote(int order_id, DateTime order_date, int reseller_id, int status_id, decimal total_price, string payment_method)
        {
            this.order_id = order_id;
            this.order_date = order_date;
            this.reseller_id = reseller_id;
            this.status_id = status_id;
            this.total_price = total_price;
            this.payment_method = payment_method;
        }

        public int OrderId { get => order_id; set => order_id = value; }
        public DateTime OrderDate { get => order_date; set => order_date = value; }
        public int ResellerId { get => reseller_id; set => reseller_id = value; }
        public int StatusId { get => status_id; set => status_id = value; }
        public decimal TotalPrice { get => total_price; set => total_price = value; }
        public string PaymentMethod { get => payment_method; set => payment_method = value; }
    }
}
