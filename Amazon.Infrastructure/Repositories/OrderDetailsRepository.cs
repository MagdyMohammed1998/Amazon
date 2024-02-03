using Amazon.Applacation.Contract;
using Amazon.Context;
using Amazon.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Infrastructure.Repositories
{
    public class OrderDetailsRepository : Repository<OrderDetails, int>, IorderDetailsRepository
    {
        public OrderDetailsRepository(AmazonContext context) : base(context)
        {
        }

    }
}
