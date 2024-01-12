using ProjectLibrary.Build.Service;
using ProjectLibrary.Shapes.ReadShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.UpdateShapes
{
    public class UpdateRhomb
    {
        public static void EditRhomb()
        {
            ReadRhomb.ReadingRhomb();

            using (var dbEditRhomb = new Project1Dbcontext())
            {
                int rhombId;
                double newRhombBase;
                double newRhombHeight;

                do
                {
                    Console.Write("\nAnge Id för Romb resultatet som ska ändras" +
                        "\nID: ");
                    if (!int.TryParse(Console.ReadLine(), out rhombId))
                    {
                        Console.WriteLine("\nDu måste ange ett ID för Romben" +
                            "som ska ändras.");
                    }
                    else if (rhombId == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        var shapeType = dbEditRhomb.Shapes
                            .Where(t => t.ShapeId == rhombId)
                            .Select(t => t.ShapeForm)
                            .FirstOrDefault();
                        if (shapeType == "Romb")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Angivet ID: {rhombId} existerar inte...");
                        }
                    }
                } while (true);

                var RhombToEdit = dbEditRhomb.Shapes
                   .Find(rhombId);

                if (RhombToEdit == null)
                {
                    Console.WriteLine($"\nRomb med id {RhombToEdit} " +
                        $"existerar inte.");
                }

                do
                {
                    Console.Write("\nAnge en ny Bas för Romben: ");
                    if (!double.TryParse(Console.ReadLine(), out newRhombBase))
                    {
                        Console.WriteLine("\nDu måste ange en ny bas i form av siffror!");
                    }
                    else if (newRhombBase == 0)
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
                    Console.Write("Ange en ny Höjd för Romben: ");
                    if (!double.TryParse(Console.ReadLine(), out newRhombHeight))
                    {
                        Console.WriteLine("\nDu måste ange en ny höjd i form av siffror!");
                    }
                    else if (newRhombHeight == 0)
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

                var newRhombArea = newRhombBase * newRhombHeight;
                var newRhombCircumference = newRhombBase * 4;

                Console.WriteLine($"\nDu har angett nya värden" +
                    $"\nNy Bas: {newRhombBase:F2} cm" +
                    $"\nNy Höjd: {newRhombHeight:F2} cm");


                RhombToEdit.Base = newRhombBase;
                RhombToEdit.Height = newRhombHeight;
                RhombToEdit.Area = newRhombArea;
                RhombToEdit.Circumference = newRhombCircumference;
                RhombToEdit.EditDate = DateOnly.FromDateTime(DateTime.Now);

                dbEditRhomb.SaveChanges();


                Console.WriteLine($"\n\nNy uträknad Omkrets: {newRhombCircumference} cm" +
                    $"\nNy uträknad Area: {newRhombArea} cm²");
            }
        }
    }
}
