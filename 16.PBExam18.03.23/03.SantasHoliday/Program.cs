using System;

namespace _03.SantasHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stayDays = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string mark = Console.ReadLine();

            int nights = stayDays - 1;

            double staySum = 0.0;

            if (typeOfRoom == "room for one person")
            {
                staySum = 18 * nights;

                if (mark == "positive")
                {
                    staySum = staySum + (staySum * 0.25);
                    Console.WriteLine($"{staySum:F2}");
                }
                else
                {
                    staySum = staySum - (staySum * 0.1);
                    Console.WriteLine($"{staySum:F2}");
                }
                
            }

            else if (typeOfRoom == "apartment")
            {
                if (stayDays < 10)
                {
                    staySum = (25 * nights) * 0.7;
                }
                else if (stayDays >= 10 && stayDays < 15)
                {
                    staySum = (25 * nights) * 0.65;
                }
                else if (stayDays > 15)
                {
                    staySum = (25 * nights) * 0.5;
                }
                if (mark == "positive")
                {
                    staySum = staySum + (staySum * 0.25);
                    Console.WriteLine($"{staySum:F2}");
                }
                else
                {
                    staySum = staySum - (staySum * 0.1);
                    Console.WriteLine($"{staySum:F2}");
                }
            }

            else if (typeOfRoom == "president apartment")
            {
                if (stayDays < 10)
                {
                    staySum = (35 * nights) * 0.9;
                }
                else if (stayDays >= 10 && stayDays < 15)
                {
                    staySum = (35 * nights) * 0.85;
                }
                else if (stayDays > 15)
                {
                    staySum = (35 * nights) * 0.8;
                }
                if (mark == "positive")
                {
                    staySum = staySum + (staySum * 0.25);
                    Console.WriteLine($"{staySum:F2}");
                }
                else
                {
                    staySum = staySum - (staySum * 0.1);
                    Console.WriteLine($"{staySum:F2}");
                }
            }


        }
    }
}
