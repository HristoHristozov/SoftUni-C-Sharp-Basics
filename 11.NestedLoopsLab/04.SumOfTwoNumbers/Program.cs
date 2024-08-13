using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputStart = int.Parse(Console.ReadLine());
            int inputEnd = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int allCombinations = 0;
            int magicCombinations = 0;
            int firstNum = 0;
            int secondNum = 0;

            for (int i = inputStart; i <= inputEnd; i++)
            {
                for (int j = inputStart; j <= inputEnd; j++)
                {
                    allCombinations++;
                    if (i + j == magicNum)
                    {
                        firstNum = i;
                        secondNum = j;
                        magicCombinations += 1;
                        Console.WriteLine($"Combination N:{allCombinations} ({firstNum} + {secondNum} = {magicNum})");
                        return;
                    }
                    
                }
            }

            if (magicCombinations == 0)
            {
                Console.WriteLine($"{allCombinations} combinations - neither equals {magicNum}");

            }

        }
    }
}
