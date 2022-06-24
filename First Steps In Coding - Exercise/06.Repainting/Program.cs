using System;

namespace Repainting1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razr = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double price = nailon * 1.50 + paint * 14.50 + razr * 5.00 + 0.10 * paint * 14.50 + 2 * 1.50 + 0.40;
            double amount = price * 0.30 * hours;
            double alltogether = price + amount;
            Console.WriteLine(alltogether);
        }
    }
}
