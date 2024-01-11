using ProjectLibrary.Shapes.ReadShapes;
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
                        StartShapeGame.StartShaping();
                        break;
                    case "2":
                        ReadShapesMenu.ReadingShapesMenu();
                        break;
                    case "3":
                        //Ändra resultat 
                        break;
                    case "4":
                        //ta bort resultat
                        break;
                    case "0":
                        Console.Clear();
                        isShapesMenu = false;
                        break;
                    default:
                        


                        break;
                }
            }
        }
    }
}
