using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //град / продукт  coffee   water   beer   sweets  peanuts
            //Sofia            0.50    0.80    1.20    1.45    1.60
            //Plovdiv          0.40    0.70    1.15    1.30    1.50
            //Varna            0.45    0.70    1.10    1.35    1.55

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double kolichestvo = double.Parse(Console.ReadLine());
            double price = 0;
            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    price = 0.50;
                }
                else if (city == "Plovdiv")
                {
                    price = 0.40;
                }
                else if (city == "Varna")
                {
                    price = 0.45;
                }
            }

            if (product == "water")
            {
                if (city == "Sofia")
                {
                    price = 0.80;
                }
                else if (city == "Plovdiv")
                {
                    price = 0.70;
                }
                else if (city == "Varna")
                {
                    price = 0.70;
                }
            }

            if (product == "beer")
            {
                if (city == "Sofia")
                {
                    price = 1.20;
                }
                else if (city == "Plovdiv")
                {
                    price = 1.15;
                }
                else if (city == "Varna")
                {
                    price = 1.10;
                }
            }

            if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    price = 1.45;
                }
                else if (city == "Plovdiv")
                {
                    price = 1.30;
                }
                else if (city == "Varna")
                {
                    price = 1.35;
                }
            }

            if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    price = 1.60;
                }
                else if (city == "Plovdiv")
                {
                    price = 1.50;
                }
                else if (city == "Varna")
                {
                    price = 1.55;
                }
            }


            double smetka = price * kolichestvo;
            Console.WriteLine(smetka);
        }
    }
}
