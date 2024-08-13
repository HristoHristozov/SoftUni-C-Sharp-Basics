using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            double moneyForJourney = 0.0;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    moneyForJourney = budget * 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2}", moneyForJourney);
                }

                if (season == "winter")
                {
                    moneyForJourney = budget * 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2}", moneyForJourney);
                }

            }

            else if (budget > 100 && budget <= 1000)
            {
                if (season == "summer")
                {
                    moneyForJourney = budget * 0.4;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:F2}", moneyForJourney);
                }

                if (season == "winter")
                {
                    moneyForJourney = budget * 0.8;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:F2}", moneyForJourney);
                }
            }

            else if (budget > 1000)
            {
                moneyForJourney = budget * 0.9;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:F2}", moneyForJourney);
            }

        }
    }
}
