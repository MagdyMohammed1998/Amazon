using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models.Models
{
    public class CardItem
    {
        public int Id { get; set; }

        public int CardID { get; set; }

        public int ProductID { get; set; }

        public int Quantity { get; set; }


        public Card card { get; set; }

        public Product product { get; set; }

    }
}
