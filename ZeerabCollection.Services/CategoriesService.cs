using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeerabCollection.Database;
using ZeerabCollection.Entities;

namespace ZeerabCollection.Services
{
    public class CategoriesService
    {
        public Category GetCategoryId(int id)
        {
            using (var context = new ZRContext())
            {
                return context.Categories.Find(id);
            }
        }
        public List<Category> GetCategories()
        {
            using (var context = new ZRContext())
            {
                return context.Categories.ToList();
            }
        }
        public void SaveCategory(Category category)
        {
            using (var context = new ZRContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
        public void UpdateCategory(Category category)
        {
            using (var context = new ZRContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteCategory(int ID)
        {
            using (var context = new ZRContext())
            {
                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }


    }
}
