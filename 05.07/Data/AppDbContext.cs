using _05._07.Models;
using Microsoft.EntityFrameworkCore;

namespace _05._07.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Service> Services { get; set; }
    }
}
