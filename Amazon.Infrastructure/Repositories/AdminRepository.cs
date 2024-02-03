using Amazon.Applacation.Contract;
using Amazon.Context;
using Amazon.Models.Models;
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
        public AdminRepository(AmazonContext context) 
        {
            _Context = context;
        }


        public bool ValidUniqueEmailAdmin(string email)
        {
            return !_Context.Admins.Any(admin => admin.Email == email);
        }

        public bool GetAdminEmailAndPassword(string email, string password)
        {
            return _Context.Admins.Any(admin=>admin.Email == email && admin.Password == password);
        }
    }
}
