using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            Category beverages = new Category(1, "Beverages");
            Category condiments = new Category(2,"");
        }
    }
}
