using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.ReadShapes
{
    public class ReadTriangle
    {
        public static void ReadingTriangle()
        {
            Console.Clear();

            using (var dbParResult = new Project1Dbcontext())
            {
                var triangleResults = dbParResult.Shapes
                    .Where(t => t.ShapeForm == "Triangel")
                    .ToList();
                if (triangleResults.Any())
                {
                    Console.WriteLine("Visar resultat för Triangel..." +
                                    "\n-------------------------------------------");

                    foreach (var tri in triangleResults)
                    {
                        Console.WriteLine($"Form: {tri.ShapeForm}" +
                            $"\nForm Id: {tri.ShapeId}" +
                            $"\nBas: {tri.Base} cm" +
                            $"\nHöjd: {tri.Height} cm" +
                            $"\nKatet 1: {tri.CathetusOne} cm" +
                            $"\nKatet 2: {tri.CathetusTwo} cm" +
                            $"\nOmkrets: {tri.Circumference} cm" +
                            $"\nArea: {tri.Area:F2} cm²" +
                            $"\nUträknad: {tri.Date}");
                        Console.WriteLine("-------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Inga resultat hittades...");
                }
            }
        }
    }
}
