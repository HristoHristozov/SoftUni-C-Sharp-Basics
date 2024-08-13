using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournament = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int pointsFromTournament = 0;
            double averagePoints = 0;
            int tournamentsWon = 0;
            double tournamentsWonPercentage = 0.0;

            for (int i = 0; i < tournament; i++)
            {
                var stageOfTournament = Console.ReadLine();

                if (stageOfTournament == "W")
                {
                    pointsFromTournament += 2000;
                    tournamentsWon++;
                }
                else if (stageOfTournament == "F")
                {
                    pointsFromTournament += 1200;
                }
                else if (stageOfTournament == "SF")
                {
                    pointsFromTournament += 720;
                }
            }

            tournamentsWonPercentage = ((double)tournamentsWon / (double)tournament) * 100.0;
            averagePoints = pointsFromTournament / tournament;

            Console.WriteLine($"Final points: {pointsFromTournament + startingPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{tournamentsWonPercentage:F2}%");
            
        }
    }
}
