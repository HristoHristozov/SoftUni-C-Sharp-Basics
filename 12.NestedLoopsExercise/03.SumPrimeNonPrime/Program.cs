using System;
using System.Security;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {
                bool isPrime = true;
                int currentNum = int.Parse(input);
                if (currentNum < 0)
                {
                    currentNum = 0;
                    Console.WriteLine("Number is negative.");

                }

                else if (currentNum == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int count = 2; count <= currentNum; count++)
                    {
                        if (currentNum % count == 0 && count != currentNum)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                }
                if (isPrime)
                {
                    primeSum += currentNum;
                }
                else if (isPrime == false)
                {
                    nonPrimeSum += currentNum;
                }

                input = Console.ReadLine();
            }

                Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
                Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");          

        }
    }
}
