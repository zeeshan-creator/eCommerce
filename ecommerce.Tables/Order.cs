using System;

namespace eCommerce.Tables
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public signUp userID { get; set; }
        public Payment paymentID { get; set; }
        public Product productID { get; set; }
        public long invoiceNumber { get; set; }
        public string orderStatus { get; set; }
    }
}