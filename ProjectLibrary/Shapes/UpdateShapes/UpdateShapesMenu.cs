using ProjectLibrary.Shapes.ReadShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Shapes.UpdateShapes
{
    public class UpdateShapesMenu
    {
        public static void ShowUpdateMenu()
        {
            Console.Clear();
            bool isUpdateMenu = true;
            while (isUpdateMenu)
            {
                switch (DisplayMenus.DisplayUpdateShapes())
                {
                    case "1":
                        UpdateRectangle.EditRectangle();
                        Console.WriteLine("\nTryck på enter för att gå tillbaka...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        UpdateParallelogram.EditParallelogram();
                        Console.WriteLine("\nTryck på enter för att gå tillbaka...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        UpdateTriangle.EditTriangle();
                        Console.WriteLine("\nTryck på enter för att gå tillbaka...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        //ändra romb
                        Console.WriteLine("\nTryck på enter för att gå tillbaka...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0":
                        Console.Clear();
                        isUpdateMenu = false;
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
