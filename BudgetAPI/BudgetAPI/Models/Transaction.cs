namespace BudgetAPI.Models
{
    public class Transaction
    {
        public int transactionId { get; set; }
        public int accountId { get; set; }
        public DateTime time { get; set; }
        public float amount { get; set; }
        public Boolean type { get; set; }

        public Transaction(int transactionId, int accountId, DateTime time, float amount, bool type)
        {
            this.transactionId = transactionId;
            this.accountId = accountId;
            this.time = time;
            this.amount = amount;
            this.type = type;
        }
    }
}
