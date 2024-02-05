using Amazon.Applacation.Contract;
using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Service
{
    public interface IAdminService:IAdminRepository
    {
        Admin AddAdmin(Admin admin);
        void DeleteAdmin(string email , string password);
        IQueryable<Admin> GetAllAdmin();
    }
}
