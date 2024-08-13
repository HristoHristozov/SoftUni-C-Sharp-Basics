using System;

namespace _12.TradeCommissions
{
    public class Program
    {
        static void Main()
        {
            var city = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine("{0:F2}", (sales /100) * 5);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 7);
                }

                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 8);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 12);
                }

                else Console.WriteLine("error");
            }

            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 5.5);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 8);
                }

                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 12);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 14.5);
                }

                else Console.WriteLine("error");
            }

            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 4.5);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 7.5);
                }

                else if (sales > 1000 && sales <= 10000)
                {
                    Console.WriteLine("{0:F2}", (sales / 100) * 10);
                }
                else if (sales > 10000)
                {
                    Console.WriteLine("{0:F2}",(sales / 100) * 13);
                }

                else Console.WriteLine("error");
            }

            else Console.WriteLine("error");
        }
    }
}
