using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int parvi = int.Parse(Console.ReadLine());
            int vtori = int.Parse(Console.ReadLine());
            int treti = int.Parse(Console.ReadLine());
            int obsto = parvi + vtori + treti;
            int minuti = obsto / 60;
            int sekundi = obsto % 60;
            if (sekundi < 10)
            {
                Console.WriteLine($"{minuti}:0{sekundi}");
            }
            else
            {
                Console.WriteLine($"{minuti}:{sekundi}");
            }
        }
    }
}
