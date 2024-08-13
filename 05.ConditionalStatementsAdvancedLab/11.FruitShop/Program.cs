using System;

namespace _11.FruitShop
{
    public class Program
    {
        static void Main()
        {
            var product = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            var productQuantity = double.Parse(Console.ReadLine());

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (product)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", 2.50 * productQuantity);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", 1.20 * productQuantity);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", 0.85 * productQuantity);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", 1.45 * productQuantity);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", 2.70 * productQuantity);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", 5.50 * productQuantity);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", 3.85 * productQuantity);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (product)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", 2.70 * productQuantity);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", 1.25 * productQuantity);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", 0.90 * productQuantity);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", 1.60 * productQuantity);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", 3.00 * productQuantity);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", 5.60 * productQuantity);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", 4.20 * productQuantity);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else Console.WriteLine("error");
        }
    }
}
