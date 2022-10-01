using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constants
            const double pazel = 2.60;
            const double govoreshtakukla = 3;
            const double plushenomeche = 4.10;
            const double minion = 8.20;
            const double kamionche = 2;

            //Input from user
            double cenaekskurziq = double.Parse(Console.ReadLine());
            int broipazali = int.Parse(Console.ReadLine());
            int broigovoreshtikukli = int.Parse(Console.ReadLine());
            int broiplushenimecheta = int.Parse(Console.ReadLine());
            int broiminioni = int.Parse(Console.ReadLine());
            int broikamioncheta = int.Parse(Console.ReadLine());

            //Решение
            int obsto = broipazali + broigovoreshtikukli + broiplushenimecheta + broiminioni + broikamioncheta;
            double totalprize = pazel * broipazali + govoreshtakukla * broigovoreshtikukli + plushenomeche * broiplushenimecheta + minion * broiminioni + kamionche * broikamioncheta;
            if (obsto >= 50)
            {
                totalprize *= 0.75;
            }
            double rent = 0.10 * totalprize;
            double difference = Math.Abs(rent + cenaekskurziq - totalprize);
            if (totalprize >= rent + cenaekskurziq)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
        }
    }
}
