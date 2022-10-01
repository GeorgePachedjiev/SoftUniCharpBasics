using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            double vremeNaepizoda = double.Parse(Console.ReadLine());
            double vremepochivka = double.Parse(Console.ReadLine());

            double vremeobqd = 0.125 * vremepochivka;
            double vremeodih = 0.25 * vremepochivka;

            double ostanaloVreme = vremepochivka - vremeobqd - vremeodih;
            double ostanaloVreme1 = ostanaloVreme - vremeNaepizoda;
            double trqbvaNivreme = vremeNaepizoda - ostanaloVreme;
            if (ostanaloVreme >= vremeNaepizoda)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(ostanaloVreme1)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Ceiling(trqbvaNivreme)} more minutes.");
            }
        }
    }
}
