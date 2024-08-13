using System;

namespace _06.BarcodeGeneratorSecond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startBarcode = int.Parse(Console.ReadLine());
            int endBarcode = int.Parse(Console.ReadLine());

            int firstStart = startBarcode / 1000;
            int secondStart = (startBarcode / 100) % 10;
            int thirdStart = (startBarcode / 10) % 10;
            int fourthStart = startBarcode % 10;

            int firstEnd = endBarcode / 1000;
            int secondEnd = (endBarcode / 100) % 10;
            int thirdEnd = (endBarcode / 10) % 10;
            int fourthEnd = endBarcode % 10;

            for (int firstDigit = firstStart; firstDigit <= firstEnd; firstDigit++)
            {
                for (int secondDigit = secondStart; secondDigit <= secondEnd; secondDigit++)
                {
                    for (int thirdDigit = thirdStart; thirdDigit <= thirdEnd; thirdDigit++)
                    {
                        for (int fourthDigit = fourthStart; fourthDigit <= fourthEnd; fourthDigit++)
                        {
                            if (firstDigit % 2 != 0 && secondDigit % 2 != 0 && thirdDigit % 2 != 0 && fourthDigit % 2 != 0)
                            {
                                Console.Write($"{firstDigit}{secondDigit}{thirdDigit}{fourthDigit} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
