using System;

namespace _02.MountainRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeRequiredFor1Meter = double.Parse(Console.ReadLine());

            double allSecondsToClimb = 0.0;
            double metersToAdd = Math.Truncate(distanceInMeters / 50);
            allSecondsToClimb = distanceInMeters * timeRequiredFor1Meter + metersToAdd * 30;

            double secondsRequiredToBeatRecord = allSecondsToClimb - recordInSeconds;
            if (allSecondsToClimb < recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {allSecondsToClimb:F2} seconds.");
            }
            

            else Console.WriteLine($"No! He was {secondsRequiredToBeatRecord:F2} seconds slower.");
        }
    }
}
