using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.RockPaperScissor.ReadRPS
{
    public class ReadRpsResults
    {
        public static void ReadingRpsResults()
        {
            Console.Clear();
            using (var dbReadRps = new Project1Dbcontext())
            {
                var rpsResults =dbReadRps.RockPaperScissor.ToList();
                if (rpsResults.Any())
                {
                    Console.WriteLine("Visar resultat..." +
                "\n-------------------------------------------");

                    foreach (var res in rpsResults)
                    {
                        Console.WriteLine($"Spel ID: {res.RpsId}" +
                            $"\nSpelares vapen: {res.PlayerMove}" +
                            $"\nDatorns vapen: {res.ComputerMove}" +
                            $"\nResultat: {res.Result}" +
                            $"\nGenomsnittlig vinst: {res.AvgWinRate}" +
                            $"\nDatum: {res.GameDate}");
                        Console.WriteLine("-------------------------------------------");
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
