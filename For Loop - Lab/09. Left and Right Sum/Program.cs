using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());

            int sumNumberCount = 0;
            int sumNumberCount2 = 0;

            for (int i = 0; i < numberCount; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sumNumberCount += n;
            }

            for (int i = 0; i < numberCount; i++)
            {
                int n = int.Parse(Console.ReadLine());
                sumNumberCount2 += n;
            }

            int diff = Math.Abs(sumNumberCount - sumNumberCount2);
            if (sumNumberCount == sumNumberCount2)
            {
                Console.WriteLine($"Yes, sum = {sumNumberCount}");
            }

            else
            {
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
