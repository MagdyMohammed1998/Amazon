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
    public class ProductRepository : Repository<Product,int> , IProductRepository
    {
        AmazonContext _Context;
       public ProductRepository(AmazonContext context) : base(context) 
        { 
            _Context = context;
        }

        public IQueryable <Product> SearchByName(string name)
        {
            return _Context.Products.Where(p => p.Name.Contains(name));
        }
    }
}
