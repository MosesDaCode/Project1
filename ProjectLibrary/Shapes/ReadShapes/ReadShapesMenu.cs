using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.ReadShapes
{
    public class ReadShapesMenu
    {
        public static void ReadingShapesMenu()
        {
            Console.Clear();
            bool isReadingshapes = true;
            while (isReadingshapes)
            {
                switch (DisplayMenus.DisplayReadShapes())
                {
                    case "1":
                        ReadAllShapes.ReadingAllShapes();
                        Console.WriteLine("\nTryck på enter för att gå tillbaka...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        //Se rektangel
                        break;
                    case "3":
                        //Se Parallellogram
                        break;
                    case "4":
                        //Se Triangel
                        break;
                    case "5":
                        //Se Romb
                        break;
                    case "0":
                        Console.Clear();
                        isReadingshapes = false;
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
