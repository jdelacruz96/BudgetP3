namespace BudgetAPI.Data
{
    public class BudgetSQLRepo : IBudgetRepo
    {
        public readonly string _connectionString;

        private readonly ILogger<BudgetSQLRepo> _logger;

        public BudgetSQLRepo(string connectionString, ILogger<BudgetSQLRepo> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

    }
}
