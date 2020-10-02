namespace eCommerce.Tables
{
    public class Payment
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string creditCard { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string zipCode { get; set; }
        public string Status { get; set; }
    }
}