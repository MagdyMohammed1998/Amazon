using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models.Models
{
    public class User
    {
          public int Id { get; set; }

      public string Name { get; set; }

      public string Email { get; set; }

      public string Password { get; set; }


     public Card Card { get; set; }

     public List<Order> Orders { get; set; }

    }
}
