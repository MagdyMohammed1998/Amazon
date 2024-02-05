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
    public class OrderRepository : Repository<Order, int>, IOrderRepository
    {
        AmazonContext _Context;

        public OrderRepository(AmazonContext amazonContext) : base(amazonContext)
        {
            _Context = amazonContext;

        }

        public IQueryable<Order> GetOrderByUser(int UserID)
        {
            return _Context.Orders.Where(o=>o.UserId == UserID);
        }
    }
}
