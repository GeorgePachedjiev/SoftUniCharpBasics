using System;
using System.Collections.Generic;
using System.Linq;

namespace qewewq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int Workers = int.Parse(Console.ReadLine());
            int biscuitsSecondFactory = int.Parse(Console.ReadLine());
            decimal Factory1Sum = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    Factory1Sum += Math.Floor((Workers * biscuitsPerDay) * 0.75m);
                }
                else
                {
                    Factory1Sum += Workers * biscuitsPerDay;
                }
            }
            Console.WriteLine($"You have produced {Factory1Sum} biscuits for the past nibth.");
            if (Factory1Sum > biscuitsSecondFactory)
            {
                int persentage = (int)(Factory1Sum - biscuitsSecondFactory;

                Console.WriteLine($"You produce {persentage} percent more biscuits.");
            }
            else
            {
               // Console.WriteLine($"You produce {} percent less biscuits.");
            }
        }
    }
}