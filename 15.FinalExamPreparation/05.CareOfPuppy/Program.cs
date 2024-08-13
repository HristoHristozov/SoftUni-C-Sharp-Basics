using System;

namespace _05.CareOfPuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ownedFoodInKg = int.Parse(Console.ReadLine());
            int ownedFoogInGrams = ownedFoodInKg * 1000;
            int sumEatenFood = 0;

            string input = "";
            while ((input = Console.ReadLine()) != "Adopted")
            {
                int currentEatenFood = int.Parse(input);
                sumEatenFood += currentEatenFood;
              
            }

            if (sumEatenFood > ownedFoogInGrams)
            {
                int gramsRequired = sumEatenFood - ownedFoogInGrams;
                Console.WriteLine($"Food is not enough. You need {gramsRequired} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {ownedFoogInGrams - sumEatenFood} grams.");
            }

        }
    }
}
