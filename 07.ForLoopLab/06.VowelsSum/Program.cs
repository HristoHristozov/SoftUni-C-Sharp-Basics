﻿using System;

namespace _06.VowelsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                switch (currentLetter) 
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                }             
            }

            Console.WriteLine(sum);

        }
    }
}
