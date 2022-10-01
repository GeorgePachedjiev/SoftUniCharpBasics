using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //recorda v sekundi
            double record = double.Parse(Console.ReadLine());
            //raztoqnieto v metri
            double distance = double.Parse(Console.ReadLine());
            //vremeto v sekundi za koeto pluva 1 metar
            double metarVSekunda = double.Parse(Console.ReadLine());

            double vreme = distance * metarVSekunda;
            double naPetNaiSeMetra = Math.Floor(distance / 15) * 12.5;
            double obstoVreme = vreme + naPetNaiSeMetra;

            double vremeKoetoNeEDostignalo = obstoVreme - record;
            double podoBrenoVreme = record - obstoVreme;
            if (obstoVreme >= record)
            {
                Console.WriteLine($"No, he failed! He was {vremeKoetoNeEDostignalo:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {obstoVreme:f2} seconds.");
            }
        }
    }
}
