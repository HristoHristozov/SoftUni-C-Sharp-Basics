using System;

namespace _07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < nums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                sum += currentNum;
            }

            Console.WriteLine(sum);
        }
    }
}
