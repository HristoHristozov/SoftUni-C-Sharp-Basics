public class Program
{
    static void Main()
    {
        const double dogFoodPrice = 2.5;
        const int catFoodPrice = 4;

        double dogFoodQuantity = double.Parse(Console.ReadLine());
        double catFoodQuantity = double.Parse(Console.ReadLine());

        double bill = (dogFoodPrice * dogFoodQuantity) + (catFoodPrice * catFoodQuantity);
        Console.WriteLine(bill + " lv.");
    }
}
