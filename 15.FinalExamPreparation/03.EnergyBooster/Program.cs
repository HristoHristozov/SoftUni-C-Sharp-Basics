using System;

namespace _03.EnergyBooster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var sizeSet = Console.ReadLine();
            int purchasedSets = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (fruit == "Watermelon")
            {
                if (sizeSet == "small")
                {
                    price = (56 * purchasedSets) * 2;                   
                }

                else if (sizeSet == "big")
                {
                    price = (28.70 * purchasedSets) * 5;
                }           
            }
            else if (fruit == "Mango")
            {
                if (sizeSet == "small")
                {
                    price = 36.66 * purchasedSets * 2;
                }

                else if (sizeSet == "big")
                {
                    price = 19.60 * purchasedSets * 5;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (sizeSet == "small")
                {
                    price = 42.10 * purchasedSets * 2;
                }

                else if (sizeSet == "big")
                {
                    price = 24.80 * purchasedSets * 5;
                }
            }

            else if (fruit == "Raspberry")
            {
                if (sizeSet == "small")
                {
                    price = 20 * purchasedSets * 2;
                }

                else if (sizeSet == "big")
                {
                    price = 15.20 * purchasedSets * 5;
                }
            }

            if (price >= 400 && price <= 1000)
            {
                price = price - ((price / 100) * 15);
            }
            else if (price > 1000)
            {
                price = price - ((price / 100) * 50);
            }

            Console.WriteLine($"{price:F2} lv.");
        }
    }
}
