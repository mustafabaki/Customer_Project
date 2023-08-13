using Employee_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
