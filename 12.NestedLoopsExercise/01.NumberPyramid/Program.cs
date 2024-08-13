using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int current = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= input; rows++)
            {
                for (int col = 1; col <= rows; col++)
                {
                    if (current > input)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write($"{current} ");
                    current++;
                }

                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }

        }
    }
}
