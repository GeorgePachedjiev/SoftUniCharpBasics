using System;

namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kuce = 2.5;
            double kote = 4;
            int broikuce = int.Parse(Console.ReadLine());
            int broikote = int.Parse(Console.ReadLine());
            Console.WriteLine((broikuce * kuce) + (broikote * kote) + " lv.");
        }
    }
}
