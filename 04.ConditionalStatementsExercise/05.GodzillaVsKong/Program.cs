public class Program
{
    static void Main()
    {
        double movieBudget = double.Parse(Console.ReadLine());
        double extraCount = double.Parse(Console.ReadLine());
        double clothingPricePerExtra = double.Parse(Console.ReadLine());

        double decorPrice = movieBudget * 0.10;

        if (extraCount > 150)
        {
            double clothingPrice = clothingPricePerExtra * extraCount;
            double clothingPriceDisc = clothingPrice - (clothingPrice * 0.10);
            double moviePrice = decorPrice + clothingPriceDisc;
            if (movieBudget >= moviePrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", movieBudget - moviePrice);
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", Math.Abs(movieBudget - moviePrice));
            }
        }

        else
        {
            double clothingPrice = clothingPricePerExtra * extraCount;
            double moviePrice = decorPrice + clothingPrice;
            if (movieBudget >= moviePrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", movieBudget - moviePrice);
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", Math.Abs(movieBudget - moviePrice));
            }
        }
    }
}