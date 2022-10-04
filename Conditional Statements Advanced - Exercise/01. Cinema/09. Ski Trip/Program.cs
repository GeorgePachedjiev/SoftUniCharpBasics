using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfDays = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rate = Console.ReadLine();
            int night = countOfDays - 1;
            double pricePerDay = 0.0;

            if (roomType == "room for one person")
            {
                pricePerDay = night * 18.00;
            }
            else if (roomType == "apartment")
            {
                pricePerDay = night * 25.00;
                if (countOfDays > 15)
                {
                    pricePerDay *= 0.50;
                }
                else if (countOfDays >= 10 && countOfDays <= 15)
                {
                    pricePerDay *= 0.65;
                }
                else
                {
                    pricePerDay *= 0.70;
                }
            }
            else if (roomType == "president apartment")
            {
                pricePerDay = night * 35.00;
                if (countOfDays > 15)
                {
                    pricePerDay *= 0.80;
                }
                else if (countOfDays >= 10 && countOfDays <= 15)
                {
                    pricePerDay *= 0.85;
                }
                else
                {
                    pricePerDay *= 0.90;
                }
            }

            if (rate == "positive")
            {
                pricePerDay *= 1.25;
            }
            else if (rate == "negative")
            {
                pricePerDay *= 0.90;
            }
            Console.WriteLine($"{pricePerDay:f2}");
        }
    }
}
