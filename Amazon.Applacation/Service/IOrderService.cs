

using Amazon.Models.Models;

namespace Amazon.Applacation.Service
{
    public interface IOrderService
    {
        Order Add(Order order);
        Order UpdateState(int orderId, StateOrder newState);
    }
}