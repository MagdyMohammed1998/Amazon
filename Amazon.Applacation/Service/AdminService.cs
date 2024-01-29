using Amazon.Applacation.Contract;
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
        public bool ValidUniqueEmailAdmin(string email)
        {
            return _adminRepository.ValidUniqueEmailAdmin(email);
        }
    }
}
