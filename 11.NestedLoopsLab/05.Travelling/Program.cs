using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                double sum = 0;
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double neededMoney = double.Parse(Console.ReadLine());
                while (sum < neededMoney)
                {
                    double input = double.Parse(Console.ReadLine());
                    sum += input;
                }
                Console.WriteLine($"Going to {destination}!");
            }


        }
    }
}
