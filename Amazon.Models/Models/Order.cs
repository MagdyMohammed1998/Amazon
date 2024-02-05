using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models.Models
{
    public class Order
    {


        public int Id { get; set; }
        public StateOrder StateOrder { get; set; }
        public DateTime OrderDate { get; set; }
        //fk
        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Admin")]
       
        //Relations

       
        public virtual List<OrderDetails> OrderDetail { get; set; }

        public virtual User User { get; set; }
    }
    public enum StateOrder
    {
        processing,
        shipped,
        delivered,
        Processing
    }
}
