using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        public static List<Category> GetCategories()
        {
            using var context = new MyStoreContext();
            return context.Categories.ToList();
        }
    }
}
