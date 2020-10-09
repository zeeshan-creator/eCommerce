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
    public class ProductServices
    {
        databaseContext db = new databaseContext();

        public void createProduct(Product data)
        {
            db.Product.Add(data);
            db.SaveChanges();
        }

        public List<Product> getProduct()
        {
            List<Product> products = db.Product.ToList();
            return products;
        }

        public Product getProduct(int? id)
        {
            Product Product = db.Product.Find(id);
            return Product;
        }

        public void updateProduct(Product data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void deleteProduct(int? id)
        {
            Product Product = db.Product.Find(id);
            db.Product.Remove(Product);
            db.SaveChanges();
        }
    }
}
