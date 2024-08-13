public class Program
{
    static void Main()
    {
        double swimRecord = double.Parse(Console.ReadLine());
        double metersToSwim = double.Parse(Console.ReadLine());
        double secondsFor1Meter = double.Parse(Console.ReadLine());

        double swimTimeInSec = metersToSwim * secondsFor1Meter;
        double secondsToAdd = Math.Floor(metersToSwim / 15) * 12.5;
        double summedTimeInSec = swimTimeInSec + secondsToAdd;


        if (summedTimeInSec < swimRecord)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {summedTimeInSec:F2} seconds.");
            return;
        }

        double requiredSeconds = summedTimeInSec - swimRecord;
        Console.WriteLine($"No, he failed! He was {requiredSeconds:F2} seconds slower.");
    }
}