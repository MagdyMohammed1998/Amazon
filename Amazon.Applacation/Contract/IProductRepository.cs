using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Contract
{
    public interface IProductRepository : Irepository<Product, int>
    {



        IQueryable <Product> SearchByName(string name);

        IQueryable<Product> GetProductsByQuantity(int quantity);
        Product GetProductByName(string productName);
    }
}
