public class Program
{
    static void Main()
    {
        var tvSeries = Console.ReadLine();
        var seriesDuration = int.Parse(Console.ReadLine());
        var breakDuration = int.Parse(Console.ReadLine());

        double lunchTime = (1 / 8.0) * breakDuration;
        double relaxTime = (1 / 4.0) * breakDuration;

        double sumTime = lunchTime + relaxTime + seriesDuration;
        double timeLeft = 0;

        if (sumTime <= breakDuration)
        {
            timeLeft = Math.Ceiling(breakDuration - sumTime);
            Console.WriteLine($"You have enough time to watch {tvSeries} and left with {timeLeft} minutes free time.");
            return;
        }

        timeLeft = Math.Ceiling(sumTime - breakDuration);
        Console.WriteLine($"You don't have enough time to watch {tvSeries}, you need {timeLeft} more minutes.");
    }
}