using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budge = double.Parse(Console.ReadLine());
            double broivideokarti = double.Parse(Console.ReadLine());
            double broiprocesori = double.Parse(Console.ReadLine());
            double broiram = double.Parse(Console.ReadLine());

            const double videocartacena = 250;
            double videoCenaobsto = videocartacena * broivideokarti;
            double procesor = 0.35 * videoCenaobsto;
            double ramobsto = 0.10 * videoCenaobsto;

            double obstaSmetka = broivideokarti * videocartacena + broiprocesori * procesor + broiram * ramobsto;

            if (broivideokarti > broiprocesori)
            {
                obstaSmetka *= 0.85;
            }
            double ostatak = budge - obstaSmetka;
            double nushnasuma = obstaSmetka - budge;
            if (budge >= obstaSmetka)
            {
                Console.WriteLine($"You have {ostatak:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {nushnasuma:f2} leva more!");
            }
        }
    }
}
