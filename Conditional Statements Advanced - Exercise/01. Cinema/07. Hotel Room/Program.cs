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

            if (Month == "May" || Month == "October")
            {
                studioPrice = Nights * 50;
                apartmentPrice = Nights * 65;

                if (Nights > 7 && Nights <= 14)
                {
                    studioPrice = studioPrice - (studioPrice / 100 * 5);
                }
                else if (Nights > 14)
                {
                    studioPrice = studioPrice - (studioPrice / 100 * 30);
                }
            }
            else if (Month == "June" || Month == "September")
            {
                studioPrice = Nights * 75.20;
                apartmentPrice = Nights * 68.70;

                if (Nights >= 15)
                {
                    studioPrice = studioPrice - (studioPrice / 100 * 20);
                }
            }
            else if (Month == " July" || Month == "August")
            {
                studioPrice = Nights * 76;
                apartmentPrice = Nights * 77;
            }

            if (Nights >= 14)
            {
                apartmentPrice = apartmentPrice - (apartmentPrice / 100 * 10);
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
