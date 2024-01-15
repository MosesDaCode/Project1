using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.CalculatorTool.ReadCalculatorResults
{
    public class ReadCalculator
    {
        public static void ReadingCalculations()
        {
            Console.Clear();
            using (var dbReadCalc = new Project1Dbcontext())
            {
                var calcResults = dbReadCalc.Calculators.ToList();
                if (calcResults.Any())
                {
                    Console.WriteLine("\nVisar resultat..." +
                        "\n-------------------------------------------------------------");

                    foreach (var calc in calcResults)
                    {
                        if (calc.Operation == "√" && calc.SecondNum == 0 && calc.FirstNum != 0)
                        {
                            Console.WriteLine($"\nUträkning: {calc.CalculatorId}" +
                                $"\n\nsqrt {calc.FirstNum} = {calc.Result:F2}" +
                                $"\nDatum: {calc.CalculationDate}" +
                                $"\n\n-------------------------------------------------------------");
                        }
                        else if (calc.Operation == "√" && calc.FirstNum == 0 && calc.SecondNum != 0)
                        {
                            Console.WriteLine($"\nUträkning: {calc.CalculatorId}" +
                                $"\n\nsqrt {calc.SecondNum} = {calc.Result:F2}" +
                                $"\nDatum: {calc.CalculationDate}" +
                                $"\n\n-------------------------------------------------------------");
                        }
                        else if (calc.Operation == "%")
                        {
                            Console.WriteLine($"\nUträkning: {calc.CalculatorId}" +
                                $"\n\nRest av {calc.FirstNum} / {calc.SecondNum} = {calc.Result:F2}" +
                                $"\nDatum: {calc.CalculationDate}" +
                                $"\n\n-------------------------------------------------------------");
                        }
                        else
                        {
                            Console.WriteLine($"\nUträkning: {calc.CalculatorId}" +
                                $"\n\n{calc.FirstNum} {calc.Operation} {calc.SecondNum} = {calc.Result:F2}" +
                                $"\nDatum: {calc.CalculationDate}" +
                                $"\n\n-------------------------------------------------------------");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Inga resultat hittades...");
                }
            }
        }
    }
}
