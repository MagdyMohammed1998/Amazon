using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models.Models
{
    public class Cart
    {
        public int Id { get; set; }

        // Foreign key property
        [ForeignKey("User")]
        public int? UserId { get; set; }

        // Navigation property
        public virtual User? User { get; set; }

        // Collection navigation property
        public virtual IQueryable<CartDetails> CartDetail { get; set; }
    }


}
