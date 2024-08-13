public class Program
{
    static void Main()
    {
        double tripPrice = double.Parse(Console.ReadLine());
        double jigsaws = double.Parse(Console.ReadLine());
        double dolls = double.Parse(Console.ReadLine());
        double teddyBears = double.Parse(Console.ReadLine());
        double minions = double.Parse(Console.ReadLine());
        double trucks = double.Parse(Console.ReadLine());

        double toysSum = jigsaws + dolls + teddyBears + minions + trucks;
        double toysPrice = (jigsaws * 2.6) + (dolls * 3) + (teddyBears * 4.1) + (minions * 8.20) + (trucks * 2);

        if (toysSum >= 50)
        {
            double discount = toysPrice * 0.25;
            toysPrice = toysPrice - discount;
            toysPrice = toysPrice - (toysPrice * 0.10);
            double moneyForTrip = tripPrice - toysPrice;
            if (moneyForTrip <= 0)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", Math.Abs(moneyForTrip));
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", Math.Abs(moneyForTrip));
            }

        }

        else
        {
            double rent = toysPrice * 0.10;
            toysPrice -= rent;
            double moneyForTrip = tripPrice - toysPrice;
            if (moneyForTrip <= 0)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", Math.Abs(moneyForTrip));
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", Math.Abs(moneyForTrip));
            }
        }

    }
}