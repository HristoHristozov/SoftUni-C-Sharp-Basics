using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var studentName = Console.ReadLine();

            double sum = 0.0;
            int grades = 0;
            int lowGrade = 0;

            while (true)
            {
                double yearGrades = double.Parse(Console.ReadLine());
                if (yearGrades >= 4.00) 
                {
                    sum += yearGrades;
                    grades++;
                }

                if (yearGrades < 4.00)
                {
                    lowGrade++;
                    grades++;
                    sum += yearGrades;
                }

                if (yearGrades < 4.00 && lowGrade > 1)
                {
                    Console.WriteLine($"{studentName} has been excluded at {grades-1} grade");
                    break;
                }

                if (grades >= 12)
                {
                    Console.WriteLine($"{studentName} graduated. Average grade: {sum/grades:F2}");
                    break;
                }
            }

        }
    }
}
