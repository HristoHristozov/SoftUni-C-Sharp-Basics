using System;

namespace _04.GrandpaStavri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int daysCount = int.Parse(Console.ReadLine());

            double allRakiaLitre = 0.0;
            double allDegrees = 0.0;

            for (int i = 1; i <= daysCount; i++)
            {
                double rakiaAmount = double.Parse(Console.ReadLine());
                double spiritDegrees = double.Parse(Console.ReadLine());

                allRakiaLitre += rakiaAmount;
                allDegrees += rakiaAmount * spiritDegrees;
            }
            double degreesAverage = 0.0;
            degreesAverage = Math.Round(allDegrees / allRakiaLitre,2);
            Console.WriteLine($"Liter: {allRakiaLitre:F2}");
            Console.WriteLine($"Degrees: {degreesAverage:F2}");
            if (degreesAverage < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (degreesAverage >= 38 && degreesAverage <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (degreesAverage > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
