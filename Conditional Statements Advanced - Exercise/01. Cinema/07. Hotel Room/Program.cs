using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double numberOfNights = double.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = numberOfNights * 50;
                apartmentPrice = numberOfNights * 65;

                if (numberOfNights > 7 && numberOfNights <= 14)
                {
                    studioPrice = studioPrice - (studioPrice / 100 * 5);
                }
                else if (numberOfNights > 14)
                {
                    studioPrice = studioPrice - (studioPrice / 100 * 30);
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = numberOfNights * 75.20;
                apartmentPrice = numberOfNights * 68.70;

                if (numberOfNights >= 15)
                {
                    studioPrice = studioPrice - (studioPrice / 100 * 20);
                }
            }
            else if (month == " July" || month == "August")
            {
                studioPrice = numberOfNights * 76;
                apartmentPrice = numberOfNights * 77;
            }

            if (numberOfNights >= 14)
            {
                apartmentPrice = apartmentPrice - (apartmentPrice / 100 * 10);
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
