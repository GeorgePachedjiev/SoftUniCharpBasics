using System;

namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kvmetar = 7.61;
            double metri = double.Parse(Console.ReadLine());
            double cqlacena = kvmetar * metri;
            double otstapka = (metri * kvmetar) * 0.18;
            Console.WriteLine("The final price is: " + (cqlacena - otstapka) + " lv.");
            Console.WriteLine("The discound is: " + otstapka + " lv.");
        }
    }
}
