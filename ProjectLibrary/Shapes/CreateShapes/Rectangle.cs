using ProjectLibrary.Build.Data;
using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.CreateShapes
{
    public class Rectangle
    {
        public static void RectangleChoice()
        {
            using (var dbRectangle = new Project1Dbcontext())
            {
                DateOnly todaysDate = DateOnly.FromDateTime(DateTime.Now);
                double recBase;
                double recHeight;
                Console.WriteLine("Du har valt Rektangel!" +
                    "\nFör att räkna ut area och omkrest för Rektangeln" +
                    "\nså behöver vi basen och höjden i cm.");
                Console.WriteLine("Area för Rektangeln räknas: Bas * Höjd" +
                    "\nOmkretsen för Rektangeln räknas: (bas * 2) + (höjd * 2)" +
                    "\n\nAnnars ange 0 för att gå tillbaka...");

                do
                {
                    Console.Write("\n\nAnge basen för Rektangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out recBase))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för basen av rektangeln!");
                    }
                    else if (recBase == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                do
                {
                    Console.WriteLine("\n\nBra Jobbat!!!");
                    Console.Write("Ange Höjden för Rektangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out recHeight))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för höjden av rektangeln!");
                    }
                    else if (recHeight == 0)
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
                Console.WriteLine($"Bas: {recBase:F2} cm");
                Console.WriteLine($"Höjd: {recHeight:F2} cm");

                var recArea = recBase * recHeight;
                var recCircumference = recBase * 2 + recHeight * 2;

                var newRec = new ShapeGame()
                {
                    ShapeForm = "Rektangel",
                    Base = recBase,
                    Height = recHeight,
                    Area = recArea,
                    Circumference = recCircumference,
                    Date = todaysDate
                };
                dbRectangle.Add(newRec);
                dbRectangle.SaveChanges();
                Console.WriteLine($"\nBra jobbat du har skapat en rektangel med" +
                    $"\nArea: {recArea:F2} cm²" +
                    $"\nOmkrets: {recCircumference:F2} cm");
            }
        }
    }
}
