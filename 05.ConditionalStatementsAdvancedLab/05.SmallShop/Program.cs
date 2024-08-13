using System;

namespace _05.SmallShop
{
    public class Program
    {
        static void Main()
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            var productQuantity = double.Parse(Console.ReadLine());

            if (city == "Sofia") 
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(0.5 * productQuantity);
                        break;
                    case "water":
                        Console.WriteLine(0.8 * productQuantity);
                        break;
                    case "beer":
                        Console.WriteLine(1.2 * productQuantity);
                        break;
                    case "sweets":
                        Console.WriteLine(1.45 * productQuantity);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.60 * productQuantity);
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(0.4 * productQuantity);
                        break;
                    case "water":
                        Console.WriteLine(0.7 * productQuantity);
                        break;
                    case "beer":
                        Console.WriteLine(1.15 * productQuantity);
                        break;
                    case "sweets":
                        Console.WriteLine(1.30 * productQuantity);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.50 * productQuantity);
                        break;
                }
            }

            else if (city == "Varna")
            {
                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(0.45 * productQuantity);
                        break;
                    case "water":
                        Console.WriteLine(0.70 * productQuantity);
                        break;
                    case "beer":
                        Console.WriteLine(1.10 * productQuantity);
                        break;
                    case "sweets":
                        Console.WriteLine(1.35 * productQuantity);
                        break;
                    case "peanuts":
                        Console.WriteLine(1.55 * productQuantity);
                        break;
                }
            }
        }
    }
}
