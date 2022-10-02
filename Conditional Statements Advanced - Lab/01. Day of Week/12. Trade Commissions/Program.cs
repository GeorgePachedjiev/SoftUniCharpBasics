using System;

namespace _12._Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double prodashbi = double.Parse(Console.ReadLine());

            double commision = 0;

            if (prodashbi >= 0 && prodashbi <= 500)
            {
                if (city == "Sofia")
                {
                    commision = 0.05;
                }
                else if (city == "Varna")
                {
                    commision = 0.045;
                }
                else if (city == "Plovdiv")
                {
                    commision = 0.055;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (prodashbi > 500 && prodashbi <= 1000)
            {
                if (city == "Sofia")
                {
                    commision = 0.07;
                }
                else if (city == "Varna")
                {
                    commision = 0.075;
                }
                else if (city == "Plovdiv")
                {
                    commision = 0.08;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (prodashbi > 1000 && prodashbi <= 10000)
            {
                if (city == "Sofia")
                {
                    commision = 0.08;
                }
                else if (city == "Varna")
                {
                    commision = 0.1;
                }
                else if (city == "Plovdiv")
                {
                    commision = 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (prodashbi > 10000)
            {
                if (city == "Sofia")
                {
                    commision = 0.12;
                }
                else if (city == "Varna")
                {
                    commision = 0.13;
                }
                else if (city == "Plovdiv")
                {
                    commision = 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            double zaplata = prodashbi * commision;
            if (zaplata != 0)
            {
                Console.WriteLine($"{zaplata:f2}");
            }
        }
    }
}
