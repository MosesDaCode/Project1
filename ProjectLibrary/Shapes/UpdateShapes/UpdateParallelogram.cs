using ProjectLibrary.Build.Service;
using ProjectLibrary.Shapes.ReadShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.UpdateShapes
{
    public class UpdateParallelogram
    {
        public static void EditParallelogram()
        {
            ReadParallelogram.ReadingParallelogram();

            using (var dbEditPar = new Project1Dbcontext())
            {
                int ParId;
                double newParBase;
                double newParHeight;
                double newParHypothenuse;

                do
                {
                    Console.Write("\nAnge Id för resultatet av Parallellogramet som ska ändras" +
                        "\nID: ");
                    if (!int.TryParse(Console.ReadLine(), out ParId))
                    {
                        Console.WriteLine("\nDu måste ange ett ID för Parallellogramet" +
                            "som ska ändras.");
                    }
                    else if (ParId == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        var shapeType = dbEditPar.Shapes
                            .Where(p => p.ShapeId == ParId)
                            .Select(p => p.ShapeForm)
                            .FirstOrDefault();
                        if (shapeType == "Parallellogram")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Angivet ID: {ParId} existerar inte...");
                        }
                    }
                } while (true);

                var parToEdit = dbEditPar.Shapes
                   .Find(ParId);

                if (parToEdit == null)
                {
                    Console.WriteLine($"\nParallellogram med id {parToEdit} " +
                        $"existerar inte.");
                }

                do
                {
                    Console.Write("\nAnge en ny Bas för Parallellogramet: ");
                    if (!double.TryParse(Console.ReadLine(), out newParBase))
                    {
                        Console.WriteLine("\nDu måste ange en ny bas i form av siffror!");
                    }
                    else if (newParBase == 0)
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
                    Console.Write("Ange en ny Höjd för Parallellogramet: ");
                    if (!double.TryParse(Console.ReadLine(), out newParHeight))
                    {
                        Console.WriteLine("\nDu måste ange en ny höjd i form av siffror!");
                    }
                    else if (newParHeight == 0)
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
                    Console.Write("Ange en ny Hypotenusan för Parallellogramet: ");
                    if (!double.TryParse(Console.ReadLine(), out newParHypothenuse))
                    {
                        Console.WriteLine("\nDu måste ange en ny höjd i form av siffror!");
                    }
                    else if (newParHypothenuse == 0)
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

                var newParArea = (newParBase * 2) + (newParHypothenuse * 2);
                var newParCircumference = newParBase * newParHeight;

                Console.WriteLine($"\nDu har angett nya värden" +
                    $"\nNy Bas: {newParBase:F2} cm" +
                    $"\nNy Höjd: {newParHeight:F2} cm" +
                    $"\nNy Hypotenusa: {newParHypothenuse}");


                parToEdit.Base = newParBase;
                parToEdit.Height = newParHeight;
                parToEdit.Hypotenuse = newParHypothenuse;
                parToEdit.Area = newParArea;
                parToEdit.Circumference = newParCircumference;
                parToEdit.EditDate = DateOnly.FromDateTime(DateTime.Now);

                dbEditPar.SaveChanges();


                Console.WriteLine($"\n\nNy uträknad Omkrets: {newParCircumference} cm" +
                    $"\nNy uträknad Area: {newParArea} cm²");
            }
        }
    }
}
