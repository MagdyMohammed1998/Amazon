﻿using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Contract
{
    public interface ICategoryRepository : Irepository<Category , int>
    {



        IQueryable <Category> SearchByName(string name);




    }
}
