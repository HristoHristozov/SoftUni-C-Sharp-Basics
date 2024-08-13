namespace _01.USDToBGN
{
    public class Program
    {
        static void Main()
        {
            decimal usd = decimal.Parse(Console.ReadLine());
            decimal bgn = usd * 1.79549m;
            Console.WriteLine(bgn);
        }
    }
}
