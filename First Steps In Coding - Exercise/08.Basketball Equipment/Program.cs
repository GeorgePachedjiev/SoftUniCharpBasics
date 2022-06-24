using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int cena = int.Parse(Console.ReadLine());
            double kecove = cena - 0.4 * cena;
            double ekip = kecove - 0.2 * kecove;
            double topki = ekip / 4;
            double accesoari = topki / 5;
            double obshto = cena + kecove + ekip + topki + accesoari;
            Console.WriteLine(obshto);

        }
    }
}
