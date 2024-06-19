using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using DataAccessLayer;
using Repositories;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository iCategoryRepository;
        public CategoryService() {
            iCategoryRepository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
           return iCategoryRepository.GetCategories();
        }
    }
}
