﻿using System;

namespace _01.ReadText
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Stop") 
                {
                    break;
                }
                Console.WriteLine(input);
            }


        }
    }
}
