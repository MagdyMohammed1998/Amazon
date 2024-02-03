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
    public class CartRepository : Repository<Cart, int>, ICartRepository
    {
        AmazonContext _Context;

        public CartRepository(AmazonContext amazonContext) : base(amazonContext)
        {
            _Context = amazonContext;
        }


        public Cart GetCartByUserEmail(string UserEmail)
        {
            return _Context.Cards.SingleOrDefault(c => c.User.Email == UserEmail);
        }

        public Cart GetCartByUserId(int userId)
        {
            return _Context.Cards.SingleOrDefault(c => c.User.Id == userId);
        }
    }
}
