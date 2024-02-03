
using Amazon.Applacation.Contract;
using Amazon.Models.Models;
using System;

namespace Amazon.Applacation.Service
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepostory;

        public CartService(ICartRepository cartRepostory)
        {
            if (cartRepostory == null)
            {
                throw new ArgumentNullException(nameof(cartRepostory));
            }

            _cartRepostory = cartRepostory;
        }

        public Cart Add(int Userid)
        {

            var existingCart = _cartRepostory.GetCartByUserId(Userid);
            if (existingCart == null)
            {
                Cart cart = new Cart();
                cart.User.Id = Userid;
                var res = _cartRepostory.Add(cart);

                _cartRepostory.Save();
                return res;
            }
            else
            {
                return existingCart;
            }
        }
        public Cart GetCartByUserId(int userId)
        {
            if (userId > 0)
                return _cartRepostory.GetCartByUserId(userId);
            else
                throw new Exception("I Dont Have User By This ID");
        }
        public Cart GetCartByUserEmail(string email)
        {
            if (email is not "" && email != null)
                return _cartRepostory.GetCartByUserEmail(email);
            else
                throw new Exception("I Dont Have User By This ID");
        }
    }
}
