using Microsoft.EntityFrameworkCore.Storage.Json;
using ProjectLibrary.Build.Data;
using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProjectLibrary.CalculatorTool.CreateCalculator
{
    public class StartCalculator
    {
        public static void Calculate()
        {
            Console.Clear();
            using (var dbcalc = new Project1Dbcontext())
            {
                Console.WriteLine("Calculator" +
                    "\nAnge 0 för att gå tillbaka..." +
                    "\n\nSaker att tänka på..." +
                    "\nOm du vill Subtrahera så ska det första nummret vara större än det andra nummret." +
                    "\nOm du vill Dividera så ska det första nummret vara större än det andra nummret." +
                    "\nOm du vill räkna Modulo (Rest) så ska det första nummret vara större än det andra nummret. " +
                    "\n-------------------------------------------");
                double firstNum;
                double secondNum;

                do
                {
                    Console.Write("Ange det första nummret för uträkningen'" +
                        "\nFörsta nummret: ");
                    if (!double.TryParse(Console.ReadLine(), out firstNum))
                    {
                        Console.WriteLine("\nDu måste ange en siffra!!!");
                    }
                    else if (firstNum == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nBra jobbat!!!");
                        break;
                    }
                } while (true);

                do
                {
                    Console.Write($"Ange det andra nummret för uträkninen" +
                        $"\nFörsta nummret: {firstNum}" +
                        $"\nAndra nummret: ");
                    if (!double.TryParse(Console.ReadLine(), out secondNum))
                    {
                        Console.WriteLine("\nDu måste ange en siffra!!!");
                    }
                    else if (secondNum == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                string operation;
                double result;
                do
                {
                    Console.WriteLine("-------------------------------" +
                    "\n|   +   |   Addera" +
                    "\n|   -   |   Subtrahera" +
                    "\n|   *   |   Multiplicera" +
                    "\n|   /   |   Dividera" +
                    $"\n|   R1  |   Roten ur {firstNum}" +
                    $"\n|   R2  |   Roten ur {secondNum}" +
                    $"\n|   %   |   Rest" +
                    $"\n-------------------------------");
                    Console.Write($"\nAnge en Operand att använda i uträkningen" +
                   $"\nFörsta Nummret: {firstNum}" +
                   $"\nAndra nummret: {secondNum}" +
                   $"\nOperand: ");
                    operation = Console.ReadLine();

                    if (!string.IsNullOrEmpty(operation) && operation == "+" || operation == "-" || operation == "*" ||
                         operation == "/" || operation.ToUpper() == "R1" || operation.ToUpper() == "R2" || operation == "%")
                    {

                        result = CalcOperation.GetOperation(firstNum, secondNum, operation.ToUpper());

                        if (operation.ToUpper() == "R1")
                        {
                            var newCalcForSqrtOne = new Calculator()
                            {
                                FirstNum = firstNum,
                                Operation = "√",
                                Result = result,
                                CalculationDate = DateOnly.FromDateTime(DateTime.Now)
                            };
                            dbcalc.Add(newCalcForSqrtOne);
                            dbcalc.SaveChanges();
                            Console.WriteLine("\nResultat för uträkningen" +
                           "\n......................................." +
                           $"\nsqrt {firstNum} = {result:F2}");
                            break;
                        }
                        else if (operation.ToUpper() == "R2")
                        {
                            var newcalcForSqrtTwo = new Calculator()
                            {
                                SecondNum = secondNum,
                                Operation = "√",
                                Result = result,
                                CalculationDate = DateOnly.FromDateTime(DateTime.Now)
                            };
                            dbcalc.Add(newcalcForSqrtTwo);
                            dbcalc.SaveChanges();
                            Console.WriteLine("\nResultat för uträkningen" +
                          "\n......................................." +
                          $"\nsqrt {secondNum:F0} = {result:F2} ");
                            break;
                        }
                        else if (operation.ToUpper() == "%")
                        {
                            var newcalcForModu = new Calculator()
                            {
                                FirstNum = firstNum,
                                SecondNum = secondNum,
                                Operation = operation,
                                Result = result,
                                CalculationDate = DateOnly.FromDateTime(DateTime.Now)
                            };
                            dbcalc.Add(newcalcForModu);
                            dbcalc.SaveChanges();
                            Console.WriteLine("\nResultat för uträkningen" +
                          "\n......................................." +
                          $"\nRest av  {firstNum:F0} / {secondNum:F0} = {result:F0} ");
                            break;
                        }
                        else
                        {
                            var newcalc = new Calculator()
                            {
                                FirstNum = firstNum,
                                SecondNum = secondNum,
                                Operation = operation,
                                Result = result,
                                CalculationDate = DateOnly.FromDateTime(DateTime.Now)
                            };

                            dbcalc.Add(newcalc);
                            dbcalc.SaveChanges();
                            Console.WriteLine("\nResultat för uträkningen" +
                                "\n......................................." +
                                $"\nResultat: {firstNum:F2} {operation} {secondNum:F2} = {result:F2}");
                            break;
                        }

                    }
                    else if (string.IsNullOrEmpty(operation) || operation != "+" || operation != "-" || operation != "*" ||
                         operation != "/" || operation.ToUpper() != "R1" || operation.ToUpper() != "R2" || operation != "%")
                    {
                        Console.WriteLine("Du har angett en felaktig operand!!!" +
                            "\nTryck på enter och försök igen...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (operation != "0")
                    {
                        Console.Clear();
                        return;
                    }

                } while (true);



            }

        }

    }
}

