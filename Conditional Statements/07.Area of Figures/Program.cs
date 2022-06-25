using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string izbor = Console.ReadLine();
           
            if(izbor == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine(area);
            }
            if (izbor == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = (a * b);
                Console.WriteLine(area); 
            }
            if (izbor == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double area = (a * a * Math.PI);
                Console.WriteLine(area);
            }
            if (izbor == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = (a * b / 2);
                Console.WriteLine(area);
            }
        }
    }
}
