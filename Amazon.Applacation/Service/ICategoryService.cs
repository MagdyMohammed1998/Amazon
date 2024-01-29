using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Service
{
    public interface ICategoryService
    {
        public Category Add(Category category);

        public Category Update(Category category);

        public void Delete(Category category);

        public Category GetById(int id);

        public IQueryable<Category> GetAll();




    }
}
