using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (chislo <= 100)
            {
                bonus = 5;
            }
            else if (chislo > 1000)
            {
                bonus = chislo * 0.10;
            }

            else
            {
                bonus = chislo * 0.20;
            }


            if (chislo % 2 == 0)
            {
                bonus += 1;
            }
            else if (chislo % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(chislo + bonus);
        }
    }
}
