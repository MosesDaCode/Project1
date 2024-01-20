using ProjectLibrary.Build.Data;
using ProjectLibrary.Build.Service;
using ProjectLibrary.CalculatorTool.CreateCalculator;
using ProjectLibrary.CalculatorTool.ReadCalculatorResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.CalculatorTool.UpdateCalculator
{
    public class UpdateCalcResults
    {
        public static void UpdatingCalcResults()
        {
            ReadCalculator.ReadingCalculations();
            using (var dbUpdateCalcResult = new Project1Dbcontext())
            {
                int calcId;
                double newFirstNum = 0;
                double newSecondNum = 0;
                double result = 0;
                string operation = null;

                do
                {
                    Console.Write("Ange Id för Resultatet du vi ändra på!" +
                        "\nID: ");
                    if (!int.TryParse(Console.ReadLine(), out calcId))
                    {
                        Console.WriteLine("\nDu måste ange ett ID för Rektangeln" +
                                                    "som ska ändras.");
                    }
                    else if (calcId == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                Console.Clear();

                var calcRes = dbUpdateCalcResult.Calculators
                           .Find(calcId);
                do
                {
                    if (calcRes != null)
                    {
                        do
                        {

                            Console.Write("Ange ett nytt första nummer att ändra till!" +
                                "\nFörsta nummret: ");
                            if (!double.TryParse(Console.ReadLine(), out newFirstNum))
                            {
                                Console.WriteLine("\nDu måste ange det första nummret" +
                                    "i form av siffror!!");
                            }
                            else if (newFirstNum == 0)
                            {
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                break;
                            }
                        } while (true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"ID: {calcId} Existerar inte");
                        return;
                    }
                } while (true);


                do
                {
                    Console.Write("Ange ett nytt andra nummer att ändra till!" +
                        $"\nFörsta nummret: {newFirstNum}" +
                        $"\nAndra nummret: ");
                    if (!double.TryParse(Console.ReadLine(), out newSecondNum))
                    {
                        Console.WriteLine("\nDu måste ange det första nummret" +
                            "i form av siffror!!");
                    }
                    else if (newSecondNum == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                do
                {
                    Console.WriteLine("-------------------------------" +
                    "\n|   +   |   Addera" +
                    "\n|   -   |   Subtrahera" +
                    "\n|   *   |   Multiplicera" +
                    "\n|   /   |   Dividera" +
                    $"\n|   R1  |   Roten ur {newFirstNum}" +
                    $"\n|   R2  |   Roten ur {newSecondNum}" +
                    $"\n|   %   |   Rest" +
                    $"\n-------------------------------");
                    Console.Write($"\nAnge en Operand att använda i uträkningen" +
                   $"\nFörsta Nummret: {newFirstNum}" +
                   $"\nAndra nummret: {newSecondNum}" +
                   $"\nOperand: ");
                    operation = Console.ReadLine();

                    if (!string.IsNullOrEmpty(operation) && operation == "+" || operation == "-" || operation == "*" ||
                         operation == "/" || operation.ToUpper() == "R1" || operation.ToUpper() == "R2" || operation == "%")
                    {

                        result = CalcOperation.GetOperation(newFirstNum, newSecondNum, operation.ToUpper());

                        if (operation.ToUpper() == "R1")
                        {
                            calcRes.FirstNum = newFirstNum;
                            calcRes.Operation = "√";
                            calcRes.Result = result;
                            calcRes.EditDate = DateOnly.FromDateTime(DateTime.Now);
                            dbUpdateCalcResult.SaveChanges();
                            Console.WriteLine("\nResultat för uträkningen" +
                           "\n......................................." +
                           $"\nSqrt {newFirstNum} = {result:F2}");
                            break;
                        }
                        else if (operation.ToUpper() == "R2")
                        {
                            calcRes.SecondNum = newSecondNum;
                            calcRes.Operation = "√";
                            calcRes.Result = result;
                            calcRes.EditDate = DateOnly.FromDateTime(DateTime.Now);
                            dbUpdateCalcResult.SaveChanges();
                            Console.WriteLine("\nResultat för uträkningen" +
                          "\n......................................." +
                          $"\nSqrt {newSecondNum:F0} = {result:F2} ");
                            break;
                        }
                        else if (operation.ToUpper() == "%")
                        {
                            calcRes.FirstNum = newFirstNum;
                            calcRes.SecondNum = newSecondNum;
                            calcRes.Operation = operation;
                            calcRes.Result = result;
                            calcRes.EditDate = DateOnly.FromDateTime(DateTime.Now);
                            dbUpdateCalcResult.SaveChanges();
                            Console.WriteLine("\nResultat för uträkningen" +
                          "\n......................................." +
                          $"\nRest av  {newFirstNum:F0} / {newSecondNum:F0} = {result:F0} ");
                            break;
                        }
                        else
                        {
                            calcRes.FirstNum = newFirstNum;
                            calcRes.SecondNum = newSecondNum;
                            calcRes.Operation = operation;
                            calcRes.Result = result;
                            calcRes.EditDate = DateOnly.FromDateTime(DateTime.Now);
                            dbUpdateCalcResult.SaveChanges();
                            Console.WriteLine("\nResultat för uträkningen" +
                                "\n......................................." +
                                $"\nResultat: {newFirstNum:F2} {operation} {newSecondNum:F2} = {result:F2}");
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
