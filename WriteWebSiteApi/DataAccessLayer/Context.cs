using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WriteWebSiteApi.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-4QDRAGM\\ASUDEMOR; database=WriteWebSiteApi; integrated security=true;");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
