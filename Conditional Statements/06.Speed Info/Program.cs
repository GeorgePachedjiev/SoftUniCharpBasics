using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            if (km <= 10)
            {
                Console.WriteLine("slow");
            }
            if (km > 10 && km <=50)
            {
                Console.WriteLine("average");
            }
            if (km > 50 && km <= 150)
            {
                Console.WriteLine("fast");
            }
            if (km > 150 && km <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            if (km > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
