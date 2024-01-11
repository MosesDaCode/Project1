using ProjectLibrary.Build.Data;
using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes
{
    public class Parallelogram
    {
        public static void ParallelogramChoice()
        {
            using (var dbParallelo = new Project1Dbcontext())
            {
                DateOnly todaysDate = DateOnly.FromDateTime(DateTime.Now);
                double parBase;
                double parHeight;
                double parHypo;
                Console.WriteLine("Du har valt Parallellogram!" +
                    "\nFör att räkna ut area och omkrest för Parallollogram" +
                    "\nså behöver vi basen och höjden  i cm.");
                Console.WriteLine("Area för Parallollogram räknas: Bas * Höjd" +
                    "\nOmkretsen för Parallellogram räknas: (bas * 2) + (hypotenusa * 2)");

                do
                {
                    Console.Write("\n\nAnge Basen för Parallellogramet: ");
                    if (!double.TryParse(Console.ReadLine(),out parBase))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för basen av Parallellogramet!");
                    }
                    else if (parBase == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\n\nBra Jobbat!!!");
                        break;
                    }
                } while (true);

                do
                {
                    
                    Console.Write("Ange nu höjden för Parallellogramet: ");
                    if (!double.TryParse(Console.ReadLine(), out parHeight))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för höjden av Parallellogramet!");
                    }
                    else if (parHeight == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\n\nBra Jobbat!!!");
                        break;
                    }
                } while (true);

                do
                {
                    Console.WriteLine("\n\nBra Jobbat!!!");
                    Console.Write("Ange nu hypotenusan för Parallellogramet: ");
                    if (!double.TryParse (Console.ReadLine(), out parHypo))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för hypotenusan av Parallellogramet!");
                    }
                    else if (parHypo == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                Console.WriteLine("\nDu har angett");
                Console.WriteLine($"Bas: {parBase:F2} cm");
                Console.WriteLine($"Höjd: {parHeight:F2} cm");
                Console.WriteLine($"Hypotenusa: {parHypo:F2} cm");

                var parArea = parBase * parHeight;
                var parCircumference = (parBase * 2) + (parHypo * 2);

                var newPar = new ShapeGame()
                {
                    ShapeForm = "Parallellogram",
                    Base = parBase,
                    Height = parHeight,
                    Hypotenuse = parHypo,
                    Area = parArea,
                    Circumference = parCircumference,
                    Date = todaysDate
                };

                dbParallelo.Add(newPar);
                dbParallelo.SaveChanges();
                Console.WriteLine($"\nBra jobbat du har skapat en parallellogram med" +
                    $"\nArea: {parArea:F2} cm²" +
                    $"\nOmkrets: {parCircumference:F2} cm");
            }
        }
    }
}
