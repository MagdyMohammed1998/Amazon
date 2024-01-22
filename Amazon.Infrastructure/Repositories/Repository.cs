using Amazon.Applacation.Contract;
using Amazon.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Infrastructure.Repositories
{
    public class Repository<T, Tid> : Irepository<T, Tid> where T : class
    {

        AmazonContext _Context;
        DbSet<T> SetEntity;


        public Repository(AmazonContext context)
        {
            _Context = context;
            SetEntity = context.Set<T>();
        }

        public T Add(T entity)
        {
            return SetEntity.Add(entity).Entity;
        }

        public void Delete(T entity)
        {
            if(entity != null)
            {
                SetEntity.Remove(entity);
            }
            else
            {
                throw new Exception("Not Found!");

            }
        }

        public List<T> GetALL()
        {
            return SetEntity.ToList();
        }

        public T GetById(Tid id)
        {
            return SetEntity.Find(id);
        }

        public T Update(T entity)
        {
            return SetEntity.Update(entity).Entity;
        }




        public int Save()
        {
            return _Context.SaveChanges();
        }






    }
}
