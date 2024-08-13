using System;

namespace _06.OperationsBetweenNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstNum = double.Parse(Console.ReadLine());
            var secondNum = double.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());

            double sum = 0.0;

            if (firstNum == 0 || secondNum == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNum, secondNum);
            }

            else if (operand == '+')
            {
                sum = firstNum + secondNum;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", firstNum, operand, secondNum, sum);
                }
                else Console.WriteLine("{0} {1} {2} = {3} - odd", firstNum, operand, secondNum, sum);
            }

            else if (operand == '-')
            {
                sum = firstNum - secondNum;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", firstNum, operand, secondNum, sum);
                }
                else Console.WriteLine("{0} {1} {2} = {3} - odd", firstNum, operand, secondNum, sum);
            }

            else if (operand == '*')
            {
                sum = firstNum * secondNum;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", firstNum, operand, secondNum, sum);
                }
                else Console.WriteLine("{0} {1} {2} = {3} - odd", firstNum, operand, secondNum, sum);
            }

            else if (operand == '/')
            {
                sum = firstNum / secondNum;

                Console.WriteLine("{0} {1} {2} = {3:F2}", firstNum, operand, secondNum, sum);
            }

            else if (operand == '%')
            {
                sum = firstNum % secondNum;
                Console.WriteLine("{0} {1} {2} = {3}", firstNum, operand, secondNum, sum);
            }
        }
    }
}
