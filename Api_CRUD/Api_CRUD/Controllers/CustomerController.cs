using Api_CRUD.Data;
using Microsoft.AspNetCore.Mvc;

namespace Api_CRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly CustomerDbContext dbContext;

        public CustomerController(CustomerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(dbContext.Customers.ToList());
        }
    }
}
