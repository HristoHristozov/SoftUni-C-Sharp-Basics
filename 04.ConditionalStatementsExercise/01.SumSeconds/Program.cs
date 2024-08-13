public class Program
{
    static void Main()
    {
        int firstInput = int.Parse(Console.ReadLine());
        int secondInput = int.Parse(Console.ReadLine());
        int thirdInput = int.Parse(Console.ReadLine());

        int sum = firstInput + secondInput + thirdInput;

        int seconds = sum % 60;
        int minutes = sum / 60;

        if (seconds < 10)
        {
            Console.WriteLine($"{minutes}:0{seconds}");
        }
        else
        {
            Console.WriteLine($"{minutes}:{seconds}");
        }
    }
}