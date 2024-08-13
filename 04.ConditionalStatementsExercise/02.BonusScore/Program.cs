public class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double bonus = 0.0;

        if (number <= 100)
        {
            if (number % 2 == 0)
            {
                bonus = 5 + 1;
                Console.WriteLine(bonus);
                Console.WriteLine(number + bonus);
            }
            else if (number % 5 == 0)
            {
                bonus = 5 + 2;
                Console.WriteLine(bonus);
                Console.WriteLine(number + bonus);
            }
            else
            {
                bonus = 5;
                Console.WriteLine(bonus);
                Console.WriteLine(bonus + number);

            }
        }
        else if (number > 100 && number <= 1000)
        {
            if (number % 2 == 0)
            {
                bonus = (number * 0.20) + 1;
                Console.WriteLine(bonus);
                Console.WriteLine(number + bonus);
            }
            else if (number % 5 == 0)
            {
                bonus = (number * 0.20) + 2;
                Console.WriteLine(bonus);
                Console.WriteLine(number + bonus);
            }
            else
            {
                bonus = number * 0.20;
                Console.WriteLine(bonus);
                Console.WriteLine(number + bonus);
            }

        }
        else if (number > 1000)
        {
            if (number % 2 == 0)
            {
                bonus = (number * 0.10) + 1;
                Console.WriteLine(bonus);
                Console.WriteLine(number + bonus);
            }
            else if (number % 5 == 0)
            {
                bonus = (number * 0.10) + 2;
                Console.WriteLine(bonus);
                Console.WriteLine(number + bonus);
            }
            else
            {
                bonus = number * 0.10;
                Console.WriteLine(bonus);
                Console.WriteLine(bonus + number);
            }
        }
    }
}