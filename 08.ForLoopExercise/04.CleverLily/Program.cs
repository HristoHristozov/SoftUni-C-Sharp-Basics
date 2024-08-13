using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double toys = 0.0;
            double moneyForBD = 0.0;
            double toysSum = 0.0;
            int moneyFromBro = lilyAge / 2;
            double moneySaved = 0.0;
            double sum = 0.0;

            for (int i = 1; i <= lilyAge; i++)
            {
                
                if (i % 2 == 0)
                {
                    int moneyIncrease = i / 2;
                    moneyForBD += 10 * moneyIncrease;
                }

                else
                {
                    toys++;
                }
            }

            toysSum = toys * toyPrice;
            moneySaved = (moneyForBD + toysSum) - moneyFromBro;
            sum = moneySaved - washingMachinePrice;
            if (sum >= 0)
            {
                Console.WriteLine("Yes! {0:F2}", sum);
            }
            else
            {
                Console.WriteLine("No! {0:F2}", Math.Abs(sum));
            }
        }
    }
}
