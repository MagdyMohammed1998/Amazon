
using Amazon.Applacation.Contract;
using Amazon.Context;
using Amazon.Infrastructure.Repositories;
using Amazon.Models.Models;

using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastructure
{
    public class CartDetailsRepository : Repository<CartDetails, int>, ICartDetailsRepository
    {
        AmazonContext _Context;

        public CartDetailsRepository(AmazonContext context) : base(context)
        {
            _Context = context;
        }

        public IQueryable<CartDetails> GetAllByCartId(int CartId)
        {
            return _Context.CartDetails.Where(CD => CD.CartId == CartId);
        }
        public CartDetails GetCartDetailsBy(int ProductId)
        {
            return _Context.CartDetails.FirstOrDefault(CD => CD.ProductId == ProductId);
        }

    }
}
