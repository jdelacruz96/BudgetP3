using BudgetAPI.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BudgetAPI.Controllers
{
    [EnableCors("_myAllowSpecificOrigins")]
    [Route("api/budget")]
    [ApiController]
    public class BudgetController : ControllerBase
    {
        private readonly IBudgetRepo _repo;
        private readonly ILogger<BudgetController> _logger;

        public BudgetController(IBudgetRepo repo, ILogger<BudgetController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        //CRUD METHODS
        //GET BUDGET


        //GET BUDGETS FOR ALL CUSTOMER ACCOUNT

        //POST BUDGET 

        //PUT BUDGET

        //DELETE BUDGET

    }
}
