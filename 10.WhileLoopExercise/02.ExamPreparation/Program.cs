using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var badGrades = int.Parse(Console.ReadLine());
            string input = "";

            int allGradesCount = 0;

            double gradesSum = 0.0;
            int problemsCount = 0;

            string lastProblem = "";

            int badGradesCount = 0;
            while ((input = Console.ReadLine()) != "Enough")
            {
                lastProblem = input;
                input = Console.ReadLine();               
                problemsCount++;
                int grade = int.Parse(input);
                if (grade <= 4)
                {
                    badGradesCount++;
                    if (badGrades == badGradesCount)
                    {
                        break;
                    }
                }
                allGradesCount++;
                gradesSum += grade;


            }


            if (badGrades == badGradesCount)
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }
            else
            {
                double averageSum = gradesSum / allGradesCount;
                Console.WriteLine($"Average score: {averageSum:F2}");
                Console.WriteLine($"Number of problems: {problemsCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }




        }
    }
}
