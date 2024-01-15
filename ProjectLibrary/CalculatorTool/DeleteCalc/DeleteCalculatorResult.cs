using Azure;
using ProjectLibrary.Build.Service;
using ProjectLibrary.CalculatorTool.ReadCalculatorResults;
using ProjectLibrary.Shapes.ReadShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.CalculatorTool.DeleteCalc
{
    public class DeleteCalculatorResult
    {
        public static void DeletingCalcResult()
        {
            Console.Clear();
            Console.WriteLine("................................." +
                "\nTa bort resultat" +
                "\nAnge 0 för att gå tillbaka..." +
                "\n.................................");
            ReadCalculator.ReadingCalculations();

            using (var dbDelCalcResult = new Project1Dbcontext())
            {
               
                int calcResId;
                do
                {
                    Console.WriteLine("\n\nAnge ID för Resultatet du vill ta bort");
                    if (!int.TryParse(Console.ReadLine(), out calcResId))
                    {
                        Console.WriteLine("ID existerar inte!");
                    }
                    else if (calcResId == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        var calcResToDelete = dbDelCalcResult.Calculators
                                .Find(calcResId);

                        if (calcResToDelete != null)
                        {
                            dbDelCalcResult.Calculators.Remove(calcResToDelete);
                            dbDelCalcResult.SaveChanges();

                            if (calcResToDelete.Operation == "√" && calcResToDelete.FirstNum != 0 )
                            {
                                Console.WriteLine("\nResultatet är borta ur systemet..." +
                                       "\n.................................................." +
                                       $"\nSqrt {calcResToDelete.FirstNum} = {calcResToDelete.Result:F2}");
                                break;
                            }
                            else if (calcResToDelete.Operation == "√" && calcResToDelete.SecondNum != 0)
                            {
                                Console.WriteLine("\nResultatet är borttagen ur systemet!!!" +
                                       "\n.................................................." +
                                       $"\nSqrt {calcResToDelete.SecondNum} = {calcResToDelete.Result:F2}");
                                break;
                            }
                            else if (calcResToDelete.Operation == "%")
                            {
                                Console.WriteLine("\nResultatet är ni borttagen ur systemet!!!" +
                                     "\n......................................." +
                                     $"\nRest av  {calcResToDelete.FirstNum:F0} / {calcResToDelete.SecondNum:F0} = {calcResToDelete.Result:F0} ");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nResultatet är ni borttagen ur systemet!!!" +
                                           "\n......................................." +
                                           $"\nResultat: {calcResToDelete.FirstNum:F2} {calcResToDelete.Operation} {calcResToDelete.SecondNum:F2} = {calcResToDelete.Result:F2}");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("ID du har angett existerar inte!!!");

                        }
                       
                    }
                } while (true);
            } 
        }
    }
}
