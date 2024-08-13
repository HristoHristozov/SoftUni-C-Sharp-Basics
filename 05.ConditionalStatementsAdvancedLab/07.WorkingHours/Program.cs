using System;

namespace _07.WorkingHours
{
    public class Program
    {
        static void Main()
        {
            double hour = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (hour >= 10 && hour <= 18)
            {
                if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday" || dayOfWeek == "Saturday")
                {
                    Console.WriteLine("open");
                    return;
                }
            }
            Console.WriteLine("closed");
        }
    }
}
