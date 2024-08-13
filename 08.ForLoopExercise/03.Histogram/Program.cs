using System;
using System.Transactions;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum < 200)
                {
                    p1 += 1;
                }
                else if (currentNum >= 200 && currentNum < 400)
                {
                    p2 += 1;
                }
                else if (currentNum >= 400 && currentNum < 600)
                {
                    p3 += 1;
                }
                else if (currentNum >= 600 && currentNum < 800)
                {
                    p4 += 1;
                }
                else if (currentNum >= 800)
                {
                    p5 += 1;
                }
            }
            double p1Percent = p1 * 100 / n;
            double p2Percent = p2 * 100 / n;
            double p3Percent = p3 * 100 / n;
            double p4Percent = p4 * 100 / n;
            double p5Percent = p5 * 100 / n;

            Console.WriteLine("{0:F2}%",p1Percent);
            Console.WriteLine("{0:F2}%", p2Percent);
            Console.WriteLine("{0:F2}%", p3Percent);
            Console.WriteLine("{0:F2}%", p4Percent);
            Console.WriteLine("{0:F2}%", p5Percent);
        }
    }
}
