using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Infrastructure.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) 
            : base(options)
        {
        }

        //public DbSet<FuncionarioCLT> FuncionarioCLT { get; set; }
        //public DbSet<FuncionarioPJ> FuncionarioPJ { get; set; }
    }
}
