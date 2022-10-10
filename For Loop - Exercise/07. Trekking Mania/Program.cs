using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int climerGroupsCount = int.Parse(Console.ReadLine());
            int musala = 0;
            int monblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 0; i < climerGroupsCount; i++)
            {

                int peopleInGroup = int.Parse(Console.ReadLine());

                if (peopleInGroup <= 5)
                {
                    musala += peopleInGroup;
                }

                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    monblan += peopleInGroup;
                }

                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    kilimandjaro += peopleInGroup;
                }

                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    k2 += peopleInGroup;
                }

                else if (peopleInGroup >= 41)
                {
                    everest += peopleInGroup;
                }


            }

            double totalPeople = musala + monblan + kilimandjaro + k2 + everest;

            double musalaPercent = (musala / totalPeople) * 100;
            double monblanPercent = (monblan / totalPeople) * 100;
            double kilimandjaroPercent = (kilimandjaro / totalPeople) * 100;
            double k2Percent = (k2 / totalPeople) * 100;
            double everestPercent = (everest / totalPeople) * 100;

            Console.WriteLine($"{musalaPercent:f2}%");
            Console.WriteLine($"{monblanPercent:f2}%");
            Console.WriteLine($"{kilimandjaroPercent:f2}%");
            Console.WriteLine($"{k2Percent:f2}%");
            Console.WriteLine($"{everestPercent:f2}%");
        }
    }
}
