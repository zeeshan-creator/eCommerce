using ecommerce.Tables;
using eCommerce.Tables;
using System.Data.Entity;

namespace eCommerce.Database
{
    internal class databaseContext : DbContext
    {
        public databaseContext() : base("eCommerceDatabaseConnection")
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<subCategory> subCategory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<signUp> signUp { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<admin> admin { get; set; }
    }
}