using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(ArrayMinMaxSum(array));
        }

        static int ArrayMinMaxSum(int[] array)
        {

            int minN = int.MaxValue;
            int maxN = int.MinValue;
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minN)
                {
                    minN = array[i];
                }
                if(array[i] > maxN)
                {
                    maxN = array[i];
                }
                sum += array[i];
            }
            
             return sum;

            
        }
    }
}
