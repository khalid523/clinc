using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace clinicSystem2102.data
{
    public class ClinicContext:DbContext
    {
        IConfiguration config;
        public ClinicContext(IConfiguration _config)
        {
            config = _config;
        }
        public DbSet<Country> countries { set; get; }
        public DbSet<patient> patients { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("Clinicconnection"));
           // optionsBuilder.UseSqlServer("data source=localhost;integrated security=true;initial catalog=ClinicDbDemo2102");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
