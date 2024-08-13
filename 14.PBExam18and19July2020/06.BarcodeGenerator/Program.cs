using System;

namespace _06.BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startBarcode = int.Parse(Console.ReadLine());
            int endBarcode = int.Parse(Console.ReadLine());

            
            for (int i = startBarcode; i <= endBarcode; i++)
            {
                bool isSpecial = true;
                int number = i;
                while (isSpecial && number != 0)
                {
                    int lastDigit = number % 10;
                    if (lastDigit % 2 == 0 || lastDigit == 0)
                    {
                        isSpecial = false;
                        
                    }

                    number /= 10;
                    
                }
                if (isSpecial)
                {
                    Console.WriteLine($"{i} ");
                }
            }

            

        }
    }
}
