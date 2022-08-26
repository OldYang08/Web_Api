using Api_CRUD.Data;
using Api_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> GetCustomers()
        {
            return Ok(await dbContext.Customers.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomers(AddModel addModel)
        {
            var customer = new CustomerModel()
            {
                Id = Guid.NewGuid(),
                Name = addModel.Name,
                Email = addModel.Email,
            };

            await dbContext.Customers.AddAsync(customer);
            await dbContext.SaveChangesAsync();

            return Ok(customer);
        }
    }
}
