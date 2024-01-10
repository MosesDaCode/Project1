using Microsoft.EntityFrameworkCore;
using ProjectLibrary.Build.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Build.Service
{
    public class Project1Initializer
    {
        public void MigrateAndSeed(Project1Dbcontext dbContext)
        {
            dbContext.Database.Migrate();
            SeedShapes(dbContext);
            dbContext.SaveChanges();
        }
        private void SeedShapes(Project1Dbcontext dbContext)
        {
            if (!dbContext.Shapes.Any(s => s.ShapeId == 1))
            {
                dbContext.Shapes.Add(new ShapeGame
                {
                    ShapeForm = "Rektangel",
                    Base = 6,
                    Height = 4,
                    Area = 6 * 4,
                    Circumference = (6*2) + (4*2),
                    Date = DateOnly.FromDateTime(DateTime.Now)
                });
            }
            if (!dbContext.Shapes.Any(s => s.ShapeId == 2))
            {
                dbContext.Shapes.Add(new ShapeGame
                {
                    ShapeForm = "Parallellogram",
                    Base = 32,
                    Height = 25,
                    Hypotenuse = 29,
                    Area = 32 * 25,
                    Circumference = (32 * 2) + (29 * 2),
                    Date = DateOnly.FromDateTime(DateTime.Now)
                });
            }
            if (!dbContext.Shapes.Any(s => s.ShapeId == 3))
            {
                dbContext.Shapes.Add(new ShapeGame
                {
                    ShapeForm = "Triangel",
                    Base = 12,
                    Height = 15,
                    CathetusOne = 8,
                    CathetusTwo = 10,
                    Area = 12 * 15 / 2,
                    Circumference = 12 + 8 + 10,
                    Date = DateOnly.FromDateTime(DateTime.Now)
                });
            }
            if (!dbContext.Shapes.Any(s => s.ShapeId == 4))
            {
                dbContext.Shapes.Add(new ShapeGame
                {
                    ShapeForm = "Romb",
                    Base = 13,
                    Height = 16,
                    Area = 13 * 16,
                    Circumference = 13 * 4,
                    Date = DateOnly.FromDateTime(DateTime.Now)
                });
            }
        }
    }
}
