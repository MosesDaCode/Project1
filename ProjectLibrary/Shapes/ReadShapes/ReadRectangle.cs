using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.ReadShapes
{
    public class ReadRectangle
    {
        public static void ReadingRectangle()
        {
            Console.Clear();

            using (var dbRecResult = new Project1Dbcontext())
            {
                var rectangleResults = dbRecResult.Shapes
                    .Where(r => r.ShapeForm == "Rektangel")
                    .ToList();
                if (rectangleResults.Any())
                {
                    Console.WriteLine("Visar resultat för Rektangel..." +
                                    "\n-------------------------------------------");

                    foreach (var rec in rectangleResults)
                    {
                        Console.WriteLine($"Form: {rec.ShapeForm}" +
                            $"\nForm Id: {rec.ShapeId}" +
                            $"\nBas: {rec.Base} cm" +
                            $"\nHöjd: {rec.Height} cm" +
                            $"\nOmkrets: {rec.Circumference} cm" +
                            $"\nArea: {rec.Area:F2} cm²" +
                            $"\nUträknad: {rec.Date}");
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
