using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var password = Console.ReadLine();

            var input = Console.ReadLine();

            while (input != password)
            {
                input = Console.ReadLine();
            }

            Console.WriteLine("Welcome {0}!",username);
        }
    }
}
