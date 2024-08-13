using System;

namespace _06.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxFirstNum = int.Parse(Console.ReadLine());
            int maxSecondNum = int.Parse(Console.ReadLine());
            int maxThirdNum = int.Parse(Console.ReadLine());


            
            for (int firstNum = 1; firstNum <= maxFirstNum; firstNum++)
            {
                for (int secondNum = 1; secondNum <= maxSecondNum; secondNum++)
                {
                    for (int thirdNum = 1; thirdNum <= maxThirdNum; thirdNum++)
                    {

                        if (firstNum % 2 == 0 && thirdNum % 2 == 0)
                        {
                            if (secondNum == 2 || secondNum == 3 || secondNum == 5 || secondNum == 7)
                            {
                                Console.Write($"{firstNum} {secondNum} {thirdNum}");
                                Console.WriteLine();
                            }
                            
                        }
                    }
                }             
            }
        }
    }
}
