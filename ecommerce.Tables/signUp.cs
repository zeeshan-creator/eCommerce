namespace eCommerce.Tables
{
    public class signUp : baseEntities
    {
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string Password { get; set; }
        public string repeatPassword { get; set; }
        public long phoneNumber { get; set; }
    }
}