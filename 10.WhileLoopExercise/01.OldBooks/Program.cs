using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = Console.ReadLine();
          
            int checkedBooks = 0;
            bool isFound = false;

            while (true)
            {
                var currentBook = Console.ReadLine();
                checkedBooks++;
                if (currentBook == "No More Books")
                {
                    break;
                }
                if (currentBook == book)
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {checkedBooks -1} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks -1} books.");
            }



        }
    }
}
