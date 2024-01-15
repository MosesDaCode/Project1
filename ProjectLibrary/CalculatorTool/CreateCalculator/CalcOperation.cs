using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.CalculatorTool.CreateCalculator
{
    public class CalcOperation
    {
        public static double GetOperation(double num1, double num2, string operation)
        {
            var calc = new StartCalculator();

            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num1 / num2;
                case "R1":
                    return Math.Sqrt(num1);
                case "R2":
                    return Math.Sqrt(num2);
                case "%":
                    return num1 % num2;
                case "0":
                    return 0;
                default:
                    return 0;
            }
        }
    }
}
