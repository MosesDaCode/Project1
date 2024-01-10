using Microsoft.EntityFrameworkCore;
using ProjectLibrary.Build.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Build.Service
{
    public class Project1Dbcontext : DbContext
    {
        public DbSet<ShapeGame> Shapes { get; set; }
        public DbSet<Calculator> Calculators { get; set; }
        public DbSet<RPS> RockPaperScissor { get; set; }
        public Project1Dbcontext()
        {
        }
        public Project1Dbcontext(DbContextOptions<Project1Dbcontext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Project1Db;Trusted_Connection=True;");
        }
    }
}
