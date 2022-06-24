using System;

namespace Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int broistr = int.Parse(Console.ReadLine());
            int str = int.Parse(Console.ReadLine());
            int broidni = int.Parse(Console.ReadLine());
            int obstovreme = broistr / str;
            int sum = obstovreme / broidni;
            Console.WriteLine(sum);
        }
    }
}
