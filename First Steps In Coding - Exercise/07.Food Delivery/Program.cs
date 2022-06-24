using System;

namespace Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int cmenu = int.Parse(Console.ReadLine());
            int fmenu = int.Parse(Console.ReadLine());
            int vmenu = int.Parse(Console.ReadLine());
            double amount = cmenu * 10.35 + fmenu * 12.40 + vmenu * 8.15;
            double dessert = amount * 0.20;
            Console.WriteLine(amount + dessert + 2.50);
        }
    }
}
