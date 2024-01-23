using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Contract
{
    public interface Irepository<T,Tid>
    {

        List<T> GetALL();

        T GetById(Tid id);

        T Add(T entity);

        T Update(T entity);

        void Delete(T entity);

        public int Save();


    }
}
