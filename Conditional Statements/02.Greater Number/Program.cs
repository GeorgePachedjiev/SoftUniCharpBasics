using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int parvochislo = int.Parse(Console.ReadLine());
            int vtorochislo = int.Parse(Console.ReadLine());
            if (parvochislo > vtorochislo)
            {
                Console.WriteLine(parvochislo);
            }
            else
            {
                Console.WriteLine(vtorochislo);
            }
        }
    }
}
