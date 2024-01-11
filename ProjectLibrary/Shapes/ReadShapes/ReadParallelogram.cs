using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.ReadShapes
{
    public class ReadParallelogram
    {
        public static void ReadingParallelogram()
        {
            Console.Clear();

            using (var dbParResult = new Project1Dbcontext())
            {
                var parallelResults = dbParResult.Shapes
                    .Where(p => p.ShapeForm == "Parallellogram")
                    .ToList();
                if (parallelResults.Any())
                {
                    Console.WriteLine("Visar resultat för Parallellogram..." +
                                    "\n-------------------------------------------");

                    foreach (var par in parallelResults)
                    {
                        Console.WriteLine($"Form: {par.ShapeForm}" +
                            $"\nBas: {par.Base} cm" +
                            $"\nHöjd: {par.Height} cm" +
                            $"\nHypotenusa: {par.Hypotenuse} cm" +
                            $"\nOmkrets: {par.Circumference} cm" +
                            $"\nArea: {par.Area:F2} cm²" +
                            $"\nUträknad: {par.Date}");
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