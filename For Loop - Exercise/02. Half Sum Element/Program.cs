using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            int maxNum = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                sum += numbers;

                if (numbers > maxNum)
                {
                    maxNum = numbers;
                }

            }

            double sumWithoutMaxNum = sum - maxNum;

            if (sumWithoutMaxNum == maxNum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumWithoutMaxNum}");
            }

            else
            {
                double diff = Math.Abs(sumWithoutMaxNum - maxNum);

                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
