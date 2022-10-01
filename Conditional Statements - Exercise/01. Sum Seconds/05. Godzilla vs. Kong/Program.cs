using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budge = double.Parse(Console.ReadLine());
            int broistatisti = int.Parse(Console.ReadLine());
            double cenanaobleklo = double.Parse(Console.ReadLine());
            double cenadecor = 0.10 * budge;
            if (broistatisti > 150)
            {
                cenanaobleklo *= 0.90;
            }
            double raznoski = cenanaobleklo * broistatisti + cenadecor;
            if (budge < raznoski)
            {
                double need = raznoski - budge;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {need:f2} leva more.");
            }
            else
            {
                double need1 = budge - raznoski;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {need1:f2} leva left.");
            }
        }
    }
}
