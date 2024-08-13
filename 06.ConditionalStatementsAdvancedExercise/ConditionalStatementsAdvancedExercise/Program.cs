using System;

namespace ConditionalStatementsAdvancedExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var projections = Console.ReadLine();
            var columns = int.Parse(Console.ReadLine());
            var rows = int.Parse(Console.ReadLine());

            switch (projections)
            {
                case "Premiere" :
                    Console.WriteLine("{0:F2}", (12.00 * rows * columns));
                    break;
                case "Normal":
                    Console.WriteLine("{0:F2}", (7.50 * rows * columns));
                    break;
                case "Discount":
                    Console.WriteLine("{0:F2}", (5.00 * rows * columns));
                    break;
            }
        }
    }
}
