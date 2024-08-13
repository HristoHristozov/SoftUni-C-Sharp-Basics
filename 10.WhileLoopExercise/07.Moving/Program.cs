using System;
using System.ComponentModel;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int freeCubicSpace = width * height * lenght;

            int remainingSpace = 0;
            while (freeCubicSpace >= remainingSpace)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                else
                {
                    int box = int.Parse(input);
                    remainingSpace += box;
                }

            }

            if (freeCubicSpace >= remainingSpace)
            {
                int spaceLeft = freeCubicSpace - remainingSpace;
                Console.WriteLine($"{spaceLeft} Cubic meters left.");
            }
            else
            {
                int spaceleft = Math.Abs(freeCubicSpace - remainingSpace);
                Console.WriteLine($"No more free space! You need {spaceleft} Cubic meters more.");
            }
        }
    }
}
