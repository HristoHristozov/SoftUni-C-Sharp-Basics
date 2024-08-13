using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int evaluaters = int.Parse(Console.ReadLine());

            double actorPoints = points;

            for (int i = 1; i <= evaluaters; i++)
            {
                string evaluaterName = Console.ReadLine();
                var evaluaterMark = double.Parse(Console.ReadLine());
           
                
                actorPoints += (evaluaterMark * evaluaterName.Length)/2;

                if (actorPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {actorPoints:F1}!");
                    break;
                }
            }

            if (actorPoints < 1250.5)
            {
                double diff = 1250.5 - actorPoints;
                Console.WriteLine($"Sorry, {actorName} you need {diff:F1} more!");
            }
        }
    }
}
