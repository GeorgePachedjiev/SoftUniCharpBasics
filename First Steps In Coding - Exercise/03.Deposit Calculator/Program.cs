using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depsum = double.Parse(Console.ReadLine());
            double srokdep = double.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());

            double natlih = depsum * lihva;
            double lihedinmsc = natlih / 12;
            double obsto = depsum + srokdep * lihedinmsc;
            
            Console.WriteLine(obsto);


        }
    }
}
