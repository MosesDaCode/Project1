using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Build.Service
{
    public class ConfigBuilder
    {
        public void BuildDb()
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile($"appsettings.json", true, true);
            var config = builder.Build();

            var options = new DbContextOptionsBuilder<Project1Dbcontext>();
            var connectionString = config.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString);

            using (var dbContext = new Project1Dbcontext(options.Options))
            {
                var dataInitiaizer = new Project1Initializer();
                dataInitiaizer.MigrateAndSeed(dbContext);
            }
        }
    }
}
