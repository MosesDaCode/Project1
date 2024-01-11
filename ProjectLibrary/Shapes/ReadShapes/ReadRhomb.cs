using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.ReadShapes
{
    public class ReadRhomb
    {
        public static void ReadingRhomb()
        {
            Console.Clear();

            using (var dbRhombResult = new Project1Dbcontext())
            {
                var rhombResults = dbRhombResult.Shapes
                    .Where(r => r.ShapeForm == "Romb")
                    .ToList();
                if (rhombResults.Any())
                {
                    Console.WriteLine("Visar resultat för Rektangel..." +
                                    "\n-------------------------------------------");

                    foreach (var rhomb in rhombResults)
                    {
                        Console.WriteLine($"Form: {rhomb.ShapeForm}" +
                            $"\nBas: {rhomb.Base} cm" +
                            $"\nHöjd: {rhomb.Height} cm" +
                            $"\nOmkrets: {rhomb.Circumference} cm" +
                            $"\nArea: {rhomb.Area:F2} cm²" +
                            $"\nUträknad: {rhomb.Date}");
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
