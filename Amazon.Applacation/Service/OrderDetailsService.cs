using System;

using Amazon.Applacation.Contract;
using Amazon.Models.Models;
namespace Amazon.Applacation.Service
{
    public class OrderDetailsService : IOrderDetailsService
    {
        private readonly IorderDetailsRepository _orderDetailsRepository;
        private readonly ICartDetailsRepository _cartDetailsRepository;
        private readonly IProductRepository _ProductRepostory;


        public OrderDetailsService(IorderDetailsRepository orderDetailsRepository, ICartDetailsRepository cartDetailsRepository, IProductRepository productRepostory)
        {
            _orderDetailsRepository = orderDetailsRepository ?? throw new ArgumentNullException(nameof(orderDetailsRepository));
            _cartDetailsRepository = cartDetailsRepository ?? throw new ArgumentNullException(nameof(cartDetailsRepository));
            _ProductRepostory = productRepostory ?? throw new ArgumentNullException(nameof(productRepostory));
        }

        public OrderDetails AddFromCartDetails(CartDetails cartDetails, Order order)
        {
            if (cartDetails is not null && cartDetails.Quantity > 0)
            {
                var orderDetail = new OrderDetails
                {
                    Quantity = cartDetails.Quantity,
                    Price = _ProductRepostory.GetById(cartDetails.ProductId).Price,
                    ProductId = cartDetails.ProductId,
                    OrderId = order.Id
                };

                var res = _orderDetailsRepository.Add(orderDetail);
                _orderDetailsRepository.Save();

                var p = _ProductRepostory.GetById(orderDetail.ProductId);
                p.Quantity -= orderDetail.Quantity;
                _ProductRepostory.Update(p);
                _ProductRepostory.Save();


                return res;
            }
            else
            {
                throw new Exception("OrderDetails data is not valid!");
            }
        }
    }
}
