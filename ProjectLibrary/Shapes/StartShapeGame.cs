using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes
{
    public class StartShapeGame
    {
        public static void StartShaping()
        {
            Console.Clear();
            bool isShapesMenu = true;
            while (isShapesMenu)
            {
                switch (DisplayMenus.DisplayShapesMenu())
                {
                    case "1":
                        Rectangle.RectangleChoice();
                        Console.WriteLine("\nTryck på enter för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Parallelogram.ParallelogramChoice();
                        Console.WriteLine("\nTryck på enter för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Triangle.TriangleChoice();
                        Console.WriteLine("\nTryck på enter för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Rhomb.RhombChoice();
                        Console.WriteLine("\nTryck på enter för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        isShapesMenu = false;
                        break;
                    default:
                        Console.WriteLine("Du måste ange ett av valen ovan!!");
                        Console.WriteLine("Tryck på enter för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
