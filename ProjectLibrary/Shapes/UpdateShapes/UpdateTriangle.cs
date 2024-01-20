using ProjectLibrary.Build.Service;
using ProjectLibrary.Shapes.ReadShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.UpdateShapes
{
    public class UpdateTriangle
    {
        public static void EditTriangle()
        {
            ReadTriangle.ReadingTriangle();

            using (var dbEditTri = new Project1Dbcontext())
            {
               
                int triId;
                double newTriBase;
                double newTriHeight;
                double newCathetusOne;
                double newCathetusTwo;

                do
                {
                    Console.Write("\nAnge Id för Triangel resultatet som ska ändras" +
                        "\nID: ");
                    if (!int.TryParse(Console.ReadLine(), out triId))
                    {
                        Console.WriteLine("\nDu måste ange ett ID för Triangeln" +
                            "som ska ändras.");
                    }
                    else if (triId == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        var shapeType = dbEditTri.Shapes
                            .Where(t => t.ShapeId == triId)
                            .Select(t => t.ShapeForm)
                            .FirstOrDefault();
                        if (shapeType == "Triangel")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Angivet ID: {triId} existerar inte...");
                        }
                    }
                } while (true);

                Console.Clear();
                var triToEdit = dbEditTri.Shapes
                   .Find(triId);

                Console.WriteLine($"Redigerar Triangel ID: {triId}..." +
                   "\n..................................\n");

                if (triToEdit == null)
                {
                    Console.WriteLine($"\nTriangel med id {triToEdit} " +
                        $"existerar inte.");
                }

                do
                {
                    Console.Write("\nAnge en ny Bas för Triangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out newTriBase))
                    {
                        Console.WriteLine("\nDu måste ange en ny bas i form av siffror!");
                    }
                    else if (newTriBase == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nBra jobbat!!!");
                        break;
                    }
                } while (true);

                do
                {
                    Console.Write("Ange en ny Höjd för Rektangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out newTriHeight))
                    {
                        Console.WriteLine("\nDu måste ange en ny höjd i form av siffror!");
                    }
                    else if (newTriHeight == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nBra jobbat!!!");
                        break;
                    }
                } while (true);

                do
                {
                    Console.Write("Ange en ny första katet för Rektangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out newCathetusOne))
                    {
                        Console.WriteLine("\nDu måste ange en ny höjd i form av siffror!");
                    }
                    else if (newCathetusOne == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nBra jobbat!!!");
                        break;
                    }
                } while (true);

                do
                {
                    Console.Write("Ange en ny andra katet för Rektangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out newCathetusTwo))
                    {
                        Console.WriteLine("\nDu måste ange en ny höjd i form av siffror!");
                    }
                    else if (newCathetusTwo == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nBra jobbat!!!");
                        break;
                    }
                } while (true);


                var newTriArea = (newTriBase * newTriHeight) / 2;
                var newTriCircumference = newTriBase + newCathetusOne + newCathetusTwo;

                Console.WriteLine($"\nDu har angett nya värden" +
                    $"\nNy Bas: {newTriBase:F2} cm" +
                    $"\nNy Höjd: {newTriHeight:F2} cm" +
                    $"\nNy Katet 1: {newCathetusOne} cm" +
                    $"\nNy Katet 2: {newCathetusTwo} cm");


                triToEdit.Base = newTriBase;
                triToEdit.Height = newTriHeight;
                triToEdit.CathetusOne = newCathetusOne;
                triToEdit.CathetusTwo = newCathetusTwo;
                triToEdit.Area = newTriArea;
                triToEdit.Circumference = newTriCircumference;
                triToEdit.EditDate = DateOnly.FromDateTime(DateTime.Now);

                dbEditTri.SaveChanges();


                Console.WriteLine($"\n\nNy uträknad Omkrets: {newTriCircumference} cm" +
                    $"\nNy uträknad Area: {newTriArea} cm²");
            }
        }
    }
}
