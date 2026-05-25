using System.Collections.Generic;
using System.Linq;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        public static List<Product> GetProducts()
        {
            using var context = new MyStoreContext();
            return context.Products.Include(p => p.Category).ToList();
        }

        public static Product GetProductById(int id)
        {
            using var context = new MyStoreContext();
            return context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductID == id);
        }

        public static void SaveProduct(Product p)
        {
            using var context = new MyStoreContext();
            context.Products.Add(p);
            context.SaveChanges();
        }

        public static void UpdateProduct(Product p)
        {
            using var context = new MyStoreContext();
            context.Products.Update(p);
            context.SaveChanges();
        }

        public static void DeleteProduct(Product p)
        {
            using var context = new MyStoreContext();
            context.Products.Remove(p);
            context.SaveChanges();
        }
    }
}
