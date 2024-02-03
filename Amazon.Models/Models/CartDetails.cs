using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models.Models
{
    public class CartDetails
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        // Foreign key property
        public int ProductId { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }

        // Navigation properties
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }


        public Cart? Cart { get; set; }

    }
}
