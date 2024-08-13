using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var plants = Console.ReadLine();
            var plantsNumbers = double.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());

            var sum = 0.0;

            if (plants == "Roses")
            {
                sum = 5 * plantsNumbers;
                if (plantsNumbers > 80)
                {
                    sum = sum - (sum * 0.1);
                }
            }

            else if (plants == "Dahlias")
            {
                sum = 3.8 * plantsNumbers;
                if (plantsNumbers > 90)
                {
                    sum = sum - (sum * 0.15);
                }
            }

            else if (plants == "Tulips")
            {
                sum = 2.80 * plantsNumbers;
                if (plantsNumbers > 80)
                {
                    sum = sum - (sum * 0.15);
                }
            }

            else if (plants == "Narcissus")
            {
                sum = 3 * plantsNumbers;
                if (plantsNumbers < 120)
                {
                    sum = sum + (sum * 0.15);
                }
                
            }
            else if (plants == "Gladiolus")
            {
                sum = 2.50 * plantsNumbers;
                if (plantsNumbers < 80)
                {
                    sum = sum + (sum * 0.2);
                }
                
            }

            double moneyLeft = budget - sum;
            if (moneyLeft >= 0)
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", plantsNumbers, plants, moneyLeft);
            }
            else
            {
                moneyLeft = sum - budget;
                Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyLeft);
            }
        }
    }
}
