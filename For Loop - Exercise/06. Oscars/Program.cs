using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int juryMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < juryMembers; i++)
            {

                string nameOfJury = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                points = ((nameOfJury.Length * points) / 2);

                academyPoints += points;

                if (academyPoints >= 1250.5)
                {
                    break;
                }
            }


            if (academyPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {academyPoints:f1}!");
            }

            else
            {
                double diff = 1250.5 - academyPoints;
                Console.WriteLine($"Sorry, {nameOfActor} you need {diff:f1} more!");
            }
        }
    }
}
