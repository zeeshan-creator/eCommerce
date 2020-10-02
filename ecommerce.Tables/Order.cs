using System;

namespace eCommerce.Tables
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public signUp user { get; set; }
        public Payment payment { get; set; }
        public Product product { get; set; }
        public long invoiceNumber { get; set; }
        public string orderStatus { get; set; }
    }
}