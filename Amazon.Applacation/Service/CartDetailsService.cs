using Amazon.Applacation.Contract;
using Amazon.Models.Models;
using System;
using System.Linq;

namespace Amazon.Applacation.Service
{
    public class CartDetailsService : ICartDetailsService
    {
        private readonly ICartDetailsRepository _cartDetailsRepository;
        private readonly IProductRepository _ProductRepository;

        public CartDetailsService(ICartDetailsRepository cartDetailsRepository, IProductRepository ProductRepository)
        {
            _cartDetailsRepository = cartDetailsRepository ?? throw new ArgumentNullException(nameof(cartDetailsRepository));
            _ProductRepository = ProductRepository ?? throw new ArgumentNullException(nameof(ProductRepository));

        }

        public CartDetails Add(CartDetails cartDetails)
        {
            ValidateCartDetails(cartDetails);

            CartDetails existingCartDetails = _cartDetailsRepository.GetALL().FirstOrDefault(cd => cd.ProductId == cartDetails.ProductId);

            if (existingCartDetails != null)
            {

                existingCartDetails.Quantity += cartDetails.Quantity;


                int availableQuantity = _ProductRepository.GetById(cartDetails.ProductId).Quantity;
                if (existingCartDetails.Quantity > availableQuantity)
                {
                    existingCartDetails.Quantity = availableQuantity;
                }

                _cartDetailsRepository.Update(existingCartDetails);

            }
            else
            {
                _cartDetailsRepository.Add(cartDetails);
            }

            _cartDetailsRepository.Save();

            return cartDetails;
        }

        public CartDetails GetCartDetailsBy(int ProductId)
        {
            if (ProductId > 0)
            {
                return _cartDetailsRepository.GetCartDetailsBy(ProductId);
            }
            else
            {
                throw new Exception("Please Enter Right Product Id ");
            }
        }


        public CartDetails Update(string productName, int newQuantity)
        {

            Product product = _ProductRepository.GetProductByName(productName);
            CartDetails cartDetails = _cartDetailsRepository.GetCartDetailsBy(product.Id);
            ValidateCartDetails(cartDetails);


            if (product != null && product.Quantity >= newQuantity)
            {
                cartDetails.Quantity = newQuantity;
                CartDetails updatedCartDetails = _cartDetailsRepository.Update(cartDetails);
                _cartDetailsRepository.Save();
                return updatedCartDetails;
            }

            return null;
        }

        public void Delete(string productName)
        {
            Product product = _ProductRepository.GetProductByName(productName);
            CartDetails cartDetails = _cartDetailsRepository.GetCartDetailsBy(product.Id);
            ValidateCartDetails(cartDetails);

            _cartDetailsRepository.Delete(cartDetails);
            _cartDetailsRepository.Save();
        }
        public IQueryable<CartDetails> GetAllByCartId(int CartId)
        {
            if (CartId > 0)
            {
                return _cartDetailsRepository.GetAllByCartId(CartId);
            }
            else
                throw new ArgumentException("CartId must be greater than 0", nameof(CartId));

        }

        private void ValidateCartDetails(CartDetails cartDetails)
        {
            if (cartDetails == null || cartDetails.Quantity <= 0)
            {
                throw new Exception("CartDetails data is not valid!");
            }
        }


    }
}

