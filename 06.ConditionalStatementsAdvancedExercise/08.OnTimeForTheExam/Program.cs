using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var examHour = int.Parse(Console.ReadLine());
            var examMinute = int.Parse(Console.ReadLine());
            var hourOfArrival = int.Parse(Console.ReadLine());
            var minuteOfArrival = int.Parse(Console.ReadLine());

            string late = "Late";
            string onTime = "On Time";
            string early = "Early";

            int examTime = (examHour * 60) + examMinute; // 9:30 == 570
            int arrivalTime = (hourOfArrival * 60) + minuteOfArrival; // 9:30 == 540
            int totalMinutes = arrivalTime - examTime;

            string studentArrival = late;
            if (totalMinutes < -30)
            {
                studentArrival = early;
            }

            else if (totalMinutes >= -30 && totalMinutes <= 0)
            {
                studentArrival = onTime;
            }

            string result = "";

            if (totalMinutes != 0)
            {
                int hoursDiff = Math.Abs(totalMinutes / 60);
                int minutesDiff = Math.Abs(totalMinutes % 60);

                if (hoursDiff > 0)
                {
                    result = string.Format("{0}:{1:00} hours", hoursDiff, minutesDiff);
                }

                else
                {
                    result = minutesDiff + " minutes";
                }

                if (totalMinutes < 0)
                {
                    result += " before the start";
                }

                else
                {
                    result += " after the start";
                }
            }

            Console.WriteLine(studentArrival);
            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
