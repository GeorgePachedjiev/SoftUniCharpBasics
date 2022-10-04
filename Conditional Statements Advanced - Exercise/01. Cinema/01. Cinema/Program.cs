using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double premiere = 12.00;
            const double normal = 7.50;
            const double discountdeca = 5.00;
            double prize = 0;

            string projectia = Console.ReadLine();
            int red = int.Parse(Console.ReadLine());
            int colona = int.Parse(Console.ReadLine());

            if (projectia == "Premiere")
            {
                prize = premiere * red * colona;
            }
            else if (projectia == "Normal")
            {
                prize = normal * red * colona;
            }
            else if (projectia == "Discount")
            {
                prize = discountdeca * red * colona;
            }
            Console.WriteLine($"{prize:f2} leva");
        }
    }
}
