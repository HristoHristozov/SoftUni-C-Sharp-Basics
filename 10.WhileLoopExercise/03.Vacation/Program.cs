using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal tripMoneyRequired = decimal.Parse(Console.ReadLine());

            decimal ownedMoney = decimal.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;
            while (ownedMoney < tripMoneyRequired && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                decimal money = decimal.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "spend")
                {
                    spendingCounter++;
                    ownedMoney -= money;                                    
                }
                else if (command == "save")
                {
                    ownedMoney += money;
                    spendingCounter = 0;
                }
                if (ownedMoney < 0)
                {
                    ownedMoney = 0;
                }
            }

            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine("{0}",daysCounter);
            }
            if (ownedMoney >= tripMoneyRequired)
            {
                Console.WriteLine("You saved the money for {0} days.",daysCounter);
            }
        }
    }
}
