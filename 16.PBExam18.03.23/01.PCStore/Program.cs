using System;

namespace PBExam18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cpuPriceDollar = double.Parse(Console.ReadLine());
            double gpuPriceDollar = double.Parse(Console.ReadLine());
            double ramPriceDollar = double.Parse(Console.ReadLine());

            int ramCount = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double cpuPriceLeva = cpuPriceDollar * 1.57;
            double gpuPriceLeva = gpuPriceDollar * 1.57;
            double ramPriceLeva = (ramPriceDollar * 1.57) * ramCount;

            double discoutedGPUandCPU = (cpuPriceLeva + gpuPriceLeva) - ((cpuPriceLeva + gpuPriceLeva) * discount);

            double sum = discoutedGPUandCPU + ramPriceLeva;

            Console.WriteLine($"Money needed - {sum:F2} leva.");
        }
    }
}
