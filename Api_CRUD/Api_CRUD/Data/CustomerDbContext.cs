using Api_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_CRUD.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<CustomerModel> Customers { get; set; }
    }
}
