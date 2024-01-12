using ProjectLibrary.Build.Service;
using ProjectLibrary.Shapes.ReadShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.DeleteShapes
{
    public class DeleteAnyShape
    {
        public static void DeleteShapeResult()
        {
            Console.Clear();
            Console.WriteLine("................................." +
                "\nTa bort resultat" +
                "\nAnge 0 för att gå tillbaka..." +
                "\n.................................");
            ReadAllShapes.ReadingAllShapes();

            using (var dbDeleteShapes = new Project1Dbcontext())
            {
                Console.WriteLine("\n\nAnge ID för Resultatet du vill ta bort");
                int shapeId;
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out shapeId))
                    {
                        Console.WriteLine("ID existerar inte!");
                    }
                    else if (shapeId == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                var shapeToDelete = dbDeleteShapes.Shapes
                    .Find(shapeId);
                dbDeleteShapes.Shapes.Remove(shapeToDelete);
                dbDeleteShapes.SaveChanges();
                Console.WriteLine($"Resultat för {shapeToDelete.ShapeForm}" +
                    $"\nOmkrets: {shapeToDelete.Circumference} cm" +
                    $"\nArea: {shapeToDelete.Area} cm²" +
                    $"\nÄr nu raderad ur systemet!!");
            }
        }
    }
}
