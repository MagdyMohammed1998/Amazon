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

        public Admin GetAdminByEmail(string email)
        {
            if(email == null) throw new ArgumentNullException("email"); 
          return _adminRepository.GetAdminByEmail(email);
        }

        public bool GetAdminEmailAndPassword(string email, string password)
        {
            return _adminRepository.GetAdminEmailAndPassword(email.ToLower(), password);
        }

        public bool ValidUniqueEmailAdmin(string email)
        {
            return _adminRepository.ValidUniqueEmailAdmin(email);
        }

    }
}
