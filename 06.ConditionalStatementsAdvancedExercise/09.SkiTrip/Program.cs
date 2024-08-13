using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var daysForVacancy = int.Parse(Console.ReadLine());
            var roomType = Console.ReadLine();
            var evaluation = Console.ReadLine();

            var sumWithoutEvaluation = 0.0;
            var endSum = 0.0;

            var nightsSpends = daysForVacancy - 1;


            if (roomType == "room for one person")
            {
                sumWithoutEvaluation = 18.00 * nightsSpends;
                if (evaluation == "positive")
                {
                    endSum = sumWithoutEvaluation + (sumWithoutEvaluation * 0.25);
                }

                else if (evaluation == "negative")
                {
                    endSum = sumWithoutEvaluation - (sumWithoutEvaluation * 0.10);
                }

            }

            else if (roomType == "apartment")
            {
                sumWithoutEvaluation = 25.00 * nightsSpends;

                if (daysForVacancy < 10)
                {
                    endSum = sumWithoutEvaluation - (sumWithoutEvaluation * 0.30);
                }

                else if (daysForVacancy >= 10 && daysForVacancy <= 15)
                {
                    endSum = sumWithoutEvaluation - (sumWithoutEvaluation * 0.35);
                }

                else if (daysForVacancy > 15)
                {
                    endSum = sumWithoutEvaluation - (sumWithoutEvaluation * 0.50);
                }

                if (evaluation == "positive")
                {
                    endSum = endSum + (endSum * 0.25);
                }

                if (evaluation == "negative")
                {
                    endSum = endSum - (endSum * 0.10);
                }
            }

            else if (roomType == "president apartment")
            {
                sumWithoutEvaluation = 35.00 * nightsSpends;

                if (daysForVacancy < 10)
                {
                    endSum = sumWithoutEvaluation - (sumWithoutEvaluation * 0.10);
                }

                else if (daysForVacancy >= 10 && daysForVacancy <= 15)
                {
                    endSum = sumWithoutEvaluation - (sumWithoutEvaluation * 0.15);
                }

                else if (daysForVacancy > 15)
                {
                    endSum = sumWithoutEvaluation - (sumWithoutEvaluation * 0.20);
                }

                if (evaluation == "positive")
                {
                    endSum = endSum + (endSum * 0.25);
                }

                if (evaluation == "negative")
                {
                    endSum = endSum - (endSum * 0.10);
                }
            }

            Console.WriteLine("{0:F2}", endSum);

        }
    }
}
