using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var groupsCount = int.Parse(Console.ReadLine());
            int musala = 0, monblan = 0, kilimandjaro = 0, k2 = 0, everest = 0;
            int peopleSum = 0;

            for (int i = 1; i <= groupsCount; i++)
            {
                var people = int.Parse(Console.ReadLine());
                peopleSum += people;
                if (people <= 5)
                {
                    musala += people;
                }
                else if (people < 13)
                {
                    monblan += people;
                }
                else if (people < 26)
                {
                    kilimandjaro += people;
                }
                else if (people < 41)
                {
                    k2 += people;
                }
                else everest += people;

            }

            Console.WriteLine($"{(double)musala / peopleSum * 100:F2}%");
            Console.WriteLine($"{(double)monblan / peopleSum * 100:F2}%");
            Console.WriteLine($"{(double)kilimandjaro / peopleSum * 100:F2}%");
            Console.WriteLine($"{(double)k2 / peopleSum * 100:F2}%");
            Console.WriteLine($"{(double)everest / peopleSum * 100:F2}%");

        }
    }
}
