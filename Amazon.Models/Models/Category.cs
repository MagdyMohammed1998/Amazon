using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? AdminID { get; set; }

        public Admin Admin { get; set; }

      public  IQueryable<Product> products { get; set; }

    }
}
