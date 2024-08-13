using System;

namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "";

            int minValue = int.MaxValue;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int currentValue = int.Parse(input);

                if (minValue > currentValue)
                {
                    minValue = currentValue;
                }
            }

            Console.WriteLine(minValue);
        }
    }
}
