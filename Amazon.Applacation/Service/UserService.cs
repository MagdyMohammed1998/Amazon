using Amazon.Applacation.Contract;
using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Service
{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public List<User> GetAllUsers()
        {
            return _userRepository.GetALL();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User AddUser(User user)
        {
            var userRepostry = _userRepository.Add(user);
            _userRepository.Save();
            return userRepostry;
        }

        public User UpdateUser(User user)
        {
            var userRepostry = _userRepository.Update(user);
            _userRepository.Save();
            return userRepostry;
        }

        public void DeleteUser(User user)
        {
            _userRepository.Delete(user);
            _userRepository.Save();
        }



    }
}
