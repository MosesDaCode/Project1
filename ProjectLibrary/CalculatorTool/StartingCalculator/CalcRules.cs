using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.CalculatorTool.StartingCalculator
{
    public class CalcRules
    {
        public static void RulesForCalculator()
        {
            Console.WriteLine("Regler för Calculator");
            Console.WriteLine("====================================");
            Console.WriteLine("Du ska ange 2 nummer " +
                "\nSedan en operator att räkna med (+, -, *, /, √, %)" +
                "\nFå sedan ett svar att spara" +
                "\nDu kan även granska svaren" +
                "\nÄndra gamla svar" +
                "\nSedan ta bort svar (Om så önskas)" +
                "\n\nTryck på enter för att börja uträkningen...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
