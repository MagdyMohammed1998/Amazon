using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Contract
{
    public interface IUserRepository
    {
        IQueryable<User> GetAllUsers();
        User GetUserById(int id);
        User AddUser(User entity);
        bool ValidUniqueEmail(string email);
        int Save();
        bool GetUserEmailAndPassword(string email,string password);
        void Delete(User user);
        User GetUserByEmail(string Email);


    }
}
