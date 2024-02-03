using Amazon.Models.Models;


namespace Amazon.Applacation.Service
{
    public interface ICartService
    {
        Cart Add(int UserId);
        Cart GetCartByUserEmail(string UserEmail);
    }
}