using Amazon.Applacation.Contract;
using Amazon.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Applacation.Service
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public Category Add(Category category)
        {
            var Data = _categoryRepository.Add(category);
            _categoryRepository.Save();
            return Data;
        }

        public void Delete(Category category)
        {
            if(category != null)
            {
                _categoryRepository.Delete(category);
                _categoryRepository.Save();

            }
            else
            {
                throw new Exception("Category Not Found!");
            }
        }

        public List<Category> GetAll()
        {
            var Data = _categoryRepository.GetALL();
            _categoryRepository.Save();
            return Data;
        }

        public Category GetById(int id)
        {
            if(id != 0)
            {
                var Data = _categoryRepository.GetById(id);
                _categoryRepository.Save();
                return Data;
            }
            else
            {
                throw new Exception("Not Found:");
            }
        }

        public Category Update(Category category)
        {
            var Data = _categoryRepository.Update(category);
            _categoryRepository.Save();
            return Data;
        }




        public List<Category> SearchByName(string name)
        {
            var Data = _categoryRepository.SearchByName(name);
            _categoryRepository.Save();
            return Data;
        }









    }
}
