using Amazon.Applacation.Contract;
using Amazon.Context;
using Amazon.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Infrastructure.Repositories
{
    public class UserRepository:IUserRepository
    {
        AmazonContext _Context;
        DbSet<User> SetEntity;

        public UserRepository(AmazonContext amazonContext)
        { 
           _Context = amazonContext;
           SetEntity = amazonContext.Set<User>();
        }

        public User AddUser(User entity)
        {
            return SetEntity.Add(entity).Entity;
        }

        public IQueryable<User> GetAllUsers()
        {
            return SetEntity;
        }

        public User GetUserById(int id)
        {
            return SetEntity.Find(id);
        }

        public int Save()
        {
            return _Context.SaveChanges();
        }

        public bool ValidUniqueEmail(string email)
        {
            return !_Context.Users.Any(user => user.Email == email);
        }

        public bool GetUserEmailAndPassword(string email, string password)
        {
            return _Context.Users.Any(user => user.Email == email && user.Password == password);
        }
    }
}
