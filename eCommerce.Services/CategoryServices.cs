using System;
using System.Collections.Generic;
using eCommerce.Database;
using eCommerce.Tables;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Data.Entity;

namespace eCommerce.Services
{
    public class CategoryServices
    {
        databaseContext db = new databaseContext();

        public void createCategory(Category data)
        {
            db.Category.Add(data);
            db.SaveChanges();
        }

        public List<Category> getCategory()
        {
            List<Category> categories = db.Category.ToList();
            return categories;
        }

        public Category getCategory(int? id)
        {
            Category category = db.Category.Find(id);
            return category;
        }

        public void updateCategory(Category data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void deleteCategory(int? id)
        {
            Category category = db.Category.Find(id);
            db.Category.Remove(category);
            db.SaveChanges();
        }
    }
}
