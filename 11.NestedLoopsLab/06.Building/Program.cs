using System;

namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());

            for (int floor = floors; floor >= 1; floor--)
            {
                for (int apartament = 0; apartament < apartments; apartament++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floors}{apartament} ");
                    }

                    else if (floor % 2 == 1)
                    {
                        Console.Write($"A{floor}{apartament} ");
                    }

                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{apartament} ");
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
