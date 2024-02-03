

using Amazon.Models.Models;
namespace Amazon.Applacation.Service
{
    public interface IOrderDetailsService
    {
        OrderDetails AddFromCartDetails(CartDetails cartDetails, Order order);
    }
}