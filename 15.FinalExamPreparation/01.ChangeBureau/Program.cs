using System;

namespace _01.ChangeBureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitcoinsAvailable = int.Parse(Console.ReadLine());
            var chineseYuan = double.Parse(Console.ReadLine());
            var comissionInPercent = double.Parse(Console.ReadLine());

            double bitcoinInBgn = 1168 * bitcoinsAvailable;
            double chineseYuanInBgn = (chineseYuan * 0.15 )* 1.76;

            double sumInEuro = (bitcoinInBgn + chineseYuanInBgn) / 1.95;
            double sumInEuroWithComission = sumInEuro - (sumInEuro * comissionInPercent / 100);

            Console.WriteLine($"{sumInEuroWithComission:F2}");
        }
    }
}
