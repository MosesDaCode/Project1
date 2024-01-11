using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.ReadShapes
{
    public class ReadAllShapes
    {
        public static void ReadingAllShapes()
        {
            Console.Clear();
            Console.WriteLine("Visar alla resultat..." +
                "\n-------------------------------------------");
            using (var dbAllShapesRead = new Project1Dbcontext())
            {
                var shapeResults = dbAllShapesRead.Shapes.ToList();
                if (shapeResults.Any())
                {
                    Console.WriteLine("Visar alla resultat..." +
                "\n-------------------------------------------");

                foreach (var shape in shapeResults)
                    {
                        Console.WriteLine($"Form: {shape.ShapeForm}" +
                            $"\nBas: {shape.Base} cm" +
                            $"\nLängd: {shape.Height} cm" +
                            $"\nKatet 1: {shape.CathetusOne} cm" +
                            $"\nKatet 2: {shape.CathetusTwo} cm" +
                            $"\nHypotenusa: {shape.Hypotenuse} cm" +
                            $"\nOmkrets: {shape.Circumference} cm" +
                            $"\nArea: {shape.Area} cm²" +
                            $"\nUträknad: {shape.Date}");
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
