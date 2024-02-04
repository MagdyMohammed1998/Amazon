using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Service
{
    public interface IProductService
    {
        public Product Add(Product product1);

        public Product Update(Product product2);

        public void Delete(Product product);

        public Product GetById(int id);

        public IQueryable <Product> GetAll();


        public IQueryable <Product> SearchByName(string name);


       public IQueryable<Product> GetProductsByQuantity(int quantity);
        int GetProductByName(string productName);
    }
}
