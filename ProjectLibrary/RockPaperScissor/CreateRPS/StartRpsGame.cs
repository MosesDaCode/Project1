using Microsoft.EntityFrameworkCore.Storage;
using ProjectLibrary.Build.Data;
using ProjectLibrary.Build.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProjectLibrary.RockPaperScissor.CreateRPS
{
    public class StartRpsGame
    {
        public static void RpsGameRunning()
        {
            Console.Clear();


            using (var dbRps = new Project1Dbcontext())
            {
                var computerRandChoice = new Random();
                bool isGameRunning = true;
                var rpsScore = new RPS();
                var userChoice = "";
                var computerChoice = 0;


                do
                {
                    var allGames = dbRps.RockPaperScissor.ToList();
                    var totalWins = allGames.Count(g => g.Result == "Vinst");
                    var totalGames = allGames.Count();

                    do
                    {
                        Console.WriteLine("Sten Sax Påse" +
                        "\n..................................");

                        Console.WriteLine("\nFör Sten ange: R" +
                            "\nFör Sax ange: S" +
                            "\nFör Påse ange: P");
                        Console.Write("\nVälj ditt vapen!" +
                            "\nVal:");
                        userChoice = Console.ReadLine();
                        computerChoice = computerRandChoice.Next(3);
                        
                        decimal newAvgWinRate = 0;

                        if (computerChoice == 0)
                        {
                            totalGames++;
                            newAvgWinRate = totalGames > 0 ? (decimal)totalWins / (decimal)totalGames : 0;

                            if (userChoice.ToUpper() == "R")
                            {
                                Console.WriteLine("\nBåda valde Sten!!!" +
                                    "\nDet blev lika...");
                                var newScoreRockTie = new RPS()
                                {
                                    PlayerMove = "Sten",
                                    ComputerMove = "Sten",
                                    Result = "Oavgjort",
                                    GameDate = DateOnly.FromDateTime(DateTime.Now),
                                    AvgWinRate = newAvgWinRate
                                };
                                dbRps.Add(newScoreRockTie);
                                dbRps.SaveChanges();
                                break;
                            }
                            else if (userChoice.ToUpper() == "S")
                            {
                                Console.WriteLine("\nBåda valde Sax!!!" +
                                    "\nDet blev lika....");
                                var newScoreScissorTie = new RPS()
                                {
                                    PlayerMove = "Sax",
                                    ComputerMove = "Sax",
                                    Result = "Oavgjort",
                                    GameDate = DateOnly.FromDateTime(DateTime.Now),
                                    AvgWinRate = newAvgWinRate
                                };
                                dbRps.Add(newScoreScissorTie);
                                dbRps.SaveChanges();
                                break;
                            }
                            else if (userChoice.ToUpper() == "P")
                            {
                                Console.WriteLine("\nBåda valde Påse!!!" +
                                    "\n Det Blev lika...");
                                var newScorePaperTie = new RPS()
                                {
                                    PlayerMove = "Påse",
                                    ComputerMove = "Påse",
                                    Result = "Oavgjort",
                                    GameDate = DateOnly.FromDateTime(DateTime.Now),
                                    AvgWinRate = newAvgWinRate
                                };
                                dbRps.Add(newScorePaperTie);
                                dbRps.SaveChanges();
                                break;
                            }
                            else if (userChoice != "R" && userChoice != "S" && userChoice != "P" &&
                                string.IsNullOrEmpty(userChoice))
                            {
                                Console.WriteLine("\nOgiltigt val!!" +
                                        "\nDu måste ange R eller S eller P..." +
                                        "\nTryck på enter och försök igen!!");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            else if (userChoice == "0")
                            {
                                Console.Clear();
                                return;
                            }

                        }
                        else if (computerChoice == 1)
                        {
                            totalGames++;
                            newAvgWinRate = totalGames > 0 ? (decimal)totalWins / (decimal)totalGames : 0;

                            if (userChoice.ToUpper() == "R")
                            {
                                Console.WriteLine("\nDitt val: Sten" +
                                    "\nDatorns val: Påse" +
                                    "\nDu förlorar Påse tar Sten!!");
                                var newScoreRockLose = new RPS()
                                {
                                    PlayerMove = "Sten",
                                    ComputerMove = "Påse",
                                    Result = "Förlust",
                                    GameDate = DateOnly.FromDateTime(DateTime.Now),
                                    AvgWinRate = newAvgWinRate
                                };
                                dbRps.Add(newScoreRockLose);
                                dbRps.SaveChanges();
                                break;
                            }
                            else if (userChoice.ToUpper() == "S")
                            {
                                Console.WriteLine("\nDitt val: Sax" +
                                    "\nDatorns val: Sten" +
                                    "\nDu förlorar! Sten tar Sax!!");
                                var newScoreScissorLose = new RPS()
                                {
                                    PlayerMove = "Sax",
                                    ComputerMove = "Sten",
                                    Result = "Förlust",
                                    GameDate = DateOnly.FromDateTime(DateTime.Now),
                                    AvgWinRate = newAvgWinRate
                                };
                                dbRps.Add(newScoreScissorLose);
                                dbRps.SaveChanges();
                                break;
                            }
                            else if (userChoice.ToUpper() == "P")
                            {
                                Console.WriteLine("\nDitt val: Påse" +
                                    "\nDatorns val: Sax" +
                                    "\nDu förlorar! Sax tar Påse");
                                var newScorePaperLose = new RPS()
                                {
                                    PlayerMove = "Påse",
                                    ComputerMove = "Sax",
                                    Result = "Förlust",
                                    GameDate = DateOnly.FromDateTime(DateTime.Now),
                                    AvgWinRate = newAvgWinRate
                                };
                                dbRps.Add(newScorePaperLose);
                                dbRps.SaveChanges();
                                break;
                            }
                            else if (userChoice != "R" && userChoice != "S" && userChoice != "P" &&
                               string.IsNullOrEmpty(userChoice))
                            {
                                Console.WriteLine("\nOgiltigt val!!" +
                                        "\nDu måste ange R eller S eller P..." +
                                        "\nTryck på enter och försök igen!!");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            else if (userChoice == "0")
                            {
                                Console.Clear();
                                return;
                            }
                        }
                        else if (computerChoice == 2)
                        {
                            totalGames++;
                            totalWins++;
                            newAvgWinRate = totalGames > 0 ? (decimal)totalWins / (decimal)totalGames : 1;

                            if (userChoice.ToUpper() == "R")
                            {
                                Console.WriteLine("\nDitt val: Sten" +
                                    "\nDatorns val: Sax" +
                                    "\nWhoooo du vinner!!");
                                var newScoreRockWin = new RPS()
                                {
                                    PlayerMove = "Sten",
                                    ComputerMove = "Sax",
                                    Result = "Vinst",
                                    GameDate = DateOnly.FromDateTime(DateTime.Now),
                                    AvgWinRate = newAvgWinRate
                                };
                                dbRps.Add(newScoreRockWin);
                                dbRps.SaveChanges();
                                break;
                            }
                            else if (userChoice.ToUpper() == "S")
                            {
                                Console.WriteLine("\nDitt val: Sax" +
                                    "\nDatorns val: Påse" +
                                    "\nWhoooo du vinner!!");
                                var newScoreScissorWin = new RPS()
                                {
                                    PlayerMove = "Sax",
                                    ComputerMove = "Påse",
                                    Result = "Vinst",
                                    GameDate = DateOnly.FromDateTime(DateTime.Now),
                                    AvgWinRate = newAvgWinRate
                                };
                                dbRps.Add(newScoreScissorWin);
                                dbRps.SaveChanges();
                                break;
                            }
                            else if (userChoice.ToUpper() == "P")
                            {
                                Console.WriteLine("\nDitt val: Påse" +
                                    "\nDatorns val: Sten" +
                                    "\nWhoooo du vinner!!");
                                var newScorePaperWin = new RPS()
                                {
                                    PlayerMove = "Påse",
                                    ComputerMove = "Sten",
                                    Result = "Vinst",
                                    GameDate = DateOnly.FromDateTime(DateTime.Now),
                                    AvgWinRate = newAvgWinRate
                                };
                                dbRps.Add(newScorePaperWin);
                                dbRps.SaveChanges();
                                break;
                            }
                            else if (userChoice != "R" && userChoice != "S" && userChoice != "P" &&
                                string.IsNullOrEmpty(userChoice))
                            {
                                Console.WriteLine("\nOgiltigt val!!" +
                                       "\nDu måste ange R eller S eller P..." +
                                       "\nTryck på enter och försök igen!!");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                            }
                            else if (userChoice == "0")
                            {
                                Console.Clear();
                                return;
                            }
                        }



                    } while (true);


                    Console.WriteLine("\n(J/N)" +
                        "\nVill du spela igen??");
                    var playAgainChoice = Console.ReadLine();

                    while (playAgainChoice.ToUpper() != "J" && playAgainChoice.ToUpper() != "N")
                    {
                        Console.WriteLine("Ogiltigt val, Ange J eller N (Ja eller Nej)");
                        Console.WriteLine("\n(J/N)" +
                            "\nVill du spela igen??");
                        playAgainChoice = Console.ReadLine();
                    }
                    if (playAgainChoice.ToUpper() == "N")
                    {
                        break;
                    }
                    else if (playAgainChoice.ToUpper() == "J")
                    {
                        Console.Clear();
                        continue;
                    }



                } while (true);

            }
        }
    }
}
