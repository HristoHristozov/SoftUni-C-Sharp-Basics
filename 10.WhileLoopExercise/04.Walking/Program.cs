using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int stepsGoal = 10000;
            int sumOfAllSteps = 0;

            while (sumOfAllSteps <= stepsGoal)
            {
                string input = Console.ReadLine();
                int currentSteps = 0;

                if (input == "Going home")
                {
                    currentSteps = int.Parse(Console.ReadLine());
                    sumOfAllSteps += currentSteps;
                    break;
                }
                else
                {
                    currentSteps = int.Parse(input);
                    sumOfAllSteps += currentSteps;
                }

                

            }

            if (sumOfAllSteps < 10000)
            {
                int remainingSteps = stepsGoal - sumOfAllSteps;
                Console.WriteLine($"{remainingSteps} more steps to reach goal.");
            }
            else
            {
                int stepsOverGoal = sumOfAllSteps - stepsGoal;
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{stepsOverGoal} steps over the goal!");
            }
        }
    }
}
