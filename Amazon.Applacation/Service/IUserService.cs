using Amazon.Models.Models;

namespace Amazon.Applacation.Service
{
    public interface IUserService
    {
        User AddUser(User user);
        void DeleteUser(User user);
        IQueryable<User> GetAllUsers();
        User GetUserById(int id);
        User UpdateUser(User user);
    }
}