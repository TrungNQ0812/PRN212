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
            Category condiments = new Category(2,"Condiments");
            Category confections = new Category(3, "Confections");
            Category dairy = new Category(4, "Dairy Products");
            Category grains = new Category(5, "Grains/Cereals");
            Category meat = new Category(6, "Meat/Poultry");
            Category produce = new Category(7, "Produce");
            Category seafood = new Category(8, "Seafood");

            var listCategory = new List<Category>();
            try
            {
                listCategory.Add(beverages);
                listCategory.Add(condiments);
                listCategory.Add(confections);
                listCategory.Add(dairy);
                listCategory.Add(grains);
                listCategory.Add(meat);
                listCategory.Add(produce);
                listCategory.Add(seafood);
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listCategory;
        }
    }
}
