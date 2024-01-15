using ProjectLibrary.Shapes.CreateShapes;
using ProjectLibrary.Shapes.DeleteShapes;
using ProjectLibrary.Shapes.ReadShapes;
using ProjectLibrary.Shapes.UpdateShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectLibrary.Shapes
{
    public class UseShapesMenu
    {
        public static void ShowShapesMenu()
        {
            Console.Clear();
            bool isShapesMenu = true;
            Console.WriteLine("Regler för Shapes");
            Console.WriteLine("====================================");
            Console.WriteLine("Du väljer en av fyra former som kommer visas inom kort." +
                "\nSedan ska du ange ett antal faktorer som ska hjälpa dig att" +
                "\nräkna ut Omkrets och Area på den valda formen." +
                "\n\nTryck på enter för att fortsätta...");
            Console.ReadKey();
            Console.Clear();


            while (isShapesMenu)
            {
                switch (DisplayMenus.DisplayShapesCrud())
                {
                    case "1":
                        CreateShapeGameMenu.StartShaping();
                        break;
                    case "2":
                        ReadShapesMenu.ReadingShapesMenu();
                        break;
                    case "3":
                        UpdateShapesMenu.ShowUpdateMenu();
                        break;
                    case "4":
                        DeleteAnyShape.DeleteShapeResult();
                        Console.WriteLine("\nTryck på enter för att gå tillbaka...");
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
