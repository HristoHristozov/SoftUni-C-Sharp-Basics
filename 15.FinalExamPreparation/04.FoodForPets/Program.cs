using System;

namespace _04.FoodForPets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            decimal allFood = decimal.Parse(Console.ReadLine());

            decimal allFoodEatenDog = 0.0m;
            decimal allFoodEatenCat = 0.0m;
            decimal allFoodEatenByBoth = 0.0m;
            decimal totalBiscuitsEaten = 0m;


            for (int i = 1; i <= daysCount; i++)
            {
                int dogFood = int.Parse(Console.ReadLine());
                allFoodEatenDog += dogFood;
                int catFood = int.Parse(Console.ReadLine());
                allFoodEatenCat += catFood;
                if (i % 3 == 0)
                {
                    totalBiscuitsEaten += (dogFood + catFood) / 10.0m;
                }

            }

            allFoodEatenByBoth = allFoodEatenCat + allFoodEatenDog;
            decimal percentEatenFoodbyBoth = (allFoodEatenByBoth * 100.0m) / (allFood);
            decimal percentEatenFoodByDog = (allFoodEatenDog * 100.0m) / allFoodEatenByBoth;
            decimal percentEatenFoodByCat = (allFoodEatenCat * 100.0m) / allFoodEatenByBoth;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiscuitsEaten)}gr.");
            Console.WriteLine($"{percentEatenFoodbyBoth:F2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatenFoodByDog:F2}% eaten from the dog.");
            Console.WriteLine($"{percentEatenFoodByCat:F2}% eaten from the cat.");

            
        }
    }
}
