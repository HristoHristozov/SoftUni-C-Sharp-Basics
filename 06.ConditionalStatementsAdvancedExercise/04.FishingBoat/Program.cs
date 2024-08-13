using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var groupBudget = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var fishers = int.Parse(Console.ReadLine());

            double requiredMoney = 0.0;
            double moneyLeft = 0.0;

            if (season == "Spring")
            {
                if (fishers <= 6)
                {
                    requiredMoney = 3000 - (3000 * 0.1);                
                }

                else if (fishers > 6 && fishers <= 11)
                {
                    requiredMoney = 3000 - (3000 * 0.15);
                }

                else if (fishers > 11)
                {
                    requiredMoney = 3000 - (3000 * 0.25);
                }

            }

            else if (season == "Summer" || season == "Autumn")
            {
                if (fishers <= 6)
                {
                    requiredMoney = 4200 - (4200 * 0.1);
                }

                else if (fishers > 6 && fishers <= 11)
                {
                    requiredMoney = 4200 - (4200 * 0.15);
                }

                else if (fishers > 11)
                {
                    requiredMoney = 4200 - (4200 * 0.25);
                }
            }

            else if (season == "Winter")
            {
                if (fishers <= 6)
                {
                    requiredMoney = 2600 - (2600 * 0.1);
                }

                else if (fishers > 6 && fishers <= 11)
                {
                    requiredMoney = 2600 - (2600 * 0.15);
                }

                else if (fishers > 11)
                {
                    requiredMoney = 2600 - (2600 * 0.25);
                }
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                requiredMoney = requiredMoney - (requiredMoney * 0.05);
            }

            moneyLeft = groupBudget - requiredMoney;

            if (moneyLeft >= 0)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", moneyLeft);
            }
            else if (moneyLeft < 0)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", Math.Abs(moneyLeft));
            }
        }
    }
}
