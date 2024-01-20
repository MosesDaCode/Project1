using ProjectLibrary;
using ProjectLibrary.Build.Data;
using ProjectLibrary.Build.Service;
using ProjectLibrary.CalculatorTool;
using ProjectLibrary.RockPaperScissor;
using ProjectLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class Application
    {
        public void Run()
        {
            var configBuild = new ConfigBuilder();
            configBuild.BuildDb();
            while (true)
            {
                switch (DisplayMenus.DisplayMainMenu())
                {
                    case "1":
                        UseShapesMenu.ShowShapesMenu();    
                        break;
                    case "2":
                        DisplayCalculatorMenu.ShowCalcMenu();
                        break;
                    case "3":
                        DisplayRpsMenuGame.ShowRpsMenu();


                        break;
                    case "0":
                        Environment.Exit(0);
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
