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
    public class AdminRepository : IAdminRepository
    {
        AmazonContext _Context;
        DbSet<Admin> SetEntity;
        public AdminRepository(AmazonContext context)
        {
            _Context = context;
            SetEntity = _Context.Set<Admin>();
        }


        public bool ValidUniqueEmailAdmin(string email)
        {
            return !_Context.Admins.Any(admin => admin.Email == email);
        }

        public bool GetAdminEmailAndPassword(string email, string password)
        {
            return _Context.Admins.Any(admin => admin.Email == email && admin.Password == password);
        }

        public IQueryable<Admin> GetAllAdmin()
        {
            return _Context.Admins.AsQueryable();
        }

        public IQueryable<Admin> GetAllAdminByEmail(string email)
        {
            return _Context.Admins.AsQueryable();
        }

        public Admin AddAdmin(Admin entity)
        {
            return SetEntity.Add(entity).Entity;
        }

        public bool ValidUniqueEmail(string email)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            return _Context.SaveChanges();
        }

        public void Delete(Admin admin)
        {
            if (admin != null)
            {
                var trackedAdmin = _Context.Admins.Find(admin.Id); // Retrieve the tracked admin entity by Id
                if (trackedAdmin != null)
                {
                    _Context.Admins.Remove(trackedAdmin);
                    _Context.SaveChanges();
                }
            }
        }

        public Admin GetAdmin(string email)
        {
          return  _Context.Admins.FirstOrDefault(a=>a.Email == email);
        }
    }
}
