using System;

namespace _01.AgencyProfit
{
    internal class Program
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            int ticketsForAdults = int.Parse(Console.ReadLine());
            int ticketsForKids = int.Parse(Console.ReadLine());
            double ticketPriceNetForAdults = double.Parse(Console.ReadLine());
            double additionalPrice = double.Parse(Console.ReadLine());

            double adultTicketPriceEndSum = (ticketPriceNetForAdults + additionalPrice) * ticketsForAdults;
            double kidsTicketPriceEndSum = (ticketPriceNetForAdults * 0.3 + additionalPrice) * ticketsForKids;
            

            double profit = (adultTicketPriceEndSum + kidsTicketPriceEndSum) * 0.2;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {profit:F2} lv.");
        }
    }
}
