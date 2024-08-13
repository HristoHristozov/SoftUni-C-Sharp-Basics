using System;
using System.Security;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < numbers; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }

                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
            }

            Console.WriteLine("Max number: {0}", maxNum);
            Console.WriteLine("Min number: {0}", minNum);
        }
    }
}
