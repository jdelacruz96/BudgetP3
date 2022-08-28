namespace BudgetAPI.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phone { get; set; }
        public string password { get; set; }

        public Customer(int customerId, string firstName, string lastName, int phone, string password)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.password = password;
        }
    }
}
