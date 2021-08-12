using General.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.DataAccess.Concrete.EFCore
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GeneralDb;integrated security=true;MultipleActiveResultSets=true;");


        }
        public DbSet<ControlCenter> ControlCenters { get; set; }
        public virtual DbSet<CompanyService> CompanyService { get; set; }

    }
}
