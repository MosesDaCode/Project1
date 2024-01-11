using ProjectLibrary.Build.Data;
using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes
{
    public class Rhomb
    {
        public static void RhombChoice()
        {
            using (var dbRomb = new Project1Dbcontext())
            {
                DateOnly todaysDate = DateOnly.FromDateTime(DateTime.Now);
                double rombBase;
                double rombHeight;
                
                Console.WriteLine("Du har valt Romb!" +
                    "\nFör att räkna ut area och omkrest för Romben" +
                    "\nså behöver vi basen och höjden i cm.");
                Console.WriteLine("Area för Romben räknas: Bas * Höjd" +
                    "\nOmkretsen för Romben räknas: bas * 4");

                do
                {
                    Console.Write("\n\nAnge basen för Romben: ");
                    if (!double.TryParse(Console.ReadLine(), out rombBase))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för basen av Romben!");
                    }
                    else if (rombBase == 0)
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
                    Console.Write("\n\nAnge höjden för Romben: ");
                    if (!double.TryParse(Console.ReadLine(), out rombHeight))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för höjden av Romben!");
                    }
                    else if (rombHeight == 0)
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
                Console.WriteLine($"Bas: {rombBase:F2} cm");
                Console.WriteLine($"Höjd: {rombHeight:F2} cm");

                var rombArea = rombBase * rombHeight;
                var rombCircumference = rombBase * 4;

                var newRomb = new ShapeGame()
                {
                    ShapeForm = "Triangel",
                    Base = rombBase,
                    Height = rombHeight,
                    Area = rombArea,
                    Circumference = rombCircumference,
                    Date = todaysDate
                };

                dbRomb.Add(newRomb);
                dbRomb.SaveChanges();
                Console.WriteLine($"\nBra jobbat du har skapat en rektangel med" +
                    $"\nArea: {rombArea:F2} cm²" +
                    $"\nOmkrets: {rombCircumference:F2} cm");
            }
        }
    }
}
