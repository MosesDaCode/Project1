using ProjectLibrary.Build.Data;
using ProjectLibrary.Build.Service;
using ProjectLibrary.Shapes.ReadShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.UpdateShapes
{
    public class UpdateRectangle
    {
        public static void EditRectangle()
        {
            ReadRectangle.ReadingRectangle();

            using (var dbEditRec = new Project1Dbcontext())
            {
                int recId;
                double newRecBase;
                double newRecHeight;
                
                do
                {
                    Console.Write("\nAnge Id för Rektangel resultatet som ska ändras" +
                        "\nID: ");
                    if (!int.TryParse(Console.ReadLine(), out recId))
                    {
                        Console.WriteLine("\nDu måste ange ett ID för Rektangeln" +
                            "som ska ändras.");
                    }
                    else if (recId == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        var shapeType = dbEditRec.Shapes
                            .Where(s => s.ShapeId == recId)
                            .Select(s => s.ShapeForm)
                            .FirstOrDefault();
                        if (shapeType == "Rektangel")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Angivet ID: {recId} existerar inte...");
                        }
                    }
                } while (true);

                var recToEdit = dbEditRec.Shapes
                   .Find(recId);

                if (recToEdit == null)
                {
                    Console.WriteLine($"\nRektangel med id {recToEdit} " +
                        $"existerar inte.");
                }

                do
                {
                    Console.Write("\nAnge en ny Bas för Rektangeln: ");
                    if (!double.TryParse(Console.ReadLine(), out newRecBase))
                    {
                        Console.WriteLine("\nDu måste ange en ny bas i form av siffror!");
                    }
                    else if (newRecBase == 0)
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
                    if (!double.TryParse(Console.ReadLine(), out newRecHeight))
                    {
                        Console.WriteLine("\nDu måste ange en ny höjd i form av siffror!");
                    }
                    else if (newRecHeight == 0)
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

                var newRecArea = newRecBase * newRecHeight;
                var newRecCircumference = (newRecBase * 2) + (newRecHeight * 2);

                Console.WriteLine($"\nDu har angett nya värden" +
                    $"\nNy Bas: {newRecBase:F2} cm" +
                    $"\nNy Höjd: {newRecHeight:F2} cm");

                
                recToEdit.Base = newRecBase;
                recToEdit.Height = newRecHeight;
                recToEdit.Area = newRecArea;
                recToEdit.Circumference = newRecCircumference;
                recToEdit.EditDate = DateOnly.FromDateTime(DateTime.Now);

                dbEditRec.SaveChanges();


                Console.WriteLine($"\n\nNy uträknad Omkrets: {newRecCircumference} cm" +
                    $"\nNy uträknad Area: {newRecArea} cm²");
            }
        }
    }
}
