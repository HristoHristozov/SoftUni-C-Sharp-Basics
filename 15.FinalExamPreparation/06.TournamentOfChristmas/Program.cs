using System;

namespace _06.TournamentOfChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentLenghtInDays = int.Parse(Console.ReadLine());
            int loseCount = 0;
            int winCount = 0;
            double moneyRaised = 0;
            string input = "";


            for (int i = 0; i < tournamentLenghtInDays; i++)
            {
                double moneyRaisedPerDay = 0;
                int loseCountPerDay = 0;
                int winCountPerDay = 0;

                while ((input = Console.ReadLine()) != "Finish")
                {
                    
                    input = Console.ReadLine();
                    if (input == "win")
                    {
                        moneyRaisedPerDay += 20;
                        winCount++;
                        winCountPerDay++;
                    }
                    else if (input == "lose")
                    {
                        loseCount++;
                        loseCountPerDay++;
                    }
                }
               
               if (winCountPerDay > loseCountPerDay)
               {
                   moneyRaisedPerDay = moneyRaisedPerDay + moneyRaisedPerDay * 0.1;

               }
                moneyRaised += moneyRaisedPerDay;
            }

            if (winCount > loseCount)
            {
                moneyRaised = moneyRaised + moneyRaised * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {moneyRaised:F2}");
            }
            else Console.WriteLine($"You lost the tournament! Total raised money: {moneyRaised:F2}");


        }
    }
}
