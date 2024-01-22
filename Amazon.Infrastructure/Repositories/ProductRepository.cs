using Amazon.Applacation.Contract;
using Amazon.Context;
using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product,int> , IProductRepository
    {

       public ProductRepository(AmazonContext context) : base(context) { }





    }
}
