using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProjectLibrary.RockPaperScissor.CreateRPS
{
    public class RpsRules
    {
        public static void RulesForRps()
        {
            Console.Clear();
            Console.WriteLine("Sten Sax Påse" +
                "\n----------------------------------------");
            Console.WriteLine(" \nReglerna är simpla!" +
                "\nSten slår sax." +
                "\nSax slår påse." +
                "\nPåse slår sten." +
                "\nDu spelar mot datorn som slumpmässigt anger Sten, Sax eller Påse." +
                "\nVinn över datorn och se dina resultat.");
        }
    }
}
