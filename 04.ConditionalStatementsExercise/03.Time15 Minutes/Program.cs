namespace _03.Time15_Minutes
{
    public class Program
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 15;
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;

            }
            if (hours > 23)
            {
                hours = 0;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else Console.WriteLine($"{hours}:{minutes}");
        }
    }
}