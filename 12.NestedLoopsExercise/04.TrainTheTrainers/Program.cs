using System;
using System.Security;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());           
            string assesment = Console.ReadLine();

            double allGradesCount = 0.0;
            double allGrades = 0.0;


            while (assesment != "Finish")
            {

                double averageGradePerAssessment = 0.0;
                for (int i = 1; i <= juryCount; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    allGrades += currentGrade ;
                    allGradesCount++;
                    averageGradePerAssessment += currentGrade;
                }

                if (averageGradePerAssessment > 0.0)
                {
                    Console.WriteLine($"{assesment} - {averageGradePerAssessment / juryCount:F2}.");
                    averageGradePerAssessment = 0.0;
                }
                    
                    
               
                assesment = Console.ReadLine();
            }

            double averageGrade = allGrades / allGradesCount;
            Console.WriteLine($"Student's final assessment is {averageGrade:F2}.");
            
        }
    }
}
