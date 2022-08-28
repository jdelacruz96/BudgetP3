namespace BudgetAPI.Models
{
    public class Account
    {
        public int accountId { get; set; }
        public int type { get; set; }
        public float balance { get; set; }
        public int customerId { get; set; }

        public Account( int accountId, int type, float balance, int customerId)
        {
            this.accountId = accountId;
            this.type = type;
            this.balance = balance;
            this.customerId = customerId;
        }
    }
}
