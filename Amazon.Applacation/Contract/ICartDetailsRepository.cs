using Amazon.Models.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Contract
{
    public interface ICartDetailsRepository : Irepository<CartDetails, int>
    {
        IQueryable<CartDetails> GetAllByCartId(int CartId);
        CartDetails GetCartDetailsBy(int ProductId);


    }
}
