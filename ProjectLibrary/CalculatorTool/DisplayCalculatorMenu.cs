using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.CalculatorTool
{
    public class DisplayCalculatorMenu
    {
        public static void ShowCalcMenu()
        {
            Console.Clear();
            bool isCalcMenuActive = true;
            CalcRules.RulesForCalculator();
            while (isCalcMenuActive)
            {
                switch (DisplayMenus.DisplayCalcMenu())
                {
                    case "1":
                        StartCalculator.Calculate();
                        Console.WriteLine("\nTryck på enter för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear(); 
                        break;
                    case "2":
                        //Se resultat
                        break;
                    case "3":
                        //Ändra resultat
                        break;
                    case "4":
                        //Ta bort resultat
                        break;
                    case "0":
                        Console.Clear();
                        isCalcMenuActive = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
