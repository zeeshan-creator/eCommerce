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
    public class subCategoryServices
    {
        databaseContext db = new databaseContext();

        public void createsubCategory(subCategory data)
        {
            db.subCategory.Add(data);
            db.SaveChanges();
        }

        public List<subCategory> getsubCategory()
        {
            List<subCategory> subCategorys = db.subCategory.ToList();
            return subCategorys;
        }

        public subCategory getsubCategory(int? id)
        {
            subCategory subCategory = db.subCategory.Find(id);
            return subCategory;
        }

        public void updatesubCategory(subCategory data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void deletesubCategory(int? id)
        {
            subCategory subCategory = db.subCategory.Find(id);
            db.subCategory.Remove(subCategory);
            db.SaveChanges();
        }
    }
}
