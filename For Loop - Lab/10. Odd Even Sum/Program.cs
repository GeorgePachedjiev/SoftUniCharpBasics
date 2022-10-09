using System;

namespace _10._Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumOddNumbers = 0;
            double sumEvenNumbers = 0;

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEvenNumbers += numbers;
                }
                else
                {
                    sumOddNumbers += numbers;
                }
            }

            double diff = Math.Abs(sumOddNumbers - sumEvenNumbers);

            if (sumEvenNumbers == sumOddNumbers)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumEvenNumbers}");
            }

            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
