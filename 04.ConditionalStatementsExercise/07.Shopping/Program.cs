namespace _07.Shopping
{
    public class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            var gpuCount = int.Parse(Console.ReadLine());
            var cpuCount = int.Parse(Console.ReadLine());
            var ramCount = int.Parse(Console.ReadLine());

            double gpuPrice = gpuCount * 250;
            double cpuPrice = (gpuPrice * 0.35) * cpuCount;
            double ramPrice = (gpuPrice * 0.10) * ramCount;

            double sum = gpuPrice + cpuPrice + ramPrice;


            if (gpuCount > cpuCount)
            {
                sum = sum - (sum * 0.15);

                if (budget >= sum)
                {
                    Console.WriteLine($"You have {budget - sum:F2} leva left!");
                    return;
                }
                Console.WriteLine($"Not enough money! You need {sum - budget:F2} leva more!");
            }

            else
            {
                if (budget >= sum)
                {
                    Console.WriteLine($"You have {budget - sum:F2} leva left!");
                    return;
                }
                Console.WriteLine($"Not enough money! You need {sum - budget:F2} leva more!");
            }
        }
    }
}