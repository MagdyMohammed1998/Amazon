using Amazon.Applacation.Contract;
using Amazon.Context;
using Amazon.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category,int>, ICategoryRepository
    {
        AmazonContext _Context;
        public CategoryRepository(AmazonContext context) : base(context)
        {
            _Context = context;
        }

        public IQueryable <Category> SearchByName(string name)
        {
            return _Context.Categories.Where(p => p.Name.Contains(name));
        }
    }
}
