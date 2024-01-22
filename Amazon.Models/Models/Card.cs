using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Models.Models
{
    public class Card
    {
        public int Id { get; set; }

        public int UserID { get; set; }
        public bool IsConfirmed { get; set; }

        public User User { get; set; }

        public List<CardItem> cardItems { get; set; }

    }
}
