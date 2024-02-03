using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Contract
{
    public interface ICartRepository : Irepository<Cart, int>
    {

        Cart GetCartByUserEmail(string Email);
        Cart GetCartByUserId(int userId);
    }
}
