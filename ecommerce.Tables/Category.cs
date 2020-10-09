using System.Collections.Generic;

namespace eCommerce.Tables
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<subCategory> subCategories { get; set; }

    }
}