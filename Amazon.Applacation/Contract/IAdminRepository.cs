using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Contract
{
    public interface IAdminRepository 
    {
        public bool ValidUniqueEmailAdmin(string email);
        public bool GetAdminEmailAndPassword(string email, string password);

        IQueryable<Admin> GetAllAdmin();

        Admin AddAdmin(Admin entity);
        bool ValidUniqueEmail(string email);
        int Save();
        void Delete(Admin admin);
      

    }
}
