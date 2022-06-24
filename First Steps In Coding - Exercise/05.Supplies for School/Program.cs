using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double pakethimikali = 5.80;
            double paketmarkeri = 7.20;
            double preparatlit = 1.20;
            double broihim = int.Parse(Console.ReadLine());
            double broimar = int.Parse(Console.ReadLine());
            double prep = int.Parse(Console.ReadLine());
            double nam = int.Parse(Console.ReadLine());
            double cenpakhim = broihim * pakethimikali;
            double cenpakmar = broimar* paketmarkeri;
            double cenpakprep = prep * preparatlit;
            double sum = cenpakhim + cenpakmar + cenpakprep;
            //double nam1 = nam % 100;

                Console.WriteLine(sum - ((sum * nam)/100));
        }
    }
}
