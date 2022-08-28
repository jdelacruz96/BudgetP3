using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using BudgetAPI.Models;

namespace BudgetAPI.Data
{
    public class BudgetSQLRepo : IBudgetRepo
    {
        //Fields
        public readonly string _connectionString;

        private readonly ILogger<BudgetSQLRepo> _logger;

        public BudgetSQLRepo(string connectionString, ILogger<BudgetSQLRepo> logger)
        {
            _connectionString = connectionString;
            _logger = logger;
        }

        //Methods

        //Get one budget by acount_id

        //Get all budgets for a customer

        //Post new budget

        //Put budget to update a budget

        //Delete a budget, by acountId

    }
}
