using System;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < number; i++)
            {
                int leftNumbers = int.Parse(Console.ReadLine());
                leftSum += leftNumbers;
            }

            for (int i = 0; i < number; i++)
            {
                int rightNumbers = int.Parse(Console.ReadLine());
                rightSum += rightNumbers;
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine("Yes, sum = {0}", rightSum);
            }
            else
            {
                int diff = Math.Abs(rightSum - leftSum);
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}
