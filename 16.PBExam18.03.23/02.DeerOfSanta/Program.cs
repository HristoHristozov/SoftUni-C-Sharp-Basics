using System;

namespace _02.DeerOfSanta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysSantaMissing = int.Parse(Console.ReadLine());
            int foodLeftInKg = int.Parse(Console.ReadLine());
            double foodForDayFirstDeer = double.Parse(Console.ReadLine());
            double foodForDaySecondDeer = double.Parse(Console.ReadLine());
            double foodForDayThirdDeer = double.Parse(Console.ReadLine());

            double allDeersFoodEaten = (foodForDayFirstDeer + foodForDaySecondDeer + foodForDayThirdDeer) * daysSantaMissing;

            if (allDeersFoodEaten <= foodLeftInKg)
            {
                double foodLeft = foodLeftInKg - allDeersFoodEaten;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodLeft = allDeersFoodEaten - foodLeftInKg;
                Console.WriteLine($"{Math.Ceiling(foodLeft)} more kilos of food are needed.");
            }
            
        }
    }
}
