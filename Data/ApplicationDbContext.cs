using Microsoft.EntityFrameworkCore;
using MiniErp.MultiTenant.Entities;

namespace MiniErp.MultiTenant.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
