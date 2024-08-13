using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int max = int.MinValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int amount = int.Parse(input);
                if (amount > max)
                {
                    max = amount;
                }
                
            }

            Console.WriteLine(max);
        }
    }
}
