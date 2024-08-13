using System;

namespace _04.PersonalType
{
    public class Program
    {
        static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine();

            if (sex == "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                    return;
                }
                Console.WriteLine("Mr.");
            }

            else
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                    return;
                }
                Console.WriteLine("Ms.");
            }
        }
    }
}
