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
    public class CategoryRepository : Repository<Category,int>, ICategoryRepository
    {

        public CategoryRepository(AmazonContext context) : base(context) { }


    }
}
