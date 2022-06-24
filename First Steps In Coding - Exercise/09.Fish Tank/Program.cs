using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double dalshina = double.Parse(Console.ReadLine());
            double shirina = double.Parse(Console.ReadLine());
            double visochina = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double obem = dalshina * shirina * visochina;
            double obemltr = obem / 1000;
            double zaeto = procent / 100;
            double sum = obemltr * (1 - zaeto);
                Console.WriteLine(sum);
        }
    }
}
