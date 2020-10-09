namespace eCommerce.Tables
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int subCategoryID { get; set; }
        public virtual subCategory subCategory { get; set; }
    }
}