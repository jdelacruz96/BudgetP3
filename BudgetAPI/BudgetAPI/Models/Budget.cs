namespace BudgetAPI.Models
{
    public class Budget
    {
        public int budgetId { get; set; }
        public int customerId { get; set; }
        public int accountId { get; set; }
        public float monthlyAmount { get; set; }
        public float warningAmount  { get; set; }
        public DateTime time { get; set; }

        public Budget(int budgetId, int customerId, int accountId, float monthlyAmount, float warningAmount, DateTime time)
        {
            this.budgetId = budgetId;
            this.customerId = customerId;
            this.accountId = accountId;
            this.monthlyAmount = monthlyAmount;
            this.warningAmount = warningAmount;
            this.time = time;
        }

    }
}
