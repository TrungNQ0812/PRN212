using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Repositories
{
    public class CategoryRepository : ICategotyRepository
    {
        public List<Category> GetCategories() => CategoryDAO.GetCategories();
    }
}
