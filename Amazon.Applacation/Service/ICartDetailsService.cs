

using Amazon.Models.Models;

namespace Amazon.Applacation.Service
{
    public interface ICartDetailsService
    {
        CartDetails Add(CartDetails cartDetails);
        void Delete(string productName);

        CartDetails Update(string productName, int newQuantity);

        IQueryable<CartDetails> GetAllByCartId(int CartId);

        CartDetails GetCartDetailsBy(int ProductId);

    }
}