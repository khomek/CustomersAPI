using CustomerAdminPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerAdminPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
       

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

    }
} 
