using System;

namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            
            var inputSum = 0;

            while (inputSum < number)
            {
                var currentNum = int.Parse(Console.ReadLine());
                inputSum += currentNum;
                
            }

            Console.WriteLine(inputSum);
        }
    }
}
