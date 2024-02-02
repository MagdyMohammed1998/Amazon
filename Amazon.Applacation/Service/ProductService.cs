using Amazon.Applacation.Contract;
using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Service
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;


        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public Product Add(Product product1)
        {
           var Data = _productRepository.Add(product1);
            _productRepository.Save();
            return Data;
        }


        public void Delete(Product product)
        {
           if(product != null)
            {
                _productRepository.Delete(product);
                _productRepository.Save();
            }
            else
            {
                throw new Exception("Product Not Found!");
            }
        }

        public IQueryable <Product> GetAll()
        {
           var Data = _productRepository.GetALL();
            _productRepository.Save();
            return Data;


        }


        public Product GetById(int id)
        {
            if(id != 0)
            {
                var Data = _productRepository.GetById(id);
                _productRepository.Save();
                return Data;
            }
            else
            {
                throw new Exception("Product Not Found:");
            }
        }

        

        public Product Update(Product product2)
        {
            var Data = _productRepository.Update(product2);
            _productRepository.Save();
            return Data;
        }



        public IQueryable <Product> SearchByName(string name)
        {
            var Data = _productRepository.SearchByName(name);
            _productRepository.Save();
            return Data;
        }

        public IQueryable<Product> GetProductsByQuantity(int quantity)
        {
            var Data = _productRepository.GetProductsByQuantity(quantity);
            _productRepository.Save();
            return Data;
        }
    }
}
