using System;

namespace _02.CatWalking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int catWalkingMinutes = int.Parse(Console.ReadLine());
            int catWalkingTimes = int.Parse(Console.ReadLine());
            int catCalories = int.Parse(Console.ReadLine());

            int allMinutesWalking = catWalkingTimes * catWalkingMinutes;
            int allCaloriesBurned = allMinutesWalking * 5;

            if (allCaloriesBurned >= (catCalories /2))
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {allCaloriesBurned}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {allCaloriesBurned}.");
            }
        }
    }
}
