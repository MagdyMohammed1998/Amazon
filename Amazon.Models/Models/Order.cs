using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int UsertID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }

        public User User { get; set; }

       public List<OrderDetails> Details { get; set; }
    }
}
