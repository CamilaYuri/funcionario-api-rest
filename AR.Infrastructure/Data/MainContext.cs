using AR.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AR.Infrastructure.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<EmployeeCLT> EmployeeCLT { get; set; }
        public DbSet<EmployeePJ> EmployeePJ { get; set; }
    }
}
