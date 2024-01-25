using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
        public int? AdminID { get; set; }
        public Admin admin { get; set; }

        public int? CategoryID { get; set; }
        public Category category { get; set; }

       public List<CardItem> CardItems { get; set; }

       public List<OrderDetails> OrderDetails { get; set; }
    }
}
