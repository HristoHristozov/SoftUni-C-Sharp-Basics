using System;

namespace _06.NumberInRange
{
    public class Program
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (number >= -100 && number !=0 && number <= 100)
            {
                Console.WriteLine("Yes");
                return;
            }
            Console.WriteLine("No");
        }
    }
}
