using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double rose = 5;
            const double dalia = 3.80;
            const double lale = 2.80;
            const double narcis = 3;
            const double gladiola = 2.50;

            string vidcvete = Console.ReadLine();
            int broicvetq = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double prize = 0;
            double obsto = 0;

            if (vidcvete == "Roses")
            {
                prize = rose;
                obsto = prize * broicvetq;
                if (broicvetq > 80)
                {
                    obsto *= 0.9;
                }

            }
            else if (vidcvete == "Dahlias")
            {
                prize = dalia;
                obsto = prize * broicvetq;
                if (broicvetq > 90)
                {
                    obsto *= 0.85;
                }
            }
            else if (vidcvete == "Tulips")
            {
                prize = lale;
                obsto = prize * broicvetq;
                if (broicvetq > 80)
                {
                    obsto *= 0.85;
                }
            }
            else if (vidcvete == "Narcissus")
            {
                prize = narcis;
                obsto = prize * broicvetq;
                if (broicvetq < 120)
                {
                    obsto *= 1.15;
                }

            }
            else if (vidcvete == "Gladiolus")
            {
                prize = gladiola;
                obsto = prize * broicvetq;
                if (broicvetq < 80)
                {
                    obsto *= 1.20;
                }
            }


            double ostatak = Math.Abs(budget - obsto);
            if (obsto <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {broicvetq} {vidcvete} and {ostatak:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {ostatak:f2} leva more.");
            }
        }
    }
}
