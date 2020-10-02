namespace eCommerce.Tables
{
    public class Product : baseEntities
    {
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public subCategory subCategory { get; set; }
    }
}