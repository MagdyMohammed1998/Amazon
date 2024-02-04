using Amazon.Applacation.Contract;
using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Service
{
    public class AdminService : IAdminService
    {
        IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Admin AddAdmin(Admin admin)
        {
            var Data = _adminRepository.AddAdmin(admin);
            _adminRepository.Save();
            return Data;
        }

        public void Delete(Admin admin)
        {
            if (admin != null)
            {
                _adminRepository.Delete(admin);
                _adminRepository.Save();
            }
            else
            {
                throw new Exception("Product Not Found!");
            }
        }

        public void DeleteAdmin(string email ,  string password)
        {
            var admin = _adminRepository.GetAllAdmin().FirstOrDefault(a => a.Email == email && a.Password == password);
            if (admin != null)
            {
                _adminRepository.Delete(admin);
                _adminRepository.Save();
            }
            else
            {
                throw new Exception("Admin Not Found!");
            }
        }

        public bool GetAdminEmailAndPassword(string email, string password)
        {
            return _adminRepository.GetAdminEmailAndPassword(email.ToLower(), password);
        }

        public IQueryable<Admin> GetAllAdmin()
        {
            return _adminRepository.GetAllAdmin();
        }

        public IQueryable<Admin> GetAllAdminByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            return _adminRepository.Save();
        }

        public bool ValidUniqueEmail(string email)
        {
            if (email is not null)
            {
                return _adminRepository.ValidUniqueEmail(email);
            }
            else
            {
                return false;
            }
        }

        public bool ValidUniqueEmailAdmin(string email)
        {
            if (email is not null)
            {
                return _adminRepository.ValidUniqueEmail(email);
            }
            else
            {
                return false;
            }
        }
    }
}
