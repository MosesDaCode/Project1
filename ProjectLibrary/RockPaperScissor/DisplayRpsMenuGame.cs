using ProjectLibrary.RockPaperScissor.CreateRPS;
using ProjectLibrary.RockPaperScissor.ReadRPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.RockPaperScissor
{
    public class DisplayRpsMenuGame
    {
        public static void ShowRpsMenu()
        {
            Console.Clear();
            RpsRules.RulesForRps();
            bool isRpsGame = true;
            while (isRpsGame)
            {
                switch (DisplayMenus.DisplayRpsMenu())
                {
                    case "1":
                        StartRpsGame.RpsGameRunning();
                        Console.WriteLine("\nTryck på enter för att fortsätta...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        ReadRpsResults.ReadingRpsResults();
                        Console.WriteLine("\nTryck på enter för att gå tillbaka...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        RpsRules.RulesForRps();
                        break;
                    case "0":
                        Console.Clear();
                        isRpsGame = false;
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
