using System;

namespace _06._Vowels_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;

            for (int i = 0; i < name.Length; i++)
            {
                char namePut = name[i];

                if (namePut == 'a')
                {
                    sum += 1;
                }

                else if (namePut == 'e')
                {
                    sum += 2;
                }

                if (namePut == 'i')
                {
                    sum += 3;
                }

                if (namePut == 'o')
                {
                    sum += 4;
                }

                if (namePut == 'u')
                {
                    sum += 5;
                }

            }
            Console.WriteLine(sum);
        }
    }
}
