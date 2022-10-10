using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lillyAge = int.Parse(Console.ReadLine());
            double peralnqCena = double.Parse(Console.ReadLine());
            double toyPrice = int.Parse(Console.ReadLine());
            double budget = 0;
            double toyCounter = 0;
            double stake = 0;

            for (int i = 1; i <= lillyAge; i++)
            {

                if (i % 2 == 0)
                {


                    stake += 10;
                    budget = budget + stake;
                    budget -= 1;
                }

                else
                {
                    toyCounter++;
                }


            }
            double toyMoney = toyPrice * toyCounter;
            budget += toyMoney;



            if (budget >= peralnqCena)
            {
                double diff = budget - peralnqCena;
                Console.WriteLine($"Yes! {diff:f2}");
            }

            else
            {
                double oshte = peralnqCena - budget;
                Console.WriteLine($"No! {oshte:f2}");
            }
        }
    }
}
