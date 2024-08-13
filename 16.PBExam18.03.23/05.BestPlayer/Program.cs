using System;

namespace _05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string bestPlayer = "";
            int mostGoals = 0;
            string pottentialBestPlayer = "";

            while ((input = Console.ReadLine()) != "END")
            {
                pottentialBestPlayer = input;
                input = Console.ReadLine();

                int goals = int.Parse(input);
                if (mostGoals < goals)
                {
                    mostGoals = goals;
                    bestPlayer = pottentialBestPlayer;
                }
                if (goals >= 10)
                {
                    break;
                }
                
            }

            Console.WriteLine($"{bestPlayer} is the best player!");
            if (mostGoals >= 3)
            {
                Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
            }
            else Console.WriteLine($"He has scored {mostGoals} goals.");
        }
    }
}
