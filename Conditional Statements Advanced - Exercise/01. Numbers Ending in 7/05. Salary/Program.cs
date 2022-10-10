using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nTabsInBrowsers = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < nTabsInBrowsers; i++)
            {

                string nameOfTab = Console.ReadLine();

                if (nameOfTab == "Facebook")
                {
                    salary -= 150;
                }

                else if (nameOfTab == "Instagram")
                {
                    salary -= 100;
                }

                else if (nameOfTab == "Reddit")
                {
                    salary -= 50;
                }
            }

            if (salary <= 0)
            {
                Console.WriteLine($"You have lost your salary.");
            }

            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
