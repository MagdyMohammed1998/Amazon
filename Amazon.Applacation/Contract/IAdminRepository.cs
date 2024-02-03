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
        public Admin GetAdminByEmail(string email);
    }
}
