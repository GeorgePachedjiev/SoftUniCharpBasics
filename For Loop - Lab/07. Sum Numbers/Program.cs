﻿using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
