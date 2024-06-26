﻿using Amazon.Applacation.Contract;
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
        IAdminRepository _adminRepository;
        public UserService(IUserRepository userRepository, IAdminRepository adminRepository)
        {
            _userRepository = userRepository;
            _adminRepository = adminRepository;
        }


        public IQueryable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public User AddUser(User user)
        {
            user.Email = user.Email.ToLower();
            if (ValidUniqueEmail(user.Email) &&
              _adminRepository.ValidUniqueEmailAdmin(user.Email)){
         
                
                var userRepostry = _userRepository.AddUser(user);
                _userRepository.Save();
                return userRepostry;

            }
            else
            {
                //throw new Exception("This Email is Already Exist !");
                return null;
            }
        }

        public bool ValidUniqueEmail(string email)
        {
            if(email is not null) {
                return _userRepository.ValidUniqueEmail(email);
            }
            else
            {
                return false;
            }
        }

        public bool GetUserEmailAndPassword(string email, string password)
        {

            return _userRepository.GetUserEmailAndPassword(email.ToLower(), password);
        }

        public int Save()
        {
            return _userRepository.Save();
        }

        

        

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            _userRepository.Delete(user);
            _userRepository.Save();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string Email)
        {
            return _userRepository.GetUserByEmail(Email);
        }
    }


   
        

       
}
