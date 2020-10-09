using System.Collections.Generic;

namespace eCommerce.Tables
{
    public class subCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int categoryID { get; set; }


        public virtual ICollection<Product> Products { get; set; }

        public Category category { get; set; }
    }
}