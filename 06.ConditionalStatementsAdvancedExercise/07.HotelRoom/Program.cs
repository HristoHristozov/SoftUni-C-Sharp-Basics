using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var daysSpend = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            if (month == "May" || month == "October")
            {

                studioPrice = 50 * daysSpend;
                apartmentPrice = 65 * daysSpend;
                if (daysSpend > 7 && daysSpend <= 14)
                {
                    studioPrice = studioPrice - (studioPrice * 0.05);
                }

                else if (daysSpend > 14)
                {
                    studioPrice = studioPrice - (studioPrice * 0.30);
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.10);
                }
            }

            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20 * daysSpend;
                apartmentPrice = 68.70 * daysSpend;

                if (daysSpend > 14)
                {
                    studioPrice = studioPrice - (studioPrice * 0.20);
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.10);
                }

            }

            else if (month == "July" || month == "August")
            {
                studioPrice = 76 * daysSpend;
                apartmentPrice = 77 * daysSpend;
                if (daysSpend > 14)
                {
                    apartmentPrice = apartmentPrice - (apartmentPrice * 0.10);
                }


            }

            Console.WriteLine("Apartment: {0:F2} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:F2} lv.", studioPrice);
        }
    }
}
