﻿using System;

namespace number2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                if (i % (3 * 7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
