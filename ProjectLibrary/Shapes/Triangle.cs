using ProjectLibrary.Build.Data;
using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes
{
    public class Triangle
    {
        public static void TriangleChoice()
        {
            using (var dbTriangle = new Project1Dbcontext())
            {
                DateOnly todaysDate = DateOnly.FromDateTime(DateTime.Now);
                double triBase;
                double triHeight;
                double triCatOne;
                double triCatTwo;
                Console.WriteLine("Du har valt Triangel!" +
                    "\nFör att räkna ut area och omkrest för Triangeln" +
                    "\nså behöver vi basen och höjden i cm.");
                Console.WriteLine("Area för Rektangeln räknas: Bas * Höjd / 2" +
                    "\nOmkretsen för Rektangeln räknas: bas + katet + katet");

                do
                {
                    Console.Write("\n\nAnge basen för Triangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out triBase))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för basen av Triangeln!");
                    }
                    else if (triBase == 0)
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
                    Console.Write("\n\nAnge höjden för Triangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out triHeight))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för höjden av Triangeln!");
                    }
                    else if (triHeight == 0)
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
                    Console.Write("\n\nAnge första kateten för Triangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out triCatOne))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för den första kateten av Triangeln!");
                    }
                    else if (triCatOne == 0)
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
                    Console.Write("\n\nAnge första kateten för Triangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out triCatTwo))
                    {
                        Console.WriteLine("\nDu måste ange ett nummer för den andra kateten av Triangeln!");
                    }
                    else if (triCatTwo == 0)
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

                Console.WriteLine("\nDu har angett");
                Console.WriteLine($"Bas: {triBase:F2} cm");
                Console.WriteLine($"Höjd: {triHeight:F2} cm");
                Console.WriteLine($"Katet 1: {triCatOne:F2} cm");
                Console.WriteLine($"Katet 2: {triCatTwo:F2} cm");

                var triArea = (triBase * triHeight) / 2;
                var triCircumference = triBase + triCatOne + triCatTwo;

                var newTriangle = new ShapeGame()
                {
                    ShapeForm = "Triangel",
                    Base = triBase,
                    Height = triHeight,
                    CathetusOne = triCatOne,
                    CathetusTwo = triCatTwo,
                    Area = triArea,
                    Circumference = triCircumference,
                    Date = todaysDate
                };

                dbTriangle.Add(newTriangle);
                dbTriangle.SaveChanges();
                Console.WriteLine($"\nBra jobbat du har skapat en rektangel med" +
                    $"\nArea: {triArea:F2} cm²" +
                    $"\nOmkrets: {triCircumference:F2} cm");
            }
        }
    }
}
