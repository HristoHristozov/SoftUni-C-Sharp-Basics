using System;

namespace _10.InvalidNumber
{
    public class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (number >= 100 && number <= 200 || number == 0)
            {
                Console.WriteLine("");
                return;
            }
            Console.WriteLine("invalid");
        }
    }
}
