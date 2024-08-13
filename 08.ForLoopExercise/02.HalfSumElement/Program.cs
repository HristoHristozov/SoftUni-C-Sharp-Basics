using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            int sumWitoutMax = sum - max;
            if (max == sumWitoutMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",max);
            }
            else
            {
                int diff = Math.Abs(max - sumWitoutMax);
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",diff);
            }
        }
    }
}
