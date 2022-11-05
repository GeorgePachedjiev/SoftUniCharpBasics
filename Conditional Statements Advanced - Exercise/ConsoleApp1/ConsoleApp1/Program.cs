using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //int counter = 0;
            //double sum = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());

            //    if (array[i] % 2 == 0)
            //    {
            //        counter++;
            //    }
            //    sum += array[i];
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(counter);

            //int[] array = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();

            //Console.WriteLine(String.Join(" || ", array));


            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            double counter = 0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 0)
                {
                    counter++;
                }
                sum += array[i];
            }
            Console.WriteLine(counter);
            Console.WriteLine(sum);
        }
    }
}
