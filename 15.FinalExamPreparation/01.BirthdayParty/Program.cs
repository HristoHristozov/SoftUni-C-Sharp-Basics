using System;

namespace FinalExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double totalMoneyRequired = 0.0;

            double cakePrice = (rent / 100) * 20;
            double drinks = cakePrice - ((cakePrice / 100) * 45);
            double entertainers = rent / 3;

            totalMoneyRequired = cakePrice + drinks + entertainers + rent;

            Console.WriteLine(totalMoneyRequired);
        }
    }
}
