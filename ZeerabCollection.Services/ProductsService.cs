using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeerabCollection.Database;
using ZeerabCollection.Entities;

namespace ZeerabCollection.Services
{
    public class ProductsService
    {
        public Product GetProduct(int id)
        {
            using (var context = new ZRContext())
            {
                return context.Products.Find(id);
            }
        }
        public List<Product> GetProducts()
        {
            using (var context = new ZRContext())
            {
                return context.Products.ToList();
            }
        }
        public void SaveProduct(Product product)
        {
            using (var context = new ZRContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void UpdateProduct(Product product)
        {
            using (var context = new ZRContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteProduct(int ID)
        {
            using (var context = new ZRContext())
            {
                var product = context.Products.Find(ID);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }


    }
}
